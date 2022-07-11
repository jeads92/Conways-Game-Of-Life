namespace ConwaysGameofLife
{
    public partial class ConwaysGameOfLife : Form
    {
        CellMatrix cellMatrix = new CellMatrix(50, 50);
        public ConwaysGameOfLife()
        {
            InitializeComponent();
        }

        private void ConwaysGameOfLife_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float squareWidth = (float)panel2.Width / 50f;
            float squareHeight = (float)panel2.Height / 50f;
            float squareXLocation = 0f;
            float squareYLocation = 0f;
            // debug info
            debugLbl.Text = $"square width: {squareWidth}. square height: {squareHeight}";
            SolidBrush myBrush = new SolidBrush(Color.RebeccaPurple);
            SolidBrush myBrush2 = new SolidBrush(Color.Blue);
            Graphics formGraphics;
            formGraphics = panel2.CreateGraphics();

            for (int i = 0; i < cellMatrix.matrixRows; i++)
            {
                for (int j = 0; j < cellMatrix.matrixCols; j++)
                {
                    if(cellMatrix.cells[i][j] == 0)
                    {
                        formGraphics.FillRectangle(myBrush, new RectangleF(squareXLocation, squareYLocation, squareWidth, squareHeight));
                    }
                    else
                    {
                        formGraphics.FillRectangle(myBrush2, new RectangleF(squareXLocation, squareYLocation, squareWidth, squareHeight));
                    }
                    
                    squareXLocation += squareWidth;
                }
                squareYLocation += squareHeight;
                squareXLocation = 0;
            }

            // Dispose of the unwanted objects
            myBrush.Dispose();
            myBrush2.Dispose();
            formGraphics.Dispose();

            cellMatrix.Update();

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            // If the timer is turned on, turn it off.
            if(timer1.Enabled == true)
            {
                timer1.Enabled = false;
                startBtn.Text = "Start";
            }
            else
            {
                // Otherwise, turn on the timer
                timer1.Enabled = true;
                startBtn.Text = "Stop";
            }
        }

        // Use radio buttons to change the speed of the simulation
        private void radioSpeed1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioSpeed1.Checked == true)
            {
                timer1.Interval = 100;
            }
        }

        private void radioSpeed2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioSpeed2.Checked == true)
            {
                timer1.Interval = 500;
            }
        }

        private void radioSpeed3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioSpeed3.Checked == true)
            {
                timer1.Interval = 1000;
            }
        }

        private void radioSpeed4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSpeed4.Checked == true)
            {
                timer1.Interval = 2000;
            }
        }
    }
}