namespace RemoteFlightController
{
    partial class frmRemoteFlightController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.lblPortNumber = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpCurrentThrottle = new System.Windows.Forms.GroupBox();
            this.lblCurrentThrottle = new System.Windows.Forms.Label();
            this.trkThrottle = new System.Windows.Forms.TrackBar();
            this.lblMinThrottle = new System.Windows.Forms.Label();
            this.lblMaxThrottle = new System.Windows.Forms.Label();
            this.grpConnectionDetails = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.lblCurrentConnection = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblElevatorPitch = new System.Windows.Forms.Label();
            this.grp = new System.Windows.Forms.GroupBox();
            this.trkElevatorPitch = new System.Windows.Forms.TrackBar();
            this.grpCurrentElevatorPitch = new System.Windows.Forms.GroupBox();
            this.lblCurrentElevatorPitch = new System.Windows.Forms.Label();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.grpOutgoingControlsDetails = new System.Windows.Forms.GroupBox();
            this.txtControlDetails = new System.Windows.Forms.TextBox();
            this.btnProcessData = new System.Windows.Forms.Button();
            this.txtPitchAngle = new System.Windows.Forms.TextBox();
            this.txtVerticalSpeed = new System.Windows.Forms.TextBox();
            this.txtAltitude = new System.Windows.Forms.TextBox();
            this.txtAirSpeed = new System.Windows.Forms.TextBox();
            this.grpInitialSettings = new System.Windows.Forms.GroupBox();
            this.txtThrottle = new System.Windows.Forms.TextBox();
            this.txtElevatorPitch = new System.Windows.Forms.TextBox();
            this.lblThrottle = new System.Windows.Forms.Label();
            this.lblElevatorPitc = new System.Windows.Forms.Label();
            this.lblAirSpeed = new System.Windows.Forms.Label();
            this.lblPitchAngle = new System.Windows.Forms.Label();
            this.lblVerticalSpeed = new System.Windows.Forms.Label();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.grpWarnings = new System.Windows.Forms.GroupBox();
            this.lblWarningMessage = new System.Windows.Forms.Label();
            this.lblCurrentWarningMessage = new System.Windows.Forms.Label();
            this.grpTelemetryInfo = new System.Windows.Forms.GroupBox();
            this.dgvTelemetryInfo = new System.Windows.Forms.DataGridView();
            this.dgvAltitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVerticalSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvThrottle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvElevatorPitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvWarningCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.grpCurrentThrottle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkThrottle)).BeginInit();
            this.grpConnectionDetails.SuspendLayout();
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkElevatorPitch)).BeginInit();
            this.grpCurrentElevatorPitch.SuspendLayout();
            this.grpControls.SuspendLayout();
            this.grpOutgoingControlsDetails.SuspendLayout();
            this.grpInitialSettings.SuspendLayout();
            this.grpWarnings.SuspendLayout();
            this.grpTelemetryInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelemetryInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(365, 17);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(103, 24);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(1, 23);
            this.lblIPAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(61, 13);
            this.lblIPAddress.TabIndex = 1;
            this.lblIPAddress.Text = "IP Address:";
            // 
            // lblPortNumber
            // 
            this.lblPortNumber.AutoSize = true;
            this.lblPortNumber.Location = new System.Drawing.Point(183, 23);
            this.lblPortNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPortNumber.Name = "lblPortNumber";
            this.lblPortNumber.Size = new System.Drawing.Size(69, 13);
            this.lblPortNumber.TabIndex = 2;
            this.lblPortNumber.Text = "Port Number:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(256, 20);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(88, 20);
            this.txtPort.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpCurrentThrottle);
            this.groupBox1.Controls.Add(this.trkThrottle);
            this.groupBox1.Controls.Add(this.lblMinThrottle);
            this.groupBox1.Controls.Add(this.lblMaxThrottle);
            this.groupBox1.Location = new System.Drawing.Point(7, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(153, 238);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Throttle";
            // 
            // grpCurrentThrottle
            // 
            this.grpCurrentThrottle.Controls.Add(this.lblCurrentThrottle);
            this.grpCurrentThrottle.Location = new System.Drawing.Point(7, 97);
            this.grpCurrentThrottle.Name = "grpCurrentThrottle";
            this.grpCurrentThrottle.Size = new System.Drawing.Size(87, 60);
            this.grpCurrentThrottle.TabIndex = 16;
            this.grpCurrentThrottle.TabStop = false;
            this.grpCurrentThrottle.Text = "Current";
            // 
            // lblCurrentThrottle
            // 
            this.lblCurrentThrottle.AutoSize = true;
            this.lblCurrentThrottle.Location = new System.Drawing.Point(25, 28);
            this.lblCurrentThrottle.Name = "lblCurrentThrottle";
            this.lblCurrentThrottle.Size = new System.Drawing.Size(30, 13);
            this.lblCurrentThrottle.TabIndex = 15;
            this.lblCurrentThrottle.Text = "0.0%";
            // 
            // trkThrottle
            // 
            this.trkThrottle.Location = new System.Drawing.Point(99, 14);
            this.trkThrottle.Margin = new System.Windows.Forms.Padding(2);
            this.trkThrottle.Name = "trkThrottle";
            this.trkThrottle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkThrottle.Size = new System.Drawing.Size(45, 213);
            this.trkThrottle.TabIndex = 18;
            this.trkThrottle.Scroll += new System.EventHandler(this.TBarThrottle_Scroll);
            // 
            // lblMinThrottle
            // 
            this.lblMinThrottle.AutoSize = true;
            this.lblMinThrottle.Location = new System.Drawing.Point(59, 214);
            this.lblMinThrottle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinThrottle.Name = "lblMinThrottle";
            this.lblMinThrottle.Size = new System.Drawing.Size(21, 13);
            this.lblMinThrottle.TabIndex = 6;
            this.lblMinThrottle.Text = "0%";
            // 
            // lblMaxThrottle
            // 
            this.lblMaxThrottle.AutoSize = true;
            this.lblMaxThrottle.Location = new System.Drawing.Point(59, 15);
            this.lblMaxThrottle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxThrottle.Name = "lblMaxThrottle";
            this.lblMaxThrottle.Size = new System.Drawing.Size(33, 13);
            this.lblMaxThrottle.TabIndex = 4;
            this.lblMaxThrottle.Text = "100%";
            // 
            // grpConnectionDetails
            // 
            this.grpConnectionDetails.Controls.Add(this.btnExit);
            this.grpConnectionDetails.Controls.Add(this.lblConnectionStatus);
            this.grpConnectionDetails.Controls.Add(this.lblCurrentConnection);
            this.grpConnectionDetails.Controls.Add(this.btnConnect);
            this.grpConnectionDetails.Controls.Add(this.lblIPAddress);
            this.grpConnectionDetails.Controls.Add(this.lblPortNumber);
            this.grpConnectionDetails.Controls.Add(this.txtPort);
            this.grpConnectionDetails.Controls.Add(this.txtIPAddress);
            this.grpConnectionDetails.Location = new System.Drawing.Point(16, 9);
            this.grpConnectionDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpConnectionDetails.Name = "grpConnectionDetails";
            this.grpConnectionDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpConnectionDetails.Size = new System.Drawing.Size(542, 76);
            this.grpConnectionDetails.TabIndex = 4;
            this.grpConnectionDetails.TabStop = false;
            this.grpConnectionDetails.Text = "Connection Details";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(365, 45);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 24);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(106, 50);
            this.lblConnectionStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(79, 13);
            this.lblConnectionStatus.TabIndex = 5;
            this.lblConnectionStatus.Text = "Not Connected";
            // 
            // lblCurrentConnection
            // 
            this.lblCurrentConnection.AutoSize = true;
            this.lblCurrentConnection.Location = new System.Drawing.Point(1, 50);
            this.lblCurrentConnection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentConnection.Name = "lblCurrentConnection";
            this.lblCurrentConnection.Size = new System.Drawing.Size(101, 13);
            this.lblCurrentConnection.TabIndex = 4;
            this.lblCurrentConnection.Text = "Current Connection:";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(74, 20);
            this.txtIPAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(88, 20);
            this.txtIPAddress.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "5.0%";
            // 
            // lblElevatorPitch
            // 
            this.lblElevatorPitch.AutoSize = true;
            this.lblElevatorPitch.Location = new System.Drawing.Point(66, 214);
            this.lblElevatorPitch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElevatorPitch.Name = "lblElevatorPitch";
            this.lblElevatorPitch.Size = new System.Drawing.Size(33, 13);
            this.lblElevatorPitch.TabIndex = 6;
            this.lblElevatorPitch.Text = "-5.0%";
            // 
            // grp
            // 
            this.grp.Controls.Add(this.trkElevatorPitch);
            this.grp.Controls.Add(this.grpCurrentElevatorPitch);
            this.grp.Controls.Add(this.lblElevatorPitch);
            this.grp.Controls.Add(this.label2);
            this.grp.Location = new System.Drawing.Point(172, 19);
            this.grp.Margin = new System.Windows.Forms.Padding(2);
            this.grp.Name = "grp";
            this.grp.Padding = new System.Windows.Forms.Padding(2);
            this.grp.Size = new System.Drawing.Size(153, 238);
            this.grp.TabIndex = 5;
            this.grp.TabStop = false;
            this.grp.Text = "Elevator Pitch";
            // 
            // trkElevatorPitch
            // 
            this.trkElevatorPitch.Location = new System.Drawing.Point(104, 15);
            this.trkElevatorPitch.Margin = new System.Windows.Forms.Padding(2);
            this.trkElevatorPitch.Maximum = 5;
            this.trkElevatorPitch.Minimum = -5;
            this.trkElevatorPitch.Name = "trkElevatorPitch";
            this.trkElevatorPitch.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkElevatorPitch.Size = new System.Drawing.Size(45, 213);
            this.trkElevatorPitch.TabIndex = 17;
            this.trkElevatorPitch.Scroll += new System.EventHandler(this.TrkElevatorPitch_Scroll);
            // 
            // grpCurrentElevatorPitch
            // 
            this.grpCurrentElevatorPitch.Controls.Add(this.lblCurrentElevatorPitch);
            this.grpCurrentElevatorPitch.Location = new System.Drawing.Point(12, 97);
            this.grpCurrentElevatorPitch.Name = "grpCurrentElevatorPitch";
            this.grpCurrentElevatorPitch.Size = new System.Drawing.Size(87, 60);
            this.grpCurrentElevatorPitch.TabIndex = 13;
            this.grpCurrentElevatorPitch.TabStop = false;
            this.grpCurrentElevatorPitch.Text = "Current";
            // 
            // lblCurrentElevatorPitch
            // 
            this.lblCurrentElevatorPitch.AutoSize = true;
            this.lblCurrentElevatorPitch.Location = new System.Drawing.Point(25, 28);
            this.lblCurrentElevatorPitch.Name = "lblCurrentElevatorPitch";
            this.lblCurrentElevatorPitch.Size = new System.Drawing.Size(30, 13);
            this.lblCurrentElevatorPitch.TabIndex = 15;
            this.lblCurrentElevatorPitch.Text = "0.0%";
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.grpOutgoingControlsDetails);
            this.grpControls.Controls.Add(this.grp);
            this.grpControls.Controls.Add(this.groupBox1);
            this.grpControls.Controls.Add(this.btnProcessData);
            this.grpControls.Location = new System.Drawing.Point(763, 26);
            this.grpControls.Margin = new System.Windows.Forms.Padding(2);
            this.grpControls.Name = "grpControls";
            this.grpControls.Padding = new System.Windows.Forms.Padding(2);
            this.grpControls.Size = new System.Drawing.Size(343, 587);
            this.grpControls.TabIndex = 6;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // grpOutgoingControlsDetails
            // 
            this.grpOutgoingControlsDetails.Controls.Add(this.txtControlDetails);
            this.grpOutgoingControlsDetails.Location = new System.Drawing.Point(7, 309);
            this.grpOutgoingControlsDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpOutgoingControlsDetails.Name = "grpOutgoingControlsDetails";
            this.grpOutgoingControlsDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpOutgoingControlsDetails.Size = new System.Drawing.Size(318, 267);
            this.grpOutgoingControlsDetails.TabIndex = 14;
            this.grpOutgoingControlsDetails.TabStop = false;
            this.grpOutgoingControlsDetails.Text = "Outgoing Controls Details";
            // 
            // txtControlDetails
            // 
            this.txtControlDetails.Location = new System.Drawing.Point(5, 20);
            this.txtControlDetails.Multiline = true;
            this.txtControlDetails.Name = "txtControlDetails";
            this.txtControlDetails.Size = new System.Drawing.Size(307, 242);
            this.txtControlDetails.TabIndex = 14;
            // 
            // btnProcessData
            // 
            this.btnProcessData.Location = new System.Drawing.Point(68, 262);
            this.btnProcessData.Name = "btnProcessData";
            this.btnProcessData.Size = new System.Drawing.Size(212, 22);
            this.btnProcessData.TabIndex = 7;
            this.btnProcessData.Text = "Process Data";
            this.btnProcessData.UseVisualStyleBackColor = true;
            this.btnProcessData.Click += new System.EventHandler(this.BtnProcessData_Click);
            // 
            // txtPitchAngle
            // 
            this.txtPitchAngle.Location = new System.Drawing.Point(71, 44);
            this.txtPitchAngle.Name = "txtPitchAngle";
            this.txtPitchAngle.Size = new System.Drawing.Size(180, 20);
            this.txtPitchAngle.TabIndex = 8;
            // 
            // txtVerticalSpeed
            // 
            this.txtVerticalSpeed.Location = new System.Drawing.Point(348, 20);
            this.txtVerticalSpeed.Name = "txtVerticalSpeed";
            this.txtVerticalSpeed.Size = new System.Drawing.Size(180, 20);
            this.txtVerticalSpeed.TabIndex = 9;
            // 
            // txtAltitude
            // 
            this.txtAltitude.Location = new System.Drawing.Point(348, 44);
            this.txtAltitude.Name = "txtAltitude";
            this.txtAltitude.Size = new System.Drawing.Size(180, 20);
            this.txtAltitude.TabIndex = 10;
            // 
            // txtAirSpeed
            // 
            this.txtAirSpeed.Location = new System.Drawing.Point(71, 20);
            this.txtAirSpeed.Name = "txtAirSpeed";
            this.txtAirSpeed.Size = new System.Drawing.Size(180, 20);
            this.txtAirSpeed.TabIndex = 11;
            // 
            // grpInitialSettings
            // 
            this.grpInitialSettings.Controls.Add(this.txtThrottle);
            this.grpInitialSettings.Controls.Add(this.txtElevatorPitch);
            this.grpInitialSettings.Controls.Add(this.lblThrottle);
            this.grpInitialSettings.Controls.Add(this.lblElevatorPitc);
            this.grpInitialSettings.Controls.Add(this.lblAirSpeed);
            this.grpInitialSettings.Controls.Add(this.txtAltitude);
            this.grpInitialSettings.Controls.Add(this.txtAirSpeed);
            this.grpInitialSettings.Controls.Add(this.txtVerticalSpeed);
            this.grpInitialSettings.Controls.Add(this.lblPitchAngle);
            this.grpInitialSettings.Controls.Add(this.txtPitchAngle);
            this.grpInitialSettings.Controls.Add(this.lblVerticalSpeed);
            this.grpInitialSettings.Controls.Add(this.lblAltitude);
            this.grpInitialSettings.Location = new System.Drawing.Point(16, 89);
            this.grpInitialSettings.Name = "grpInitialSettings";
            this.grpInitialSettings.Size = new System.Drawing.Size(542, 102);
            this.grpInitialSettings.TabIndex = 12;
            this.grpInitialSettings.TabStop = false;
            this.grpInitialSettings.Text = "Incoming Telemetry details ";
            // 
            // txtThrottle
            // 
            this.txtThrottle.Location = new System.Drawing.Point(71, 68);
            this.txtThrottle.Name = "txtThrottle";
            this.txtThrottle.Size = new System.Drawing.Size(180, 20);
            this.txtThrottle.TabIndex = 23;
            // 
            // txtElevatorPitch
            // 
            this.txtElevatorPitch.Location = new System.Drawing.Point(348, 68);
            this.txtElevatorPitch.Name = "txtElevatorPitch";
            this.txtElevatorPitch.Size = new System.Drawing.Size(180, 20);
            this.txtElevatorPitch.TabIndex = 22;
            // 
            // lblThrottle
            // 
            this.lblThrottle.AutoSize = true;
            this.lblThrottle.Location = new System.Drawing.Point(20, 71);
            this.lblThrottle.Name = "lblThrottle";
            this.lblThrottle.Size = new System.Drawing.Size(46, 13);
            this.lblThrottle.TabIndex = 21;
            this.lblThrottle.Text = "Throttle:";
            // 
            // lblElevatorPitc
            // 
            this.lblElevatorPitc.AutoSize = true;
            this.lblElevatorPitc.Location = new System.Drawing.Point(272, 71);
            this.lblElevatorPitc.Name = "lblElevatorPitc";
            this.lblElevatorPitc.Size = new System.Drawing.Size(76, 13);
            this.lblElevatorPitc.TabIndex = 20;
            this.lblElevatorPitc.Text = "Elevator Pitch:";
            // 
            // lblAirSpeed
            // 
            this.lblAirSpeed.AutoSize = true;
            this.lblAirSpeed.Location = new System.Drawing.Point(13, 23);
            this.lblAirSpeed.Name = "lblAirSpeed";
            this.lblAirSpeed.Size = new System.Drawing.Size(53, 13);
            this.lblAirSpeed.TabIndex = 19;
            this.lblAirSpeed.Text = "AirSpeed:";
            // 
            // lblPitchAngle
            // 
            this.lblPitchAngle.AutoSize = true;
            this.lblPitchAngle.Location = new System.Drawing.Point(6, 46);
            this.lblPitchAngle.Name = "lblPitchAngle";
            this.lblPitchAngle.Size = new System.Drawing.Size(64, 13);
            this.lblPitchAngle.TabIndex = 18;
            this.lblPitchAngle.Text = "Pitch Angle:";
            // 
            // lblVerticalSpeed
            // 
            this.lblVerticalSpeed.AutoSize = true;
            this.lblVerticalSpeed.Location = new System.Drawing.Point(264, 22);
            this.lblVerticalSpeed.Name = "lblVerticalSpeed";
            this.lblVerticalSpeed.Size = new System.Drawing.Size(79, 13);
            this.lblVerticalSpeed.TabIndex = 17;
            this.lblVerticalSpeed.Text = "Vertical Speed:";
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Location = new System.Drawing.Point(298, 48);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(45, 13);
            this.lblAltitude.TabIndex = 16;
            this.lblAltitude.Text = "Altitude:";
            // 
            // grpWarnings
            // 
            this.grpWarnings.Controls.Add(this.lblWarningMessage);
            this.grpWarnings.Controls.Add(this.lblCurrentWarningMessage);
            this.grpWarnings.Location = new System.Drawing.Point(16, 198);
            this.grpWarnings.Name = "grpWarnings";
            this.grpWarnings.Size = new System.Drawing.Size(735, 68);
            this.grpWarnings.TabIndex = 13;
            this.grpWarnings.TabStop = false;
            this.grpWarnings.Text = "Warnings";
            // 
            // lblWarningMessage
            // 
            this.lblWarningMessage.AutoSize = true;
            this.lblWarningMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarningMessage.Location = new System.Drawing.Point(6, 28);
            this.lblWarningMessage.Name = "lblWarningMessage";
            this.lblWarningMessage.Size = new System.Drawing.Size(121, 16);
            this.lblWarningMessage.TabIndex = 1;
            this.lblWarningMessage.Text = "Warning Message:";
            // 
            // lblCurrentWarningMessage
            // 
            this.lblCurrentWarningMessage.AutoSize = true;
            this.lblCurrentWarningMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWarningMessage.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentWarningMessage.Location = new System.Drawing.Point(138, 28);
            this.lblCurrentWarningMessage.Name = "lblCurrentWarningMessage";
            this.lblCurrentWarningMessage.Size = new System.Drawing.Size(0, 16);
            this.lblCurrentWarningMessage.TabIndex = 0;
            // 
            // grpTelemetryInfo
            // 
            this.grpTelemetryInfo.Controls.Add(this.dgvTelemetryInfo);
            this.grpTelemetryInfo.Location = new System.Drawing.Point(16, 271);
            this.grpTelemetryInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpTelemetryInfo.Name = "grpTelemetryInfo";
            this.grpTelemetryInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpTelemetryInfo.Size = new System.Drawing.Size(735, 342);
            this.grpTelemetryInfo.TabIndex = 5;
            this.grpTelemetryInfo.TabStop = false;
            this.grpTelemetryInfo.Text = "Telemetry Info";
            // 
            // dgvTelemetryInfo
            // 
            this.dgvTelemetryInfo.AllowUserToDeleteRows = false;
            this.dgvTelemetryInfo.AllowUserToOrderColumns = true;
            this.dgvTelemetryInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelemetryInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvAltitude,
            this.dgvSpeed,
            this.dgvPitch,
            this.dgvVerticalSpeed,
            this.dgvThrottle,
            this.dgvElevatorPitch,
            this.dgvWarningCode});
            this.dgvTelemetryInfo.Location = new System.Drawing.Point(5, 17);
            this.dgvTelemetryInfo.Name = "dgvTelemetryInfo";
            this.dgvTelemetryInfo.ReadOnly = true;
            this.dgvTelemetryInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTelemetryInfo.Size = new System.Drawing.Size(720, 314);
            this.dgvTelemetryInfo.TabIndex = 0;
            // 
            // dgvAltitude
            // 
            this.dgvAltitude.HeaderText = "Altitude";
            this.dgvAltitude.Name = "dgvAltitude";
            this.dgvAltitude.ReadOnly = true;
            this.dgvAltitude.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvSpeed
            // 
            this.dgvSpeed.HeaderText = "Speed";
            this.dgvSpeed.Name = "dgvSpeed";
            this.dgvSpeed.ReadOnly = true;
            // 
            // dgvPitch
            // 
            this.dgvPitch.HeaderText = "Pitch";
            this.dgvPitch.Name = "dgvPitch";
            this.dgvPitch.ReadOnly = true;
            // 
            // dgvVerticalSpeed
            // 
            this.dgvVerticalSpeed.HeaderText = "Vertical Speed";
            this.dgvVerticalSpeed.Name = "dgvVerticalSpeed";
            this.dgvVerticalSpeed.ReadOnly = true;
            // 
            // dgvThrottle
            // 
            this.dgvThrottle.HeaderText = "Throttle";
            this.dgvThrottle.Name = "dgvThrottle";
            this.dgvThrottle.ReadOnly = true;
            // 
            // dgvElevatorPitch
            // 
            this.dgvElevatorPitch.HeaderText = "Elevator Pitch";
            this.dgvElevatorPitch.Name = "dgvElevatorPitch";
            this.dgvElevatorPitch.ReadOnly = true;
            // 
            // dgvWarningCode
            // 
            this.dgvWarningCode.HeaderText = "WarningCode";
            this.dgvWarningCode.Name = "dgvWarningCode";
            this.dgvWarningCode.ReadOnly = true;
            // 
            // frmRemoteFlightController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 624);
            this.Controls.Add(this.grpWarnings);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.grpInitialSettings);
            this.Controls.Add(this.grpConnectionDetails);
            this.Controls.Add(this.grpTelemetryInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmRemoteFlightController";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoteFlightController";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCurrentThrottle.ResumeLayout(false);
            this.grpCurrentThrottle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkThrottle)).EndInit();
            this.grpConnectionDetails.ResumeLayout(false);
            this.grpConnectionDetails.PerformLayout();
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkElevatorPitch)).EndInit();
            this.grpCurrentElevatorPitch.ResumeLayout(false);
            this.grpCurrentElevatorPitch.PerformLayout();
            this.grpControls.ResumeLayout(false);
            this.grpOutgoingControlsDetails.ResumeLayout(false);
            this.grpOutgoingControlsDetails.PerformLayout();
            this.grpInitialSettings.ResumeLayout(false);
            this.grpInitialSettings.PerformLayout();
            this.grpWarnings.ResumeLayout(false);
            this.grpWarnings.PerformLayout();
            this.grpTelemetryInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelemetryInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label lblPortNumber;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMinThrottle;
        private System.Windows.Forms.Label lblMaxThrottle;
        private System.Windows.Forms.GroupBox grpConnectionDetails;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblElevatorPitch;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Button btnProcessData;
        private System.Windows.Forms.TextBox txtPitchAngle;
        private System.Windows.Forms.TextBox txtVerticalSpeed;
        private System.Windows.Forms.TextBox txtAltitude;
        private System.Windows.Forms.TextBox txtAirSpeed;
        private System.Windows.Forms.GroupBox grpCurrentElevatorPitch;
        private System.Windows.Forms.Label lblCurrentElevatorPitch;
        private System.Windows.Forms.GroupBox grpCurrentThrottle;
        private System.Windows.Forms.Label lblCurrentThrottle;
        private System.Windows.Forms.GroupBox grpInitialSettings;
        private System.Windows.Forms.Label lblAirSpeed;
        private System.Windows.Forms.Label lblPitchAngle;
        private System.Windows.Forms.Label lblVerticalSpeed;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.GroupBox grpWarnings;
        private System.Windows.Forms.Label lblCurrentWarningMessage;
        private System.Windows.Forms.TextBox txtThrottle;
        private System.Windows.Forms.TextBox txtElevatorPitch;
        private System.Windows.Forms.Label lblThrottle;
        private System.Windows.Forms.Label lblElevatorPitc;
        private System.Windows.Forms.GroupBox grpTelemetryInfo;
        private System.Windows.Forms.TrackBar trkElevatorPitch;
        private System.Windows.Forms.TrackBar trkThrottle;
        private System.Windows.Forms.DataGridView dgvTelemetryInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAltitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVerticalSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvThrottle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvElevatorPitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvWarningCode;
        private System.Windows.Forms.TextBox txtControlDetails;
        private System.Windows.Forms.Label lblCurrentConnection;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.GroupBox grpOutgoingControlsDetails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWarningMessage;
    }
}

