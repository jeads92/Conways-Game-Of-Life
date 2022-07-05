namespace ConwaysGameofLife
{
    public partial class ConwaysGameOfLife : Form
    {
        CellMatrix cellMatrix = new CellMatrix(50,50);
        public ConwaysGameOfLife()
        {
            InitializeComponent();
        }

        private void ConwaysGameOfLife_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xPosition = 0;
            int yPosition = 0;
            int xSize = 50;
            int ySize = 50;
            for(int i = 0; i < 10; i++)
            {
                Label labelGen = new Label();
                labelGen.Text = " ";
                labelGen.BackColor = Color.Chartreuse;
                labelGen.Size = new Size(xSize, ySize);
                labelGen.Location = new Point(xPosition, yPosition);
                xPosition += xSize;
                Controls.Add(labelGen);
            }
        }

        private void testgrid_Click(object sender, EventArgs e)
        {
            Grid tester = new Grid(10, 10);
            debugBox.Items.Add(tester.GetHeight());
            debugBox.Items.Add(tester.GetWidth());
        }

        private void displayGrid(Grid gridObject)
        {
            panel1.Controls.Clear();
            int xPosition = 0;
            int yPosition = 0;
            int xSize = 10;
            int ySize = 10;
            Random rand = new Random();
            for (int i = 0; i < gridObject.GetHeight(); i++)
            {
                for (int j = 0; j < gridObject.GetWidth(); j++)
                {
                    Label lbl = new Label();
                    lbl.Text = " ";
                    if (rand.Next(0, 2) == 0)
                    { 
                        lbl.BackColor = Color.Chartreuse;
                    }
                    else
                    {
                        lbl.BackColor = Color.Black;
                    }
                    lbl.Size = new Size(xSize, ySize);
                    lbl.Location = new Point(xPosition, yPosition);
                    panel2.Controls.Add(lbl);
                    xPosition += xSize;
                }
                xPosition = 0;
                yPosition += ySize;
            }
        }

        private void createDisplay_Click(object sender, EventArgs e)
        {
            Grid tester = new Grid(5, 10);
            displayGrid(tester);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int squareWidth = 10;
            int squareHeight = 10;
            int squareXLocation = 0;
            int squareYLocation = 0;

            SolidBrush myBrush = new SolidBrush(Color.RebeccaPurple);
            SolidBrush myBrush2 = new SolidBrush(Color.Blue);
            Graphics formGraphics;
            formGraphics = panel2.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 10, 10));

            for (int i = 0; i < cellMatrix.matrixRows; i++)
            {
                for (int j = 0; j < cellMatrix.matrixCols; j++)
                {
                    if(cellMatrix.cells[i][j] == 0)
                    {
                        formGraphics.FillRectangle(myBrush, new Rectangle(squareXLocation, squareYLocation, 10, 10));
                    }
                    else
                    {
                        formGraphics.FillRectangle(myBrush2, new Rectangle(squareXLocation, squareYLocation, 10, 10));
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

        private void timerbtn_Click(object sender, EventArgs e)
        {
            Grid tester = new Grid(10, 10);
            displayGrid(tester);
        }

        private void clearpanel_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
        }

        private void changeColors_Click(object sender, EventArgs e)
        {
            foreach(Control control in panel2.Controls)
            {
                Label iterLabel = control as Label;
                iterLabel.BackColor = Color.Purple;
            }
        }

        private void paintButton_Click(object sender, EventArgs e)
        {
            int squareWidth = 10;
            int squareHeight = 10;
            int squareXLocation = 0;
            int squareYLocation = 0;

            SolidBrush myBrush = new SolidBrush(Color.RebeccaPurple);
            Graphics formGraphics;
            formGraphics = panel2.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 10, 10));

            for (int i = 0; i < 25; i++)
            {
                for(int j = 0; j < 25; j++)
                {
                    formGraphics.FillRectangle(myBrush, new Rectangle(squareXLocation, squareYLocation, 10, 10));
                    squareXLocation += squareWidth;
                }
                squareYLocation += squareHeight;
                squareXLocation = 0;
            }

            // Dispose of the unwanted objects
            myBrush.Dispose();
            formGraphics.Dispose();
        }
    }
}