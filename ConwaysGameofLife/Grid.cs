using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameofLife
{
    class Grid
    {
        private int width;
        private int height;

        public Grid(int x, int y)
        {
            width = x;
            height = y;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }
    }
}
