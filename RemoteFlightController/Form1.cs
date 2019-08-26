using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Reflection;
using Newtonsoft.Json;
using System.Linq;

namespace RemoteFlightController
{
    public struct ControlsUpdate        // Data sent to the plane to update the control panel.
    {
        public double Throttle;         // Current throttle setting as a percentage          (i.e. 0% no throttle, 100% full throttle).
        public double ElevatorPitch;    // Current Elevator Pitch in degrees. Positive creates upwards lift, negative downwards.
    }
    public struct TelemetryUpdate       // Telemetry data received from the airplane will be sent several times a second from the airplane.
    {
        public double Altitude;         // Altitude in ft.
        public double Speed;            // Plane's speed in Knts.
        public double Pitch;            // Plane's pitch in degrees relative to horizon. Positive is planes pointing upwards, negative plane points downwards;
        public double VerticalSpeed;    // Plane's vertical speed in Feet per minute.

        public double Throttle;         // Current throttle setting as a percentage (i.e. 0% no throttle, 100% full throttle).
        public double ElevatorPitch;    // Current Elevator Pitch in degrees. Positive creates upwards lift, negative downwards.

        public int WarningCode;         // Warning code: 0 - No Warnings; 1 -  Too Low (less than 1000ft); 2 - Stall. 

        /*This describes the current state of the plane, most of the above fields are self explanatory. 
        However, the WarningCode field contains an integer that indicates whether the plane is in danger. 
        The values it could hold are 0, 1 or 2 indicating there are no warnings, the plane is too low or 
        is at risk of a stall respectively. */
    }
    /*
    
     * Four steps to using an event:
     
     * Declare a delegate that the event will use.
     * Declare an event of the same type as the delegate.
     * Register delegate instances with the event.
     * Invoke the event.
*/
    // Delegates are declared so that an event can execute.
    public delegate void IncomingMessage(TelemetryUpdate telemetryUpdate); // Handles incoming messages from the remote flight simulator by creating a new object of TelemetryUpdate.
    public delegate void OutgoingMessage(ControlsUpdate controlsUpdate);   // Handles outgoing messages from the remote flight simulator by creating a new object of ControlsUpdate and sending out data this end of the connection.
    public delegate void IncomingWarning(string message);                  // Handles Warnings while incoming messages are being retrieved from the remote flight simulator.


    public partial class frmRemoteFlightController : Form
    {
        /* A TcpClient represents the connection to another socket. 
           Allows for connectivety to other remote devices/ endpoints using a socket.
           * TCP handles the complicated stuff
           * Establishing the connection.
           * Breaking your message into packets.
           * Assembling the received packets.
           * Error checking.
        */
        TcpClient client = new TcpClient();                     

        MessageReciever messageReciever = new MessageReciever(); // A new Object of the class is created to retrieve incoming messages e.g(Telemtery data and Warnings).
        MessageSender messageSender = new MessageSender();       // A new Object of the class is created to send out data from this end of the connection via the ControlsUpdate.

