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
            this.components = new System.ComponentModel.Container();
            this.createProjectButton = new System.Windows.Forms.Button();
            this.editProjectButton = new System.Windows.Forms.Button();
            this.archiveProjectButton = new System.Windows.Forms.Button();
            this.enterHoursButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.employeeListingButton = new System.Windows.Forms.Button();
            this.software_eng_db_1DataSet = new DigitalSolutions___Prototype1___SB.software_eng_db_1DataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new DigitalSolutions___Prototype1___SB.software_eng_db_1DataSetTableAdapters.clientTableAdapter();
            this.tableAdapterManager = new DigitalSolutions___Prototype1___SB.software_eng_db_1DataSetTableAdapters.TableAdapterManager();
            this.projectTableAdapter = new DigitalSolutions___Prototype1___SB.software_eng_db_1DataSetTableAdapters.projectTableAdapter();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.software_eng_db_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
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
            // software_eng_db_1DataSet
            // 
            this.software_eng_db_1DataSet.DataSetName = "software_eng_db_1DataSet";
            this.software_eng_db_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.software_eng_db_1DataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.projectTableAdapter = this.projectTableAdapter;
            this.tableAdapterManager.UpdateOrder = DigitalSolutions___Prototype1___SB.software_eng_db_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "project";
            this.projectBindingSource.DataSource = this.software_eng_db_1DataSet;
            // 
            // projectBindingSource1
            // 
            this.projectBindingSource1.DataMember = "project";
            this.projectBindingSource1.DataSource = this.software_eng_db_1DataSet;
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "client";
            this.clientBindingSource1.DataSource = this.software_eng_db_1DataSet;
            // 
            // mainScreenFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 421);
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
            ((System.ComponentModel.ISupportInitialize)(this.software_eng_db_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createProjectButton;
        private System.Windows.Forms.Button editProjectButton;
        private System.Windows.Forms.Button archiveProjectButton;
        private System.Windows.Forms.Button enterHoursButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button employeeListingButton;
        private software_eng_db_1DataSet software_eng_db_1DataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private software_eng_db_1DataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private software_eng_db_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private software_eng_db_1DataSetTableAdapters.projectTableAdapter projectTableAdapter;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.BindingSource projectBindingSource1;
        private System.Windows.Forms.BindingSource clientBindingSource1;
    }
}