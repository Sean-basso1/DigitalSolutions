namespace DigitalSolutions___Prototype1___SB
{
    partial class mainScreenFormEmployee
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
            this.button3 = new System.Windows.Forms.Button();
            this.enterHoursButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.mainScreenTextBox = new System.Windows.Forms.TextBox();
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Archive Project";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // enterHoursButton
            // 
            this.enterHoursButton.Location = new System.Drawing.Point(12, 102);
            this.enterHoursButton.Name = "enterHoursButton";
            this.enterHoursButton.Size = new System.Drawing.Size(94, 23);
            this.enterHoursButton.TabIndex = 3;
            this.enterHoursButton.Text = "Enter Hours";
            this.enterHoursButton.UseVisualStyleBackColor = true;
            this.enterHoursButton.Click += new System.EventHandler(this.enterHoursButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(12, 131);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(94, 23);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // mainScreenTextBox
            // 
            this.mainScreenTextBox.Location = new System.Drawing.Point(112, 12);
            this.mainScreenTextBox.Multiline = true;
            this.mainScreenTextBox.Name = "mainScreenTextBox";
            this.mainScreenTextBox.Size = new System.Drawing.Size(307, 400);
            this.mainScreenTextBox.TabIndex = 5;
            // 
            // mainScreenFormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 424);
            this.Controls.Add(this.mainScreenTextBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.enterHoursButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.editProjectButton);
            this.Controls.Add(this.createProjectButton);
            this.Name = "mainScreenFormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Solutions - Main Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createProjectButton;
        private System.Windows.Forms.Button editProjectButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button enterHoursButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TextBox mainScreenTextBox;
    }
}