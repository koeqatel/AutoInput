namespace Auto_Packet
{
    partial class Click
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
            this.LeftClick = new System.Windows.Forms.CheckBox();
            this.RightClick = new System.Windows.Forms.CheckBox();
            this.delayNum = new System.Windows.Forms.NumericUpDown();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.ClickTimer = new System.Windows.Forms.Timer(this.components);
            this.hotkeyLabel = new System.Windows.Forms.Label();
            this.msLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.delayNum)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftClick
            // 
            this.LeftClick.AutoSize = true;
            this.LeftClick.Checked = true;
            this.LeftClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LeftClick.Location = new System.Drawing.Point(15, 33);
            this.LeftClick.Name = "LeftClick";
            this.LeftClick.Size = new System.Drawing.Size(67, 17);
            this.LeftClick.TabIndex = 0;
            this.LeftClick.Text = "LeftClick";
            this.LeftClick.UseVisualStyleBackColor = true;
            this.LeftClick.Click += new System.EventHandler(this.LeftClick_Click);
            // 
            // RightClick
            // 
            this.RightClick.AutoSize = true;
            this.RightClick.Location = new System.Drawing.Point(88, 33);
            this.RightClick.Name = "RightClick";
            this.RightClick.Size = new System.Drawing.Size(74, 17);
            this.RightClick.TabIndex = 1;
            this.RightClick.Text = "RightClick";
            this.RightClick.UseVisualStyleBackColor = true;
            this.RightClick.Click += new System.EventHandler(this.RightClick_Click);
            // 
            // delayNum
            // 
            this.delayNum.Location = new System.Drawing.Point(60, 7);
            this.delayNum.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.delayNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delayNum.Name = "delayNum";
            this.delayNum.Size = new System.Drawing.Size(67, 20);
            this.delayNum.TabIndex = 54;
            this.delayNum.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.delayNum.ValueChanged += new System.EventHandler(this.delayNum_ValueChanged);
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(12, 9);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(42, 13);
            this.intervalLabel.TabIndex = 51;
            this.intervalLabel.Text = "Interval";
            // 
            // ClickTimer
            // 
            this.ClickTimer.Interval = 1000;
            this.ClickTimer.Tick += new System.EventHandler(this.ClickTimer_Tick);
            // 
            // hotkeyLabel
            // 
            this.hotkeyLabel.AutoSize = true;
            this.hotkeyLabel.Location = new System.Drawing.Point(9, 53);
            this.hotkeyLabel.Name = "hotkeyLabel";
            this.hotkeyLabel.Size = new System.Drawing.Size(153, 13);
            this.hotkeyLabel.TabIndex = 55;
            this.hotkeyLabel.Text = "press <hotkey> to start clicking";
            // 
            // msLabel
            // 
            this.msLabel.AutoSize = true;
            this.msLabel.Location = new System.Drawing.Point(133, 9);
            this.msLabel.Name = "msLabel";
            this.msLabel.Size = new System.Drawing.Size(21, 13);
            this.msLabel.TabIndex = 56;
            this.msLabel.Text = "Ms";
            // 
            // Click
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 78);
            this.Controls.Add(this.msLabel);
            this.Controls.Add(this.hotkeyLabel);
            this.Controls.Add(this.delayNum);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.RightClick);
            this.Controls.Add(this.LeftClick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Click";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Clicker";
            this.Load += new System.EventHandler(this.ClickMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.delayNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox LeftClick;
        private System.Windows.Forms.CheckBox RightClick;
        private System.Windows.Forms.NumericUpDown delayNum;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Label hotkeyLabel;
        public System.Windows.Forms.Timer ClickTimer;
        private System.Windows.Forms.Label msLabel;
    }
}