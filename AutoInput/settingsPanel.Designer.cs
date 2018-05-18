namespace AutoInput
{
    partial class settingsPanel
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.stayInFrontCheck = new System.Windows.Forms.CheckBox();
            this.hotkeyText = new System.Windows.Forms.Label();
            this.hotkeyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(172, 55);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 55);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // stayInFrontCheck
            // 
            this.stayInFrontCheck.AutoSize = true;
            this.stayInFrontCheck.Location = new System.Drawing.Point(12, 32);
            this.stayInFrontCheck.Name = "stayInFrontCheck";
            this.stayInFrontCheck.Size = new System.Drawing.Size(82, 17);
            this.stayInFrontCheck.TabIndex = 7;
            this.stayInFrontCheck.Text = "Stay in front";
            this.stayInFrontCheck.UseVisualStyleBackColor = true;
            // 
            // hotkeyText
            // 
            this.hotkeyText.AutoSize = true;
            this.hotkeyText.Location = new System.Drawing.Point(9, 9);
            this.hotkeyText.Name = "hotkeyText";
            this.hotkeyText.Size = new System.Drawing.Size(85, 13);
            this.hotkeyText.TabIndex = 6;
            this.hotkeyText.Text = "Startup shortcut:";
            // 
            // hotkeyTextBox
            // 
            this.hotkeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hotkeyTextBox.Location = new System.Drawing.Point(100, 6);
            this.hotkeyTextBox.Name = "hotkeyTextBox";
            this.hotkeyTextBox.ReadOnly = true;
            this.hotkeyTextBox.Size = new System.Drawing.Size(147, 20);
            this.hotkeyTextBox.TabIndex = 11;
            this.hotkeyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeyTextBox_KeyDown);
            // 
            // settingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 90);
            this.Controls.Add(this.hotkeyTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.stayInFrontCheck);
            this.Controls.Add(this.hotkeyText);
            this.Name = "settingsPanel";
            this.Text = "settingsPanel";
            this.Load += new System.EventHandler(this.settingsPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox stayInFrontCheck;
        private System.Windows.Forms.Label hotkeyText;
        private System.Windows.Forms.TextBox hotkeyTextBox;
    }
}