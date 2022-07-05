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
    }
}