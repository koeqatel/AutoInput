namespace AutoInput
{
    partial class menu
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
            this.settingsButton = new System.Windows.Forms.Button();
            this.clickButton = new System.Windows.Forms.Button();
            this.typeButton = new System.Windows.Forms.Button();
            this.questionText = new System.Windows.Forms.Label();
            this.disclaimerText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(238, 9);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(79, 22);
            this.settingsButton.TabIndex = 77;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // clickButton
            // 
            this.clickButton.Location = new System.Drawing.Point(173, 37);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(144, 99);
            this.clickButton.TabIndex = 74;
            this.clickButton.Text = "Click";
            this.clickButton.UseVisualStyleBackColor = true;
            this.clickButton.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // typeButton
            // 
            this.typeButton.Location = new System.Drawing.Point(12, 37);
            this.typeButton.Name = "typeButton";
            this.typeButton.Size = new System.Drawing.Size(144, 99);
            this.typeButton.TabIndex = 73;
            this.typeButton.Text = "Type";
            this.typeButton.UseVisualStyleBackColor = true;
            this.typeButton.Click += new System.EventHandler(this.typeButton_Click);
            // 
            // questionText
            // 
            this.questionText.AutoSize = true;
            this.questionText.Location = new System.Drawing.Point(96, 21);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(136, 13);
            this.questionText.TabIndex = 72;
            this.questionText.Text = "What would you like to do?\r\n";
            // 
            // disclaimerText
            // 
            this.disclaimerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.disclaimerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disclaimerText.Location = new System.Drawing.Point(12, 142);
            this.disclaimerText.Name = "disclaimerText";
            this.disclaimerText.ReadOnly = true;
            this.disclaimerText.Size = new System.Drawing.Size(305, 10);
            this.disclaimerText.TabIndex = 78;
            this.disclaimerText.Text = "I am not responsible for crashing any computer or any other device.";
            this.disclaimerText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 164);
            this.Controls.Add(this.disclaimerText);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.clickButton);
            this.Controls.Add(this.typeButton);
            this.Controls.Add(this.questionText);
            this.Name = "menu";
            this.Text = "Menu";
            this.Enter += new System.EventHandler(this.menu_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button clickButton;
        private System.Windows.Forms.Button typeButton;
        private System.Windows.Forms.Label questionText;
        private System.Windows.Forms.TextBox disclaimerText;
    }
}