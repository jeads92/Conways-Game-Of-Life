namespace ConwaysGameofLife
{
    partial class ConwaysGameOfLife
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioSpeed1 = new System.Windows.Forms.RadioButton();
            this.radioSpeed2 = new System.Windows.Forms.RadioButton();
            this.radioSpeed3 = new System.Windows.Forms.RadioButton();
            this.radioSpeed4 = new System.Windows.Forms.RadioButton();
            this.debugLbl = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(35, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 500);
            this.panel2.TabIndex = 8;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(112)))), ((int)(((byte)(144)))));
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startBtn.Location = new System.Drawing.Point(237, 527);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 9;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(548, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Interval Time in Milliseconds:";
            // 
            // radioSpeed1
            // 
            this.radioSpeed1.AutoSize = true;
            this.radioSpeed1.Location = new System.Drawing.Point(548, 48);
            this.radioSpeed1.Name = "radioSpeed1";
            this.radioSpeed1.Size = new System.Drawing.Size(62, 19);
            this.radioSpeed1.TabIndex = 11;
            this.radioSpeed1.Text = "100 ms";
            this.radioSpeed1.UseVisualStyleBackColor = true;
            this.radioSpeed1.CheckedChanged += new System.EventHandler(this.radioSpeed1_CheckedChanged);
            // 
            // radioSpeed2
            // 
            this.radioSpeed2.AutoSize = true;
            this.radioSpeed2.Location = new System.Drawing.Point(548, 73);
            this.radioSpeed2.Name = "radioSpeed2";
            this.radioSpeed2.Size = new System.Drawing.Size(62, 19);
            this.radioSpeed2.TabIndex = 12;
            this.radioSpeed2.Text = "500 ms";
            this.radioSpeed2.UseVisualStyleBackColor = true;
            this.radioSpeed2.CheckedChanged += new System.EventHandler(this.radioSpeed2_CheckedChanged);
            // 
            // radioSpeed3
            // 
            this.radioSpeed3.AutoSize = true;
            this.radioSpeed3.Checked = true;
            this.radioSpeed3.Location = new System.Drawing.Point(548, 98);
            this.radioSpeed3.Name = "radioSpeed3";
            this.radioSpeed3.Size = new System.Drawing.Size(68, 19);
            this.radioSpeed3.TabIndex = 13;
            this.radioSpeed3.TabStop = true;
            this.radioSpeed3.Text = "1000 ms";
            this.radioSpeed3.UseVisualStyleBackColor = true;
            this.radioSpeed3.CheckedChanged += new System.EventHandler(this.radioSpeed3_CheckedChanged);
            // 
            // radioSpeed4
            // 
            this.radioSpeed4.AutoSize = true;
            this.radioSpeed4.Location = new System.Drawing.Point(548, 123);
            this.radioSpeed4.Name = "radioSpeed4";
            this.radioSpeed4.Size = new System.Drawing.Size(68, 19);
            this.radioSpeed4.TabIndex = 14;
            this.radioSpeed4.Text = "2000 ms";
            this.radioSpeed4.UseVisualStyleBackColor = true;
            this.radioSpeed4.CheckedChanged += new System.EventHandler(this.radioSpeed4_CheckedChanged);
            // 
            // debugLbl
            // 
            this.debugLbl.AutoSize = true;
            this.debugLbl.Location = new System.Drawing.Point(565, 416);
            this.debugLbl.Name = "debugLbl";
            this.debugLbl.Size = new System.Drawing.Size(0, 15);
            this.debugLbl.TabIndex = 15;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(112)))), ((int)(((byte)(144)))));
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.refreshBtn.Location = new System.Drawing.Point(544, 489);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(164, 23);
            this.refreshBtn.TabIndex = 16;
            this.refreshBtn.Text = "Refresh Cells";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // ConwaysGameOfLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(216)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(717, 556);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.debugLbl);
            this.Controls.Add(this.radioSpeed4);
            this.Controls.Add(this.radioSpeed3);
            this.Controls.Add(this.radioSpeed2);
            this.Controls.Add(this.radioSpeed1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.panel2);
            this.Name = "ConwaysGameOfLife";
            this.Text = "Conway\'s Game of Life";
            this.Load += new System.EventHandler(this.ConwaysGameOfLife_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Panel panel2;
        private Button startBtn;
        private Label label1;
        private RadioButton radioSpeed1;
        private RadioButton radioSpeed2;
        private RadioButton radioSpeed3;
        private RadioButton radioSpeed4;
        private Label debugLbl;
        private Button refreshBtn;
    }
}