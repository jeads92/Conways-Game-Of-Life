namespace ConwaysGameofLife
{
    public partial class ConwaysGameOfLife : Form
    {
        CellMatrix cellMatrix = new CellMatrix(50, 50);

        /// <summary>
        /// Initializes the app.
        /// </summary>
        public ConwaysGameOfLife()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the app.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConwaysGameOfLife_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Updates the CellMatrix object every tick, and then
        /// draws them using a solidbrush and rectangle.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            float squareWidth = (float)panel2.Width / 50f;
            float squareHeight = (float)panel2.Height / 50f;
            float squareXLocation = 0f;
            float squareYLocation = 0f;

            // Create graphics and colors.
            Color aliveColor = Color.FromArgb(114, 225, 209);
            SolidBrush deadBrush = new SolidBrush(Color.Black);
            SolidBrush aliveBrush = new SolidBrush(aliveColor);
            Graphics formGraphics;
            formGraphics = panel2.CreateGraphics();

            for (int i = 0; i < cellMatrix.matrixRows; i++)
            {
                for (int j = 0; j < cellMatrix.matrixCols; j++)
                {
                    if(cellMatrix.cells[i][j] == 0)
                    {
                        formGraphics.FillRectangle(deadBrush, new RectangleF(squareXLocation, squareYLocation, squareWidth, squareHeight));
                    }
                    else
                    {
                        formGraphics.FillRectangle(aliveBrush, new RectangleF(squareXLocation, squareYLocation, squareWidth, squareHeight));
                    }
                    
                    // Move to the next column.
                    squareXLocation += squareWidth;
                }

                // Move to the next row and return to the first column.
                squareYLocation += squareHeight;
                squareXLocation = 0;
            }

            // Dispose of the unwanted objects.
            deadBrush.Dispose();
            aliveBrush.Dispose();
            formGraphics.Dispose();

            cellMatrix.Update();
        }

        /// <summary>
        /// Starts and stops the simulation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startBtn_Click(object sender, EventArgs e)
        {
            // If the timer is turned on, turn it off.
            if(timer1.Enabled == true)
            {
                timer1.Enabled = false;
                startBtn.Text = "Start";
            }
            // Otherwise, turn on the timer.
            else
            {
                timer1.Enabled = true;
                startBtn.Text = "Stop";
            }
        }

        // Use radio buttons to change the speed of the simulation.
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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            cellMatrix = new CellMatrix(50, 50);
        }
    }
}