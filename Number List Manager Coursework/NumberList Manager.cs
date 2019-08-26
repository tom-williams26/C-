
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace Number_List_Manager_Coursework
{
    public partial class frmNumberLIstManager : Form
    {
        static int probes = 0;
        public frmNumberLIstManager()
        {
            InitializeComponent();
            lblEntryResult.Text = "N/A";
            lblFirstResult.Text = "N/A";
            lblMiddleResult.Text = "N/A";
            lblLastResult.Text = "N/A";
            lblMinResult.Text = "N/A";
            lblMaxResult.Text = "N/A";
            lblMaxEntriesAllowed.Text = "30";

            btnInitialise.Enabled = true;
            btnShuffle.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            btnInsert.Enabled = true;
            btnSearch.Enabled = false;

            optSort.Enabled = true;
            optUnsort.Enabled = true;
            optBinarySearch.Enabled = true;
            optLinearSearch.Enabled = true;

            lstNumberList.AllowDrop = false;
            picRecycleBin.AllowDrop = false;

            MaximizeBox = false;
        }
        private void Initialise_Click(object sender, EventArgs e)
        {
            const int count = 30 - 1;                             
                                                                  
            Random populate = new Random();                       
            lstNumberList.SelectedItems.Clear();
            for (int i = 0; i <= count; i++)                      
            {
                if (lstNumberList.Items.Count <= 30 - 1)                                                                            
                {
                    int number = populate.Next(0, 100);          
                                                                 
                    while (search(number) >= 0)                  
                        number = populate.Next(0, 100);
                    lstNumberList.Items.Add(number.ToString());   
                }
            }
            btnInitialise.Enabled = false;
            btnShuffle.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
            btnInsert.Enabled = false;
            btnSearch.Enabled = true;
            optSort.Enabled = true;
            optUnsort.Enabled = true;
            optBinarySearch.Enabled = true;
            optLinearSearch.Enabled = true;
            lstNumberList.AllowDrop = true;
            picRecycleBin.AllowDrop = true;

            UpdateStats();                                                 
        }
        private void Shuffle_Click(object sender, EventArgs e)
        {
            Random shuffleList = new Random();
            string temp;                                                            

            for (int i = 0; i < lstNumberList.Items.Count; i++)                    
            {
                int j = shuffleList.Next(0, lstNumberList.Items.Count - 1);         
                temp = lstNumberList.Items[i].ToString();                           
                lstNumberList.Items[i] = lstNumberList.Items[j];                   
                lstNumberList.Items[j] = temp;                                      
                UpdateStats();
                optUnsort.Checked = true;
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            lstNumberList.Items.Clear();                                   
            txtSearch.Text = "";                                          
            txtInsert.Text = "";                                            
            lblEntryResult.Text = "N/A";                                    
            lblFirstResult.Text = "N/A";
            lblMiddleResult.Text = "N/A";
            lblLastResult.Text = "N/A";

            if (lstNumberList.Items.Count == 0)                            
            {
                btnInsert.Enabled = true;                                   
                btnDelete.Enabled = false;                               
                btnClear.Enabled = false;                                  
                optUnsort.Checked = true;                                  
                btnSearch.Enabled = false;                                  
            }
            else                                                           
            {
                btnDelete.Enabled = true;
            }
            btnShuffle.Enabled = false;                                    
            btnInitialise.Enabled = true;                                  
            UpdateStats();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (lstNumberList.SelectedIndex == -1)                         
                MessageBox.Show("Must select a number before clicking the Delete button!",
                    "Error", MessageBoxButtons.OK);                        
            else if (lstNumberList.SelectedIndex != -1)                    
                deleteItem(lstNumberList.SelectedIndex);
         
            if (lstNumberList.Items.Count == 30)                          
            {
                btnInsert.Enabled = false;
            }
            else if (lstNumberList.Items.Count == 0)                   
            {
                btnDelete.Enabled = false;                               
                btnClear.Enabled = false;                                 
                optUnsort.Checked = true;                                  
                optLinearSearch.Checked = true;                             
                btnSearch.Enabled = false;
            }
            else if (lstNumberList.Items.Count < 2)                         
            {
                btnShuffle.Enabled = false;
                optUnsort.Checked = true;
            }
            else                                                           
            {
                btnInsert.Enabled = true;
            }

            if(lstNumberList.Items.Count < 30)
            {
                btnInitialise.Enabled = true;
            }
            UpdateStats();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            int numberAllowed = 0;                                        
            if (txtInsert.Text != "")                                     
            {
                if (!(search(int.Parse(txtInsert.Text)) >= 0))          
                {
                  
                    if (!(int.TryParse(txtInsert.Text, out numberAllowed) && numberAllowed < -1 || numberAllowed >= 101)) 
                                                                                                                          
                    {
                        lstNumberList.Items.Add(txtInsert.Text);          
                        txtInsert.Focus();                                
                        txtInsert.Clear();                               
                        BubbleSort();
                        if (lstNumberList.Items.Count >= 0 || lstNumberList.Items.Count <= 30) 
                        {
                            btnClear.Enabled = true;
                            btnDelete.Enabled = true;
                            btnSearch.Enabled = true;
                            lstNumberList.AllowDrop = true;
                            picRecycleBin.AllowDrop = true;
                            UpdateStats();
                        }
                        else
                        {
                            btnClear.Enabled = false;
                            btnInsert.Enabled = true;
                            btnDelete.Enabled = false;
                            lstNumberList.AllowDrop = false;
                            picRecycleBin.AllowDrop = false;
                        }
                        if (lstNumberList.Items.Count >= 2)             
                        {
                            btnShuffle.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number between 1 - 100",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtInsert.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("This already exists in the number list.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInsert.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number between 1 - 100",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (lstNumberList.Items.Count == 30) 
            {
                MessageBox.Show("You have exceeded the maxinmun entries.",
                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnInsert.Enabled = false;       
            }
            UpdateStats();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            int searchValue = 0;                                
            int indexPosition = -1;                           

            if (int.TryParse(txtSearch.Text, out searchValue))  
            {
                if (searchValue >= 0 && searchValue <= 100)     
                {
                    indexPosition = search(searchValue);
                    
                    if (indexPosition >= 0)                    
                    {
                        MessageBox.Show("Value: " + searchValue + " located at index: " + indexPosition + " after " + probes + " probes.",
                            "Message", MessageBoxButtons.OK);
                        txtSearch.Text = "";
                    }
                    else                                       
                    {
                        MessageBox.Show("Number not found!", "Error",
                            MessageBoxButtons.OK);
                        txtSearch.Text = "";                  
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a number between 1-100.", "Error", MessageBoxButtons.OK);
                    txtSearch.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Error inputting text", "Error", MessageBoxButtons.OK);
            }
            if(lstNumberList.Items.Count == 0)                 
            {
                btnSearch.Enabled = false;
            }
            else
            {
                btnSearch.Enabled = true;
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to close the program?",   
              "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)                                
            {
                Application.Exit();
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8 )   
            {
                e.Handled = false;                                       
            }
            else
            {
                MessageBox.Show("Please enter a valid number between 1 - 100",
                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;                                        
            }
        }
        private void txtInsert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Please enter a valid number between 1 - 100",
                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void lstNumberList_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox numberList = (ListBox)sender;
            numberList.Select();
            if (numberList.Items.Count > 0)         
            {
                try
                {
                    numberList.DoDragDrop(numberList.SelectedItem, DragDropEffects.Copy);
                }
                catch
                {
                    MessageBox.Show("Please select a number to delete!",
                        "Error", MessageBoxButtons.OK);
                }
            }
            else if (numberList.Items.Count < 30)  
            {
                btnInsert.Enabled = true;
            }

            UpdateStats();
        }
        private void RecycleBin_DragDrop(object sender, DragEventArgs e)
        {
            int removeItem = lstNumberList.SelectedItems.Count;    
            for (int i = 0; i < removeItem; i++)                   
            {
                deleteItem(lstNumberList.SelectedIndex); 
            }
            if (lstNumberList.Items.Count < 30)                        
            {
                btnInsert.Enabled = true;
                btnInitialise.Enabled = true;
            }
            if (lstNumberList.Items.Count == 0)                        
            {
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                optUnsort.Checked = true;
                optLinearSearch.Checked = true;
                btnSearch.Enabled = false;
            }
            if (lstNumberList.Items.Count < 2 )                        
            {
                btnShuffle.Enabled = false;
                optUnsort.Checked = true;
                optSort.Enabled = false;
            }
            UpdateStats();
        }
        private void RecycleBin_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.Move;
            }
            UpdateStats();
        }
        private void BubbleSort()
        {
            string temp;
            int value1 = 0;
            int value2 = 0;
            if (optSort.Checked == true)
            {
                for (int j = 0; j < lstNumberList.Items.Count - 1; j++)
                {
                    for (int k = 0; k < lstNumberList.Items.Count - 1; k++)
                    {
                        int.TryParse(lstNumberList.Items[k].ToString(), out value1);
                        int.TryParse(lstNumberList.Items[k + 1].ToString(), out value2);
                        if (value2 < value1)
                        {
                            temp = lstNumberList.Items[k].ToString();
                            lstNumberList.Items[k] = lstNumberList.Items[k + 1].ToString();
                            lstNumberList.Items[k + 1] = temp;
                        }
                    }
                   
                }
            }
        }
        private int linearSearch(int value)
        {
            int searchValue = 0;
            Boolean found = false;
            int indexPosition = 0;
            probes = 0;
            while (found == false && indexPosition < lstNumberList.Items.Count)
            {
                probes++;
                int.TryParse(lstNumberList.Items[indexPosition].ToString(), out searchValue);
                if (value == searchValue)
                {
                    found = true;
                }
                else
                {
                    indexPosition++;
                }
            }
            if (found == true)
                return indexPosition;
            else
                return -1;
        }
        private int binarySearch(int value)
        {
            int first = 0; 
            int last = lstNumberList.Items.Count - 1;  
            int mid = 0;   
            Boolean found = false;
            int searchValue = 0;
            probes = 0;

            while (found == false && first <= last)
            {
                probes++;
                mid = (first + last) / 2;
                int.TryParse(lstNumberList.Items[mid].ToString(), out searchValue);

                if (value == searchValue)
                {
                    found = true;    
                }
                else if (value < searchValue)
                {
                    last = mid - 1;    
                }
                else
                {
                    first = mid + 1;
                }
            }
            if (found == true)
                return mid;
            else
                return -1;
        }
        private int search(int searchValue)
        {
            int indexPosition;
            if (optLinearSearch.Checked == true)
            {
                indexPosition = linearSearch(searchValue);
            }
            else
            {
                indexPosition = binarySearch(searchValue);
            }
            return indexPosition;
        }
        private void deleteItem(int index)
        {
            for (int i = index; i < lstNumberList.Items.Count - 2; i++)
            {
                lstNumberList.Items[index] = lstNumberList.Items[index + 1];
            }
            lstNumberList.Items.RemoveAt(index);
        }
        private void OptSort_CheckedChanged(object sender, EventArgs e)
        {
            BubbleSort();
            UpdateStats();
        }
        private void OptUnsort_CheckedChanged(object sender, EventArgs e)
        {
            if (optUnsort.Checked == true)
            {
                optLinearSearch.Checked = true;
            }
        }
        private void BinarySearch_CheckedChanged(object sender, EventArgs e)
        {
            if (optBinarySearch.Checked == true)
            {
                optSort.Checked = true;
            }
            else
            {
                optLinearSearch.Checked = true;
            }
        }
        private void UpdateStats()
        {
            int firstValue = 0;
            int lastValue = lstNumberList.Items.Count - 1;
            int largestValue = 0;
            int smallestValue = 101;

            if (lstNumberList.Items.Count > 0)
            {
                for (int i = 0; i < lstNumberList.Items.Count; i++)
                {
                    if (int.Parse(lstNumberList.Items[i].ToString()) < smallestValue)
                    {
                        smallestValue = int.Parse(lstNumberList.Items[i].ToString());
                    }
                }
                for (int i = 0; i < lstNumberList.Items.Count; i++)
                {
                    if (int.Parse(lstNumberList.Items[i].ToString()) > largestValue)
                    {
                        largestValue = int.Parse(lstNumberList.Items[i].ToString());
                    }
                }
            }
            if (lstNumberList.Items.Count == 0)
            {
                lblEntryResult.Text = "N/A";

                lblFirstResult.Text = "N/A";
                lblMiddleResult.Text = "N/A";
                lblLastResult.Text = "N/A";

                lblMinResult.Text = "N/A";
                lblMaxResult.Text = "N/A";
            }
            else if (lstNumberList.Items.Count == 1)
            {
                lblEntryResult.Text = lstNumberList.Items.Count.ToString();

                lblFirstResult.Text = lstNumberList.Items[firstValue].ToString();
                lblMiddleResult.Text = "N/A";
                lblLastResult.Text = "N/A";

                lblMaxResult.Text = "N/A";
                lblMinResult.Text = smallestValue.ToString();
            }
            else if (lstNumberList.Items.Count == 2)
            {
                lblEntryResult.Text = lstNumberList.Items.Count.ToString();

                lblFirstResult.Text = lstNumberList.Items[firstValue].ToString();
                lblMiddleResult.Text = "N/A";
                lblLastResult.Text = lstNumberList.Items[lastValue].ToString();

                lblMaxResult.Text = largestValue.ToString();
                lblMinResult.Text = smallestValue.ToString();
            }
            else
            {
                lblEntryResult.Text = lstNumberList.Items.Count.ToString();
                lblFirstResult.Text = lstNumberList.Items[firstValue].ToString();
                lblMiddleResult.Text = lstNumberList.Items[firstValue + lastValue / 2].ToString();
                lblLastResult.Text = lstNumberList.Items[lastValue].ToString();
                
                lblMaxResult.Text = largestValue.ToString();
                lblMinResult.Text = smallestValue.ToString();
            }
        }
    }
}