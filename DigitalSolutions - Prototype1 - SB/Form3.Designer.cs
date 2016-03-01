namespace DigitalSolutions___Prototype1___SB
{
    partial class enterHoursForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.submitHoursButton = new System.Windows.Forms.Button();
            this.enterHoursTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 277);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // submitHoursButton
            // 
            this.submitHoursButton.Location = new System.Drawing.Point(152, 277);
            this.submitHoursButton.Name = "submitHoursButton";
            this.submitHoursButton.Size = new System.Drawing.Size(82, 23);
            this.submitHoursButton.TabIndex = 1;
            this.submitHoursButton.Text = "Submit Hours";
            this.submitHoursButton.UseVisualStyleBackColor = true;
            this.submitHoursButton.Click += new System.EventHandler(this.submitHoursButton_Click);
            // 
            // enterHoursTextBox
            // 
            this.enterHoursTextBox.Location = new System.Drawing.Point(12, 12);
            this.enterHoursTextBox.Multiline = true;
            this.enterHoursTextBox.Name = "enterHoursTextBox";
            this.enterHoursTextBox.Size = new System.Drawing.Size(222, 259);
            this.enterHoursTextBox.TabIndex = 2;
            // 
            // enterHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 312);
            this.Controls.Add(this.enterHoursTextBox);
            this.Controls.Add(this.submitHoursButton);
            this.Controls.Add(this.backButton);
            this.Name = "enterHoursForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Solutions - Enter Hours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button submitHoursButton;
        private System.Windows.Forms.TextBox enterHoursTextBox;
    }
}