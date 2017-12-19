using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLibrary
{
    public class BoolMatrix
    {
        public bool[,] Matrix { get; set; }
        public BoolMatrix(bool[,] Matrix)
        {
            this.Matrix = Matrix;
        }
        private bool CheckRectangle(int Row, int Column, int height, int width)
        {
            for (int i = Row; i < Row+height; i++)
            {
                for (int j = Column; j < Column+width; j++)
                {
                    if (!Matrix[i, j])
                        return false;
                }
            }
            for (int i = Row - 1; i < Row+height+1; i++)
            {
                try
                {
                    if (Matrix[i, Column - 1])
                        return false;
                }
                catch (Exception) { }
                try
                {
                    if (Matrix[i, Column + width])
                        return false;
                }
                catch (Exception) { }
            }
            for (int i = Column; i < Column+width; i++)
            {
                try
                {
                    if (Matrix[Row - 1, i])
                        return false;
                }
                catch (Exception) { }
                try
                {
                    if (Matrix[Row + height, i])
                        return false;
                }
                catch (Exception) { }
            }
            return true;
        }
        public bool SearchMaxRectangle(out int Row, out int Column, out int height,out int width)
        {
            Row = 0;
            Column = 0;
            height = 0;
            width = 0;
            bool find = false;
            int heighT = 0;
            int widthT = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if(Matrix[i,j])
                    {
                        GetWidthAndHeight(i, j, out heighT, out widthT);
                        if(height*width < heighT*widthT && CheckRectangle(i, j, heighT, widthT))
                        {
                            find = true;
                            Row = i;
                            Column = j;
                            height = heighT;
                            width = widthT;
                        }
                        j += width;
                    }
                }
            }
            return find;
        }
        private void GetWidthAndHeight(int Row, int Column, out int height, out int width)
        {
            height = 1;
            for (int i = Row+1; i < Matrix.GetLength(0); i++)
            {
                if (Matrix[i, Column])
                    height++;
                else
                    break;
            }
            width = 1;
            for (int i = Column+1; i < Matrix.GetLength(1); i++)
            {
                if (Matrix[Row, i])
                    width++;
                else break;
            }
        }
    }
}
