namespace StalkerUI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.processListBox = new System.Windows.Forms.ListBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnAddBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.txtNewAppPath = new System.Windows.Forms.TextBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.gbxAppControls = new System.Windows.Forms.GroupBox();
            this.btnSessions = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblAppGuid = new System.Windows.Forms.Label();
            this.lblExecPath = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.sessionGridView = new System.Windows.Forms.DataGridView();
            this.sessionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxAdd.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.gbxAppControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // processListBox
            // 
            this.processListBox.FormattingEnabled = true;
            this.processListBox.ItemHeight = 15;
            this.processListBox.Location = new System.Drawing.Point(12, 12);
            this.processListBox.Name = "processListBox";
            this.processListBox.Size = new System.Drawing.Size(273, 334);
            this.processListBox.TabIndex = 0;
            this.processListBox.SelectedIndexChanged += new System.EventHandler(this.processListBox_SelectedIndexChanged);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxAdd.Controls.Add(this.btnAddNew);
            this.gbxAdd.Controls.Add(this.btnAddBrowse);
            this.gbxAdd.Controls.Add(this.label2);
            this.gbxAdd.Controls.Add(this.label1);
            this.gbxAdd.Controls.Add(this.txtNewName);
            this.gbxAdd.Controls.Add(this.txtNewAppPath);
            this.gbxAdd.Location = new System.Drawing.Point(0, 146);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(852, 188);
            this.gbxAdd.TabIndex = 1;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add Application";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.Location = new System.Drawing.Point(6, 135);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(839, 35);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Add Application";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnAddBrowse
            // 
            this.btnAddBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBrowse.Location = new System.Drawing.Point(658, 47);
            this.btnAddBrowse.Name = "btnAddBrowse";
            this.btnAddBrowse.Size = new System.Drawing.Size(187, 23);
            this.btnAddBrowse.TabIndex = 2;
            this.btnAddBrowse.Text = "Browse";
            this.btnAddBrowse.UseVisualStyleBackColor = true;
            this.btnAddBrowse.Click += new System.EventHandler(this.btnAddBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Application Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Executable path";
            // 
            // txtNewName
            // 
            this.txtNewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewName.Location = new System.Drawing.Point(6, 97);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(839, 23);
            this.txtNewName.TabIndex = 0;
            // 
            // txtNewAppPath
            // 
            this.txtNewAppPath.Location = new System.Drawing.Point(6, 47);
            this.txtNewAppPath.Name = "txtNewAppPath";
            this.txtNewAppPath.Size = new System.Drawing.Size(646, 23);
            this.txtNewAppPath.TabIndex = 0;
            // 
            // pnlControls
            // 
            this.pnlControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControls.Controls.Add(this.gbxAppControls);
            this.pnlControls.Controls.Add(this.gbxAdd);
            this.pnlControls.Location = new System.Drawing.Point(291, 12);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(852, 334);
            this.pnlControls.TabIndex = 2;
            // 
            // gbxAppControls
            // 
            this.gbxAppControls.Controls.Add(this.btnSessions);
            this.gbxAppControls.Controls.Add(this.btnRemove);
            this.gbxAppControls.Controls.Add(this.lblAppGuid);
            this.gbxAppControls.Controls.Add(this.lblExecPath);
            this.gbxAppControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxAppControls.Location = new System.Drawing.Point(0, 0);
            this.gbxAppControls.Name = "gbxAppControls";
            this.gbxAppControls.Size = new System.Drawing.Size(852, 117);
            this.gbxAppControls.TabIndex = 2;
            this.gbxAppControls.TabStop = false;
            this.gbxAppControls.Text = "Selected Application - None";
            // 
            // btnSessions
            // 
            this.btnSessions.Location = new System.Drawing.Point(432, 22);
            this.btnSessions.Name = "btnSessions";
            this.btnSessions.Size = new System.Drawing.Size(413, 30);
            this.btnSessions.TabIndex = 2;
            this.btnSessions.Text = "View Sessions";
            this.btnSessions.UseVisualStyleBackColor = true;
            this.btnSessions.Click += new System.EventHandler(this.btnSessions_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(15, 22);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(411, 30);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblAppGuid
            // 
            this.lblAppGuid.AutoSize = true;
            this.lblAppGuid.Location = new System.Drawing.Point(15, 63);
            this.lblAppGuid.Name = "lblAppGuid";
            this.lblAppGuid.Size = new System.Drawing.Size(37, 15);
            this.lblAppGuid.TabIndex = 1;
            this.lblAppGuid.Text = "GUID:";
            // 
            // lblExecPath
            // 
            this.lblExecPath.AutoSize = true;
            this.lblExecPath.Location = new System.Drawing.Point(15, 86);
            this.lblExecPath.Name = "lblExecPath";
            this.lblExecPath.Size = new System.Drawing.Size(97, 15);
            this.lblExecPath.TabIndex = 1;
            this.lblExecPath.Text = "Executable path: ";
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSession.Location = new System.Drawing.Point(12, 362);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(162, 21);
            this.lblSession.TabIndex = 1;
            this.lblSession.Text = "Application - Sessions";
            // 
            // sessionGridView
            // 
            this.sessionGridView.AllowUserToDeleteRows = false;
            this.sessionGridView.AllowUserToOrderColumns = true;
            this.sessionGridView.AllowUserToResizeColumns = false;
            this.sessionGridView.AllowUserToResizeRows = false;
            this.sessionGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sessionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sessionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessionDate,
            this.startTime,
            this.exitTime});
            this.sessionGridView.Location = new System.Drawing.Point(12, 386);
            this.sessionGridView.Name = "sessionGridView";
            this.sessionGridView.ReadOnly = true;
            this.sessionGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sessionGridView.RowHeadersVisible = false;
            this.sessionGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.sessionGridView.RowTemplate.Height = 25;
            this.sessionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.sessionGridView.Size = new System.Drawing.Size(1124, 483);
            this.sessionGridView.TabIndex = 3;
            // 
            // sessionDate
            // 
            this.sessionDate.HeaderText = "Session Date";
            this.sessionDate.Name = "sessionDate";
            this.sessionDate.ReadOnly = true;
            // 
            // startTime
            // 
            this.startTime.HeaderText = "Start Time";
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            // 
            // exitTime
            // 
            this.exitTime.HeaderText = "Exit Time";
            this.exitTime.Name = "exitTime";
            this.exitTime.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 881);
            this.Controls.Add(this.sessionGridView);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.processListBox);
            this.Controls.Add(this.lblSession);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stalker";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.gbxAppControls.ResumeLayout(false);
            this.gbxAppControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox processListBox;
        private GroupBox gbxAdd;
        private Label label1;
        private TextBox txtNewAppPath;
        private Panel pnlControls;
        private Button btnAddNew;
        private Button btnAddBrowse;
        private Label label2;
        private TextBox txtNewName;
        private GroupBox gbxAppControls;
        private Button btnSessions;
        private Button btnRemove;
        private Label lblAppGuid;
        private Label lblExecPath;
        private Label lblSession;
        private DataGridView sessionGridView;
        private DataGridViewTextBoxColumn sessionDate;
        private DataGridViewTextBoxColumn startTime;
        private DataGridViewTextBoxColumn exitTime;
    }
}