using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameofLife
{
    public class CellMatrix
    {
        public List<int[]> cells = new List<int[]>();
        public int matrixRows, matrixCols;

        public CellMatrix(int rows, int columns)
        {
            matrixRows = rows;
            matrixCols = columns;

            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                int[] row = new int[columns];

                for (int j = 0; j < columns; j++)
                {
                    // Create the row that will be added
                    row[j] = rand.Next(0, 2);
                }
                cells.Add(row);
            }
        }


        public void Update()
        {
            List<int[]> temp = new List<int[]>();
            int aliveNeighbors = 0;

            // First need to fill it with the proper amount of arrays.

            for (int i = 0; i < matrixRows; i++)
            {
                temp.Add(new int[matrixCols]);
            }

            // Loop through all of cells and update temp

            for (int i = 0; i < cells.Count; i++)
            {
                for (int j = 0; j < cells[i].Length; j++)
                {
                    aliveNeighbors = CountNeighbors(i, j);

                    // Update based on if it is an alive cell

                    if (cells[i][j] == 1)
                    {
                        // cell stays alive if neighbors number between 2 and 3
                        if ((aliveNeighbors >= 2) && (aliveNeighbors <= 3))
                        {
                            temp[i][j] = 1;
                        }
                        // Otherwise the cell dies
                        else
                        {
                            temp[i][j] = 0;
                        }
                    }
                    // Update if cell is a dead cell
                    else
                    {
                        if (aliveNeighbors == 3)
                        {
                            temp[i][j] = 1;
                        }
                    }
                }
            }

            // Update cells to new values.

            cells = temp;

        }

        public int CountNeighbors(int currentRow, int currentCol)
        {
            // Initialize the count of the neighbors
            int aliveNeighbors;

            if (cells[currentRow][currentCol] == 1)
            {
                // This prevents the current cell from adding itself to the neighbor count
                aliveNeighbors = -1;
            }
            else
            {
                aliveNeighbors = 0;
            }

            // Get the bounds of the neighbors.

            int previousRow = Math.Max(0, currentRow - 1);
            int nextRow = Math.Min(currentRow + 1, cells.Count - 1);
            int previousColumn = Math.Max(0, currentCol - 1);
            int nextCol = Math.Min(currentCol + 1, cells[currentRow].Length - 1);

            for (int cellRow = previousRow; cellRow <= nextRow; cellRow++)
            {
                // Iterate through the columns.
                for (int cellCol = previousColumn; cellCol <= nextCol; cellCol++)
                {
                    aliveNeighbors += cells[cellRow][cellCol];
                }
            }

            // Make sure neighbor count isn't negative.

            aliveNeighbors = Math.Max(0, aliveNeighbors);
            return aliveNeighbors;
        }
    }
}