        public frmRemoteFlightController()
        {
            InitializeComponent();

            // Registers delegates to an event within the respective classes.
            // creates an instance of a delgates and register it by using the += operator.
            messageReciever.OnNewRetrievedMessage += new IncomingMessage(RetrieveNewMessage);        // The event "OnNewRetrievedMessage" is invoked within the messageReciever class and retrieves a new message as its argument.
            messageSender.OnNewSentMessage += new OutgoingMessage(DeliverNewMessage);                // The event "OnNewSentMessage" is invoked within the messageSender class and sends a new message as its argument.
            messageReciever.OnNewWarning += new IncomingWarning(RetrieveflightWarning);              // The event "OnNewWarning" is invoked within the message reciever class and retrieves a new warning when nesscary as its argument.

            /*
             The following ReadOnly statments are used to prevent the user from entering any 
             characters, numbers or special symbols into the respective text boxes.
             */
            txtAltitude.ReadOnly = true;
            txtAirSpeed.ReadOnly = true;
            txtPitchAngle.ReadOnly = true;
            txtVerticalSpeed.ReadOnly = true;
            txtThrottle.ReadOnly = true;
            txtElevatorPitch.ReadOnly = true;
            txtControlDetails.ReadOnly = true;
        }
        private void BtnConnect_Click(object sender, EventArgs e)   // Connects to the flight Simulator.
        {
            int port = 9999;                            // Port is used to specify the application.
            string ipAddress = txtIPAddress.Text;       // The IP address entered into the IP address text box is stored as string.
            txtPort.Text = Convert.ToString(port);      // The number entered into the text box for the port number is converted from a integer to a string to allow it to be entered.
            IPAddress ip = IPAddress.Parse(ipAddress);  // Provides an internet protocol and converts the the stored IP address to an IPAddress instance.

            try
            {
                client.Connect(ipAddress, port);            // Connects the client to the specifed port on the specifed host using the TcpClient protocol e.g.(Ip address and port number entered during runtime).
                MessageBox.Show("Connected!", "Connection Established");              // This will notify the user that they have connected to the remote flight simulator.
                lblConnectionStatus.Text = ip.ToString();   // Shows the current connected IP Address.
                txtIPAddress.ReadOnly = true;
                txtPort.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Open the port!");  // If the port isn't opened on the remote flight simulator this exeception will be thrown and the program will close.

            }

            Thread T = new Thread(new ThreadStart(messageReciever.StartRetrievingMessages)); // Once the simulations has started this worker thread will be created and controlled to being reading data from the 
                                                                                             // flight simulator and will be displayed in the respective text boxes and data grid view.
            T.Start();                                                                       // The worker thread begins running.

            NetworkStream stream = client.GetStream();                                      // TcpClient has a method to ".GetStream()" this returns a NetworkStream object. It allows for data to be sent and recieved from this endpoint.
            MessageReciever.stream = stream;                                                // Allows access to the MessageReciever class.
        }
        private void BtnProcessData_Click(object sender, EventArgs e) // Adjusts the controls from this endpoint.
        {
            ControlsUpdate controlsUpdate = new ControlsUpdate();   // New object is created for ControlsUpdate.
            NetworkStream stream = client.GetStream();              // TcpClient has a method to ".GetStream()" this returns a NetworkStream object. It allows for data to be sent and recieved from this endpoint.

            controlsUpdate.Throttle = trkThrottle.Value;                    // The value of the throttle track bar is stored in the object created for ControlsUpdate.
            controlsUpdate.ElevatorPitch = trkElevatorPitch.Value * 0.1;    // The value of the ElevatorPitch track bar is stored in the object created for ControlsUpdate.
            messageSender.stream = stream;                                  // Allows Access to the messageSender Class.
            messageSender.StartSendingMessages(controlsUpdate);             // Messages are sent to the flight simulator via this method once processData is clicked.
        }
        public class MessageReciever // TelemetryUpdate Handler
        {
            public event IncomingMessage OnNewRetrievedMessage;  // This event notifies listners that a message was recieved.
            public event IncomingWarning OnNewWarning;           // This event notifies listners that a warning was recieved.
            public static NetworkStream stream;                  // Provides the underlying stream of data for network access. (Static keyword: A static member can be accessed using the type name instead of a reference or value).
            private bool generate_Message = false;               // This flag is used to indicate if StartRetrievingMessages() has been invoked.

