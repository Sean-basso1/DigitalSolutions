namespace DigitalSolutions___Prototype1___SB
{
    partial class mainScreenFormAdmin
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
            this.createProjectButton = new System.Windows.Forms.Button();
            this.editProjectButton = new System.Windows.Forms.Button();
            this.archiveProjectButton = new System.Windows.Forms.Button();
            this.enterHoursButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.employeeListingButton = new System.Windows.Forms.Button();
            this.mainScreenListView = new System.Windows.Forms.ListView();
            this.columnHeaderProjectCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderShortDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // createProjectButton
            // 
            this.createProjectButton.Location = new System.Drawing.Point(12, 12);
            this.createProjectButton.Name = "createProjectButton";
            this.createProjectButton.Size = new System.Drawing.Size(94, 26);
            this.createProjectButton.TabIndex = 0;
            this.createProjectButton.Text = "Create Project";
            this.createProjectButton.UseVisualStyleBackColor = true;
            this.createProjectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // editProjectButton
            // 
            this.editProjectButton.Location = new System.Drawing.Point(12, 44);
            this.editProjectButton.Name = "editProjectButton";
            this.editProjectButton.Size = new System.Drawing.Size(94, 23);
            this.editProjectButton.TabIndex = 1;
            this.editProjectButton.Text = "Edit Project";
            this.editProjectButton.UseVisualStyleBackColor = true;
            // 
            // archiveProjectButton
            // 
            this.archiveProjectButton.Location = new System.Drawing.Point(12, 73);
            this.archiveProjectButton.Name = "archiveProjectButton";
            this.archiveProjectButton.Size = new System.Drawing.Size(94, 23);
            this.archiveProjectButton.TabIndex = 2;
            this.archiveProjectButton.Text = "Archive Project";
            this.archiveProjectButton.UseVisualStyleBackColor = true;
            // 
            // enterHoursButton
            // 
            this.enterHoursButton.Location = new System.Drawing.Point(12, 131);
            this.enterHoursButton.Name = "enterHoursButton";
            this.enterHoursButton.Size = new System.Drawing.Size(94, 23);
            this.enterHoursButton.TabIndex = 3;
            this.enterHoursButton.Text = "Enter Hours";
            this.enterHoursButton.UseVisualStyleBackColor = true;
            this.enterHoursButton.Click += new System.EventHandler(this.enterHoursButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(12, 160);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(94, 23);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // employeeListingButton
            // 
            this.employeeListingButton.Location = new System.Drawing.Point(12, 102);
            this.employeeListingButton.Name = "employeeListingButton";
            this.employeeListingButton.Size = new System.Drawing.Size(94, 23);
            this.employeeListingButton.TabIndex = 6;
            this.employeeListingButton.Text = "Employee Listing";
            this.employeeListingButton.UseVisualStyleBackColor = true;
            this.employeeListingButton.Click += new System.EventHandler(this.employeeListingButton_Click);
            // 
            // mainScreenListView
            // 
            this.mainScreenListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProjectCode,
            this.columnHeaderProjectName,
            this.columnHeaderClientName,
            this.columnHeaderShortDesc,
            this.columnHeaderStartDate});
            this.mainScreenListView.Location = new System.Drawing.Point(126, 12);
            this.mainScreenListView.Name = "mainScreenListView";
            this.mainScreenListView.Size = new System.Drawing.Size(523, 423);
            this.mainScreenListView.TabIndex = 7;
            this.mainScreenListView.UseCompatibleStateImageBehavior = false;
            this.mainScreenListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderProjectCode
            // 
            this.columnHeaderProjectCode.Text = "Project Code";
            this.columnHeaderProjectCode.Width = 79;
            // 
            // columnHeaderProjectName
            // 
            this.columnHeaderProjectName.Text = "Project Name";
            this.columnHeaderProjectName.Width = 137;
            // 
            // columnHeaderClientName
            // 
            this.columnHeaderClientName.Text = "Client Name";
            this.columnHeaderClientName.Width = 105;
            // 
            // columnHeaderShortDesc
            // 
            this.columnHeaderShortDesc.Text = "Short Description";
            this.columnHeaderShortDesc.Width = 100;
            // 
            // columnHeaderStartDate
            // 
            this.columnHeaderStartDate.Text = "Start Date";
            this.columnHeaderStartDate.Width = 95;
            // 
            // mainScreenFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 447);
            this.Controls.Add(this.mainScreenListView);
            this.Controls.Add(this.employeeListingButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.enterHoursButton);
            this.Controls.Add(this.archiveProjectButton);
            this.Controls.Add(this.editProjectButton);
            this.Controls.Add(this.createProjectButton);
            this.Name = "mainScreenFormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Solutions - Main Screen";
            this.Load += new System.EventHandler(this.mainScreenFormAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createProjectButton;
        private System.Windows.Forms.Button editProjectButton;
        private System.Windows.Forms.Button archiveProjectButton;
        private System.Windows.Forms.Button enterHoursButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button employeeListingButton;
        private System.Windows.Forms.ListView mainScreenListView;
        private System.Windows.Forms.ColumnHeader columnHeaderProjectCode;
        private System.Windows.Forms.ColumnHeader columnHeaderProjectName;
        private System.Windows.Forms.ColumnHeader columnHeaderClientName;
        private System.Windows.Forms.ColumnHeader columnHeaderShortDesc;
        private System.Windows.Forms.ColumnHeader columnHeaderStartDate;
    }
}