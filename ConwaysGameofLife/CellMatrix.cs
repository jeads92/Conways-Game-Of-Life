using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameofLife
{
    /// <summary>
    /// Class <c>CellMatrix</c> Uses a 2D matrix to model a "living" simulation".
    /// </summary>
    public class CellMatrix
    {
        public List<int[]> cells = new List<int[]>();
        public int matrixRows, matrixCols;

        /// <summary>
        /// Creates CellMatrix object. <c>rows</c> specifies the height, and
        /// <c>columns</c> specifies the width of the matrix.
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        public CellMatrix(int rows, int columns)
        {
            matrixRows = rows;
            matrixCols = columns;

            Random rand = new Random();

            // Iterate through the rows.
            for (int i = 0; i < rows; i++)
            {
                int[] row = new int[columns];

                // Create the columns with random values.
                for (int j = 0; j < columns; j++)
                {
                    row[j] = rand.Next(0, 2);
                }
                cells.Add(row);
            }
        }

        /// <summary>
        /// Uses Conway's rules to update to the next iteration of the cell matrix.
        /// </summary>
        public void Update()
        {
            List<int[]> temp = new List<int[]>();
            int aliveNeighbors = 0;

            // Fill temp array with the rows of arrays.
            for (int i = 0; i < matrixRows; i++)
            {
                temp.Add(new int[matrixCols]);
            }

            // Loop through all of the cells and update temp.
            for (int i = 0; i < cells.Count; i++)
            {
                for (int j = 0; j < cells[i].Length; j++)
                {
                    aliveNeighbors = CountNeighbors(i, j);

                    // Update based on if it is an alive cell.
                    if (cells[i][j] == 1)
                    {
                        // cell stays alive if neighbors number between 2 and 3.
                        if ((aliveNeighbors >= 2) && (aliveNeighbors <= 3))
                        {
                            temp[i][j] = 1;
                        }
                        // Otherwise the cell dies.
                        else
                        {
                            temp[i][j] = 0;
                        }
                    }
                    // If the cell is dead and has 3 alive neighbors, create a live cell.
                    else
                    {
                        if (aliveNeighbors == 3)
                        {
                            temp[i][j] = 1;
                        }
                    }
                }
            }

            // Update cells to new value.
            cells = temp;

        }

        /// <summary>
        /// Returns the number of live cells that a specific cell has.
        /// </summary>
        /// <param name="currentRow"></param>
        /// <param name="currentCol"></param>
        /// <returns> An integer representing the number of live neighbors.</returns>
        public int CountNeighbors(int currentRow, int currentCol)
        {
            // Initialize the count of the neighbors.
            int aliveNeighbors;

            if (cells[currentRow][currentCol] == 1)
            {
                // This prevents the current cell from adding itself to the neighbor count.
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

            // Iterate through the rows.
            for (int cellRow = previousRow; cellRow <= nextRow; cellRow++)
            {
                // Iterate through the columns.
                for (int cellCol = previousColumn; cellCol <= nextCol; cellCol++)
                {
                    // Add 1 to aliveNeighbors if the cell is alive (equal to 1).
                    aliveNeighbors += cells[cellRow][cellCol];
                }
            }

            // Make sure neighbor count isn't negative.
            aliveNeighbors = Math.Max(0, aliveNeighbors);
            return aliveNeighbors;
        }
    }
}
