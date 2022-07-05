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
            this.button1 = new System.Windows.Forms.Button();
            this.debugBox = new System.Windows.Forms.ListBox();
            this.testgrid = new System.Windows.Forms.Button();
            this.createDisplay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerbtn = new System.Windows.Forms.Button();
            this.clearpanel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.changeColors = new System.Windows.Forms.Button();
            this.paintButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1211, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // debugBox
            // 
            this.debugBox.FormattingEnabled = true;
            this.debugBox.ItemHeight = 15;
            this.debugBox.Location = new System.Drawing.Point(1211, 18);
            this.debugBox.Name = "debugBox";
            this.debugBox.Size = new System.Drawing.Size(196, 304);
            this.debugBox.TabIndex = 1;
            // 
            // testgrid
            // 
            this.testgrid.Location = new System.Drawing.Point(1211, 337);
            this.testgrid.Name = "testgrid";
            this.testgrid.Size = new System.Drawing.Size(196, 23);
            this.testgrid.TabIndex = 2;
            this.testgrid.Text = "test grid";
            this.testgrid.UseVisualStyleBackColor = true;
            // 
            // createDisplay
            // 
            this.createDisplay.Location = new System.Drawing.Point(12, 415);
            this.createDisplay.Name = "createDisplay";
            this.createDisplay.Size = new System.Drawing.Size(136, 23);
            this.createDisplay.TabIndex = 3;
            this.createDisplay.Text = "Display Grid";
            this.createDisplay.UseVisualStyleBackColor = true;
            this.createDisplay.Click += new System.EventHandler(this.createDisplay_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerbtn
            // 
            this.timerbtn.Location = new System.Drawing.Point(393, 578);
            this.timerbtn.Name = "timerbtn";
            this.timerbtn.Size = new System.Drawing.Size(107, 23);
            this.timerbtn.TabIndex = 4;
            this.timerbtn.Text = "create label batches";
            this.timerbtn.UseVisualStyleBackColor = true;
            this.timerbtn.Click += new System.EventHandler(this.timerbtn_Click);
            // 
            // clearpanel
            // 
            this.clearpanel.Location = new System.Drawing.Point(506, 578);
            this.clearpanel.Name = "clearpanel";
            this.clearpanel.Size = new System.Drawing.Size(75, 23);
            this.clearpanel.TabIndex = 5;
            this.clearpanel.Text = "clear panel";
            this.clearpanel.UseVisualStyleBackColor = true;
            this.clearpanel.Click += new System.EventHandler(this.clearpanel_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 373);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "time ticker panel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(275, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 500);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "testing Panel";
            // 
            // changeColors
            // 
            this.changeColors.Location = new System.Drawing.Point(421, 13);
            this.changeColors.Name = "changeColors";
            this.changeColors.Size = new System.Drawing.Size(125, 23);
            this.changeColors.TabIndex = 10;
            this.changeColors.Text = "Change Colors";
            this.changeColors.UseVisualStyleBackColor = true;
            this.changeColors.Click += new System.EventHandler(this.changeColors_Click);
            // 
            // paintButton
            // 
            this.paintButton.Location = new System.Drawing.Point(275, 579);
            this.paintButton.Name = "paintButton";
            this.paintButton.Size = new System.Drawing.Size(112, 23);
            this.paintButton.TabIndex = 11;
            this.paintButton.Text = "Draw Square";
            this.paintButton.UseVisualStyleBackColor = true;
            this.paintButton.Click += new System.EventHandler(this.paintButton_Click);
            // 
            // ConwaysGameOfLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1419, 614);
            this.Controls.Add(this.paintButton);
            this.Controls.Add(this.changeColors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clearpanel);
            this.Controls.Add(this.timerbtn);
            this.Controls.Add(this.createDisplay);
            this.Controls.Add(this.testgrid);
            this.Controls.Add(this.debugBox);
            this.Controls.Add(this.button1);
            this.Name = "ConwaysGameOfLife";
            this.Text = "Conway\'s Game of Life";
            this.Load += new System.EventHandler(this.ConwaysGameOfLife_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ListBox debugBox;
        private Button testgrid;
        private Button createDisplay;
        private System.Windows.Forms.Timer timer1;
        private Button timerbtn;
        private Button clearpanel;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button changeColors;
        private Button paintButton;
    }
}