namespace Number_List_Manager_Coursework
{
    partial class frmNumberLIstManager
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
            this.lstNumberList = new System.Windows.Forms.ListBox();
            this.optSort = new System.Windows.Forms.RadioButton();
            this.optUnsort = new System.Windows.Forms.RadioButton();
            this.optLinearSearch = new System.Windows.Forms.RadioButton();
            this.optBinarySearch = new System.Windows.Forms.RadioButton();
            this.btnInitialise = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.lblMaxEntries = new System.Windows.Forms.Label();
            this.lblEntries = new System.Windows.Forms.Label();
            this.lblFirstValue = new System.Windows.Forms.Label();
            this.lblLastValue = new System.Windows.Forms.Label();
            this.lblMiddleValue = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpSorting = new System.Windows.Forms.GroupBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SearchStatus = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.grpNumberListManagerInfo = new System.Windows.Forms.GroupBox();
            this.lblMaxResult = new System.Windows.Forms.Label();
            this.lblMinResult = new System.Windows.Forms.Label();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.lblMinValue = new System.Windows.Forms.Label();
            this.lblMaxEntriesAllowed = new System.Windows.Forms.Label();
            this.lblLastResult = new System.Windows.Forms.Label();
            this.lblMiddleResult = new System.Windows.Forms.Label();
            this.lblFirstResult = new System.Windows.Forms.Label();
            this.lblEntryResult = new System.Windows.Forms.Label();
            this.picRecycleBin = new System.Windows.Forms.PictureBox();
            this.grpSorting.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpNumberListManagerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRecycleBin)).BeginInit();
            this.SuspendLayout();
            // 
            // lstNumberList
            // 
            this.lstNumberList.FormattingEnabled = true;
            this.lstNumberList.Location = new System.Drawing.Point(299, 12);
            this.lstNumberList.Name = "lstNumberList";
            this.lstNumberList.Size = new System.Drawing.Size(126, 407);
            this.lstNumberList.TabIndex = 0;
            this.lstNumberList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstNumberList_MouseDown);
            // 
            // optSort
            // 
            this.optSort.AutoSize = true;
            this.optSort.Location = new System.Drawing.Point(5, 18);
            this.optSort.Name = "optSort";
            this.optSort.Size = new System.Drawing.Size(44, 17);
            this.optSort.TabIndex = 1;
            this.optSort.TabStop = true;
            this.optSort.Text = "Sort";
            this.optSort.UseVisualStyleBackColor = true;
            this.optSort.CheckedChanged += new System.EventHandler(this.OptSort_CheckedChanged);
            // 
            // optUnsort
            // 
            this.optUnsort.AutoSize = true;
            this.optUnsort.Checked = true;
            this.optUnsort.Location = new System.Drawing.Point(5, 39);
            this.optUnsort.Name = "optUnsort";
            this.optUnsort.Size = new System.Drawing.Size(56, 17);
            this.optUnsort.TabIndex = 2;
            this.optUnsort.TabStop = true;
            this.optUnsort.Text = "Unsort";
            this.optUnsort.UseVisualStyleBackColor = true;
            this.optUnsort.CheckedChanged += new System.EventHandler(this.OptUnsort_CheckedChanged);
            // 
            // optLinearSearch
            // 
            this.optLinearSearch.AutoSize = true;
            this.optLinearSearch.Checked = true;
            this.optLinearSearch.Location = new System.Drawing.Point(9, 41);
            this.optLinearSearch.Name = "optLinearSearch";
            this.optLinearSearch.Size = new System.Drawing.Size(91, 17);
            this.optLinearSearch.TabIndex = 3;
            this.optLinearSearch.TabStop = true;
            this.optLinearSearch.Text = "Linear Search";
            this.optLinearSearch.UseVisualStyleBackColor = true;
            this.optLinearSearch.CheckedChanged += new System.EventHandler(this.BinarySearch_CheckedChanged);
            // 
            // optBinarySearch
            // 
            this.optBinarySearch.AutoSize = true;
            this.optBinarySearch.Location = new System.Drawing.Point(9, 18);
            this.optBinarySearch.Name = "optBinarySearch";
            this.optBinarySearch.Size = new System.Drawing.Size(91, 17);
            this.optBinarySearch.TabIndex = 4;
            this.optBinarySearch.TabStop = true;
            this.optBinarySearch.Text = "Binary Search";
            this.optBinarySearch.UseVisualStyleBackColor = true;
            // 
            // btnInitialise
            // 
            this.btnInitialise.Location = new System.Drawing.Point(195, 12);
            this.btnInitialise.Name = "btnInitialise";
            this.btnInitialise.Size = new System.Drawing.Size(98, 24);
            this.btnInitialise.TabIndex = 5;
            this.btnInitialise.Text = "Initialise";
            this.btnInitialise.UseVisualStyleBackColor = true;
            this.btnInitialise.Click += new System.EventHandler(this.Initialise_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(195, 256);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 24);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(195, 43);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(98, 24);
            this.btnShuffle.TabIndex = 7;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.Shuffle_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(195, 226);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 24);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(11, 176);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 26);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(195, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 24);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(195, 73);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(98, 20);
            this.txtInsert.TabIndex = 13;
            this.txtInsert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsert_KeyPress);
            // 
            // lblMaxEntries
            // 
            this.lblMaxEntries.AutoSize = true;
            this.lblMaxEntries.Location = new System.Drawing.Point(5, 27);
            this.lblMaxEntries.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxEntries.Name = "lblMaxEntries";
            this.lblMaxEntries.Size = new System.Drawing.Size(125, 13);
            this.lblMaxEntries.TabIndex = 16;
            this.lblMaxEntries.Text = "Maximun entries allowed:";
            // 
            // lblEntries
            // 
            this.lblEntries.AutoSize = true;
            this.lblEntries.Location = new System.Drawing.Point(5, 49);
            this.lblEntries.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntries.Name = "lblEntries";
            this.lblEntries.Size = new System.Drawing.Size(82, 13);
            this.lblEntries.TabIndex = 17;
            this.lblEntries.Text = "Current Entries: ";
            // 
            // lblFirstValue
            // 
            this.lblFirstValue.AutoSize = true;
            this.lblFirstValue.Location = new System.Drawing.Point(5, 88);
            this.lblFirstValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstValue.Name = "lblFirstValue";
            this.lblFirstValue.Size = new System.Drawing.Size(105, 13);
            this.lblFirstValue.TabIndex = 18;
            this.lblFirstValue.Text = "First value in the list: ";
            // 
            // lblLastValue
            // 
            this.lblLastValue.AutoSize = true;
            this.lblLastValue.Location = new System.Drawing.Point(5, 137);
            this.lblLastValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastValue.Name = "lblLastValue";
            this.lblLastValue.Size = new System.Drawing.Size(103, 13);
            this.lblLastValue.TabIndex = 19;
            this.lblLastValue.Text = "Last value in the list:";
            // 
            // lblMiddleValue
            // 
            this.lblMiddleValue.AutoSize = true;
            this.lblMiddleValue.Location = new System.Drawing.Point(5, 113);
            this.lblMiddleValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMiddleValue.Name = "lblMiddleValue";
            this.lblMiddleValue.Size = new System.Drawing.Size(114, 13);
            this.lblMiddleValue.TabIndex = 20;
            this.lblMiddleValue.Text = "Middle value in the list:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(11, 151);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(98, 20);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // grpSorting
            // 
            this.grpSorting.Controls.Add(this.optUnsort);
            this.grpSorting.Controls.Add(this.optSort);
            this.grpSorting.Location = new System.Drawing.Point(11, 11);
            this.grpSorting.Margin = new System.Windows.Forms.Padding(2);
            this.grpSorting.Name = "grpSorting";
            this.grpSorting.Padding = new System.Windows.Forms.Padding(2);
            this.grpSorting.Size = new System.Drawing.Size(111, 62);
            this.grpSorting.TabIndex = 23;
            this.grpSorting.TabStop = false;
            this.grpSorting.Text = "Sorting";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.optBinarySearch);
            this.grpSearch.Controls.Add(this.optLinearSearch);
            this.grpSearch.Location = new System.Drawing.Point(11, 79);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(2);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(2);
            this.grpSearch.Size = new System.Drawing.Size(111, 68);
            this.grpSearch.TabIndex = 24;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(195, 99);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(98, 26);
            this.btnInsert.TabIndex = 25;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // SearchStatus
            // 
            this.SearchStatus.AutoSize = true;
            this.SearchStatus.Location = new System.Drawing.Point(88, 205);
            this.SearchStatus.Name = "SearchStatus";
            this.SearchStatus.Size = new System.Drawing.Size(0, 13);
            this.SearchStatus.TabIndex = 26;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(99, 85);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 27;
            // 
            // grpNumberListManagerInfo
            // 
            this.grpNumberListManagerInfo.Controls.Add(this.lblMaxResult);
            this.grpNumberListManagerInfo.Controls.Add(this.lblMinResult);
            this.grpNumberListManagerInfo.Controls.Add(this.lblMaxValue);
            this.grpNumberListManagerInfo.Controls.Add(this.lblMinValue);
            this.grpNumberListManagerInfo.Controls.Add(this.lblMaxEntriesAllowed);
            this.grpNumberListManagerInfo.Controls.Add(this.lblMaxEntries);
            this.grpNumberListManagerInfo.Controls.Add(this.lblLastResult);
            this.grpNumberListManagerInfo.Controls.Add(this.lblEntries);
            this.grpNumberListManagerInfo.Controls.Add(this.lblMiddleResult);
            this.grpNumberListManagerInfo.Controls.Add(this.lblFirstValue);
            this.grpNumberListManagerInfo.Controls.Add(this.lblFirstResult);
            this.grpNumberListManagerInfo.Controls.Add(this.lblMiddleValue);
            this.grpNumberListManagerInfo.Controls.Add(this.lblEntryResult);
            this.grpNumberListManagerInfo.Controls.Add(this.lblLastValue);
            this.grpNumberListManagerInfo.Location = new System.Drawing.Point(10, 210);
            this.grpNumberListManagerInfo.Name = "grpNumberListManagerInfo";
            this.grpNumberListManagerInfo.Size = new System.Drawing.Size(173, 208);
            this.grpNumberListManagerInfo.TabIndex = 28;
            this.grpNumberListManagerInfo.TabStop = false;
            this.grpNumberListManagerInfo.Text = "Statistics";
            // 
            // lblMaxResult
            // 
            this.lblMaxResult.AutoSize = true;
            this.lblMaxResult.Location = new System.Drawing.Point(139, 183);
            this.lblMaxResult.Name = "lblMaxResult";
            this.lblMaxResult.Size = new System.Drawing.Size(0, 13);
            this.lblMaxResult.TabIndex = 38;
            // 
            // lblMinResult
            // 
            this.lblMinResult.AutoSize = true;
            this.lblMinResult.Location = new System.Drawing.Point(139, 161);
            this.lblMinResult.Name = "lblMinResult";
            this.lblMinResult.Size = new System.Drawing.Size(0, 13);
            this.lblMinResult.TabIndex = 37;
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Location = new System.Drawing.Point(5, 183);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(82, 13);
            this.lblMaxValue.TabIndex = 36;
            this.lblMaxValue.Text = "Maximun Value:";
            // 
            // lblMinValue
            // 
            this.lblMinValue.AutoSize = true;
            this.lblMinValue.Location = new System.Drawing.Point(5, 161);
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(78, 13);
            this.lblMinValue.TabIndex = 35;
            this.lblMinValue.Text = "Minimun value:";
            // 
            // lblMaxEntriesAllowed
            // 
            this.lblMaxEntriesAllowed.AutoSize = true;
            this.lblMaxEntriesAllowed.Location = new System.Drawing.Point(139, 27);
            this.lblMaxEntriesAllowed.Name = "lblMaxEntriesAllowed";
            this.lblMaxEntriesAllowed.Size = new System.Drawing.Size(0, 13);
            this.lblMaxEntriesAllowed.TabIndex = 34;
            // 
            // lblLastResult
            // 
            this.lblLastResult.AutoSize = true;
            this.lblLastResult.Location = new System.Drawing.Point(139, 137);
            this.lblLastResult.Name = "lblLastResult";
            this.lblLastResult.Size = new System.Drawing.Size(0, 13);
            this.lblLastResult.TabIndex = 33;
            // 
            // lblMiddleResult
            // 
            this.lblMiddleResult.AutoSize = true;
            this.lblMiddleResult.Location = new System.Drawing.Point(139, 113);
            this.lblMiddleResult.Name = "lblMiddleResult";
            this.lblMiddleResult.Size = new System.Drawing.Size(0, 13);
            this.lblMiddleResult.TabIndex = 32;
            // 
            // lblFirstResult
            // 
            this.lblFirstResult.AutoSize = true;
            this.lblFirstResult.Location = new System.Drawing.Point(139, 88);
            this.lblFirstResult.Name = "lblFirstResult";
            this.lblFirstResult.Size = new System.Drawing.Size(0, 13);
            this.lblFirstResult.TabIndex = 31;
            // 
            // lblEntryResult
            // 
            this.lblEntryResult.AutoSize = true;
            this.lblEntryResult.Location = new System.Drawing.Point(139, 49);
            this.lblEntryResult.Name = "lblEntryResult";
            this.lblEntryResult.Size = new System.Drawing.Size(0, 13);
            this.lblEntryResult.TabIndex = 29;
            // 
            // picRecycleBin
            // 
            this.picRecycleBin.Image = global::Number_List_Manager_Coursework.Properties.Resources.recycling_bin;
            this.picRecycleBin.Location = new System.Drawing.Point(195, 131);
            this.picRecycleBin.Name = "picRecycleBin";
            this.picRecycleBin.Size = new System.Drawing.Size(98, 89);
            this.picRecycleBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRecycleBin.TabIndex = 9;
            this.picRecycleBin.TabStop = false;
            this.picRecycleBin.DragDrop += new System.Windows.Forms.DragEventHandler(this.RecycleBin_DragDrop);
            this.picRecycleBin.DragEnter += new System.Windows.Forms.DragEventHandler(this.RecycleBin_DragEnter);
            // 
            // frmNumberLIstManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 430);
            this.Controls.Add(this.grpNumberListManagerInfo);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.SearchStatus);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpSorting);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.picRecycleBin);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInitialise);
            this.Controls.Add(this.lstNumberList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNumberLIstManager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number List Manager";
            this.grpSorting.ResumeLayout(false);
            this.grpSorting.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpNumberListManagerInfo.ResumeLayout(false);
            this.grpNumberListManagerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRecycleBin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumberList;
        private System.Windows.Forms.RadioButton optSort;
        private System.Windows.Forms.RadioButton optUnsort;
        private System.Windows.Forms.RadioButton optLinearSearch;
        private System.Windows.Forms.RadioButton optBinarySearch;
        private System.Windows.Forms.Button btnInitialise;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox picRecycleBin;
        
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Label lblMaxEntries;
        private System.Windows.Forms.Label lblEntries;
        private System.Windows.Forms.Label lblFirstValue;
        private System.Windows.Forms.Label lblLastValue;
        private System.Windows.Forms.Label lblMiddleValue;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grpSorting;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label SearchStatus;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.GroupBox grpNumberListManagerInfo;
        private System.Windows.Forms.Label lblLastResult;
        private System.Windows.Forms.Label lblMiddleResult;
        private System.Windows.Forms.Label lblFirstResult;
        private System.Windows.Forms.Label lblEntryResult;
        private System.Windows.Forms.Label lblMaxEntriesAllowed;
        private System.Windows.Forms.Label lblMaxResult;
        private System.Windows.Forms.Label lblMinResult;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.Label lblMinValue;
    }
}

