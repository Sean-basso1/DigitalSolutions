namespace DigitalSolutions___Prototype1___SB
{
    partial class projectScreenForm
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
            this.applyChangesButton = new System.Windows.Forms.Button();
            this.createInvoiceButton = new System.Windows.Forms.Button();
            this.projectScreenTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 311);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // applyChangesButton
            // 
            this.applyChangesButton.Location = new System.Drawing.Point(154, 311);
            this.applyChangesButton.Name = "applyChangesButton";
            this.applyChangesButton.Size = new System.Drawing.Size(87, 23);
            this.applyChangesButton.TabIndex = 1;
            this.applyChangesButton.Text = "Apply Changes";
            this.applyChangesButton.UseVisualStyleBackColor = true;
            this.applyChangesButton.Click += new System.EventHandler(this.applyChangesButton_Click);
            // 
            // createInvoiceButton
            // 
            this.createInvoiceButton.Location = new System.Drawing.Point(247, 311);
            this.createInvoiceButton.Name = "createInvoiceButton";
            this.createInvoiceButton.Size = new System.Drawing.Size(91, 23);
            this.createInvoiceButton.TabIndex = 2;
            this.createInvoiceButton.Text = "Create Invoice";
            this.createInvoiceButton.UseVisualStyleBackColor = true;
            this.createInvoiceButton.Click += new System.EventHandler(this.createInvoiceButton_Click);
            // 
            // projectScreenTextBox
            // 
            this.projectScreenTextBox.Location = new System.Drawing.Point(12, 12);
            this.projectScreenTextBox.Multiline = true;
            this.projectScreenTextBox.Name = "projectScreenTextBox";
            this.projectScreenTextBox.Size = new System.Drawing.Size(326, 293);
            this.projectScreenTextBox.TabIndex = 3;
            // 
            // projectScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 346);
            this.Controls.Add(this.projectScreenTextBox);
            this.Controls.Add(this.createInvoiceButton);
            this.Controls.Add(this.applyChangesButton);
            this.Controls.Add(this.backButton);
            this.Name = "projectScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Solutions - Project Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button applyChangesButton;
        private System.Windows.Forms.Button createInvoiceButton;
        private System.Windows.Forms.TextBox projectScreenTextBox;
    }
}