            public void StartRetrievingMessages()                // This method starts reading messages as long as the condition of the while loop is met.
            {
                TelemetryUpdate telemetryUpdate = new TelemetryUpdate();   // New object of TelemetryUpdate is created.     
                generate_Message = true;        

                while (generate_Message)        
                {
                    byte[] sendBuffer = new byte[256];                                      // Creates a buffer to write into.
                    int num_bytes = stream.Read(sendBuffer, 0, 256);                        // This handles the number of bytes recieved and the maximum number of bytes willing to be accepted. 
                                                                                            // stream.Read will block the current thread until data is recieved.
                    string message = Encoding.ASCII.GetString(sendBuffer, 0, num_bytes);    // Decodes a sequence of bytes from the specifed byte array into a string.
                    JavaScriptSerializer Serializer = new JavaScriptSerializer();           // Provides serialisation functionality and initalizes a new instance. Additonally, Allows for data to be Serialized and Deserialized.
                    telemetryUpdate = Serializer.Deserialize<TelemetryUpdate>(message);     // Converts string message to a object of type T and is passed into telemetryUpdate. The data is Deserialized.

                    OnNewRetrievedMessage?.Invoke(telemetryUpdate); // The OnNewRetrievedMessage event is handled here. This will only invoke the event if the event(telemetryUpdate) is not null. ? = if not null then execute.


                    // The OnNewWarning event is handled in this next section. If the warning code is equal to any of the following the 
                    // event will be invoked and the following message will be displayed to the respective labels/ text boxes in RetrieveNewMessage method.
                    if (telemetryUpdate.WarningCode == 0)
                        OnNewWarning?.Invoke("");
                    else if (telemetryUpdate.WarningCode == 1)
                        OnNewWarning?.Invoke("Warning Level: 1 - Plane too Low, increase Elevator Pitch! (less than 1000ft!)");
                    else if (telemetryUpdate.WarningCode == 2)
                        OnNewWarning?.Invoke("Warning Level: 2 - Stall Risk! lower elevator pitch and increase throttle!");
                    else //This else Conditon will never execute.
                        OnNewWarning?.Invoke("Plane Crash! fighlt simulator over!");
                }
            }

        }
        private void RetrieveNewMessage(TelemetryUpdate telemetryUpdate) // Used to retrieve the messages and store them in the below locations (telemetryUpdate is also passed in here).
        {
            // Checks if the thread is on the correct thread, if not and invoke is require, invoke this method is called on correct thread.
            if (this.InvokeRequired)
            {
                this.Invoke(new IncomingMessage(RetrieveNewMessage), new object[] { telemetryUpdate }); // Calls invoke on the current function. Delegate targets method to invoke, taking one arguemnt telemetryUpdate.
            }
            else
            {
                // The following takes the contents of telemetryUpdate and stores them in to the relvant text boxes for display.
                //extract each field from telemetry update into spearate text boxes.
                txtAirSpeed.Text = telemetryUpdate.Speed.ToString();
                txtVerticalSpeed.Text = telemetryUpdate.VerticalSpeed.ToString();
                txtPitchAngle.Text = telemetryUpdate.Pitch.ToString();
                txtAltitude.Text = telemetryUpdate.Altitude.ToString();
                txtThrottle.Text = telemetryUpdate.Throttle.ToString();
                txtElevatorPitch.Text = telemetryUpdate.ElevatorPitch.ToString();

                
                int rowId = dgvTelemetryInfo.Rows.Add(); // Adds a row everytime a new entry is retrieved.
                DataGridViewRow row = dgvTelemetryInfo.Rows[rowId];
                // Each Field of telemetryUpdate is extracted and stored in the following cells.
                row.Cells[0].Value = telemetryUpdate.Altitude.ToString();
                row.Cells[1].Value = telemetryUpdate.Speed.ToString();
                row.Cells[2].Value = telemetryUpdate.Pitch.ToString();
                row.Cells[3].Value = telemetryUpdate.VerticalSpeed.ToString();
                row.Cells[4].Value = telemetryUpdate.Throttle.ToString();
                row.Cells[5].Value = telemetryUpdate.ElevatorPitch.ToString();
                row.Cells[6].Value = telemetryUpdate.WarningCode.ToString();
                // The follow condition allows the data grid view to update its field respectively to the currents status of the telemtry data and the fixed length of the data grid view.
                if (dgvTelemetryInfo.Rows[dgvTelemetryInfo.Rows.Count - 1].Displayed == true)
                {
                    dgvTelemetryInfo.FirstDisplayedScrollingRowIndex = dgvTelemetryInfo.Rows.Count - 1; // Displays the first row of the data grid view permantly. However, if the rows go beyond the length of the data grid view
                                                                                                        // That data won't be avaliable to view.
                    dgvTelemetryInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;           // Fixes the above problem, the rows are limited to the length of the data grid view.
                    // Both first row and last row are within the length of the data grid view and any updates to the field are viewable.
                }
            }
        }
        private void RetrieveflightWarning(string message) // Retrieves flight warnings and passes the message in the form of a string.
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new IncomingWarning(RetrieveflightWarning), new object[] { message }); // Calls invoke on the current function. Delegate targets method to invoke, taking one arguemnt (string) message.
            }
            else
            {
                lblCurrentWarningMessage.Text = message; // The message is stored in the lblCurrentWarningMessage.Text, unless the circumstances change.
            }
        }
        public class MessageSender // ControlsUpdate Handler
        {
            public event OutgoingMessage OnNewSentMessage; // This event notifies listners that a message was sent.
            public NetworkStream stream;                   // Provides the underlying stream of data for network access. (Static keyword: A static member can be accessed using the type name instead of a reference or value).
            public void StartSendingMessages(ControlsUpdate controlsUpdate) // This method starts writing messages once the process data button is pressed.
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer(); // Provides serialisation functionality and initalizes a new instance. Additonally, Allows for data to be Serialized and Deserialized.
                string jsonString = serializer.Serialize(controlsUpdate);     // Serializes the fields in controlsUpdate and stores it in a string called jsonString.
                byte[] rawData = Encoding.ASCII.GetBytes(jsonString);         //  Encodes all characters in the specified string into a sequence of bytes. Takes jsonString and is stored in a byte array.

                stream.Write(rawData, 0, rawData.Length);                     // rawData is written out, starting from an index of 0 and writes until the last index of the rawData.
                OnNewSentMessage?.Invoke(controlsUpdate);                     // The OnNewSentMessage event is handled here. This will only invoke the event if the event (controlsUpdate) is not null. ? = if not null then execute.
            }
        }
        private void DeliverNewMessage(ControlsUpdate controlsUpdate) // Sends data to the remote flight simulator in the form of seralized data in a message and updates the current controls.
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new OutgoingMessage(DeliverNewMessage), new object[] { controlsUpdate }); // Calls invoke on the current function. Delegate targets method to invoke, taking one arguemnt (string) message.
            }
            else
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();   // Provides serialisation functionality and initalizes a new instance. Additonally, Allows for data to be Serialized and Deserialized.
                string jsonText = serializer.Serialize(controlsUpdate);         // Serializes the fields in controlsUpdate and stores it in a string called jsonText.
                txtControlDetails.AppendText(jsonText + Environment.NewLine);   // Appends the string to a text box so that the fields of controlsUpdate will appear on the same line. 
            }
        }
        private void TrkElevatorPitch_Scroll(object sender, EventArgs e) // Enables the functionality of the Elevator pitch track bar.
        {
            trkElevatorPitch.Minimum = -50; // Minimum value of the track bar.
            trkElevatorPitch.Maximum = 50;  // Maximum value of the track bar.

            double elevatorPitchValue = (trkElevatorPitch.Value * 0.1) / trkElevatorPitch.TickFrequency; // Takes the value of the elevatorPitch and multiplies by 0.1 
                                                                                                         // then divides by the tick frequency which will allow the elevator pitch to scroll by 0.1 everytime its moved and is store in a double.
            lblCurrentElevatorPitch.Text = elevatorPitchValue.ToString() + "%";                          // The double is then displayed in a label to show the current elevator pitch. 
        }
        private void TBarThrottle_Scroll(object sender, EventArgs e) // Enables the functionality of the throttle track bar.
        {
            trkThrottle.Minimum = 0;   // Minimum value of the track bar.
            trkThrottle.Maximum = 100; // Maximum value of the track bar.
            trkThrottle.TickFrequency = 1; // Transitioning/ Interval between tick marks.
            lblCurrentThrottle.Text = trkThrottle.Value.ToString() + ".0%"; // The value of the throttle is then displayed in a label to show the current value of the throttle. 
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the program.
        }

        
    }
}
