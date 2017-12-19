using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLibrary
{
    public class MatrixConvert
    {
        public static bool[,] StringToBoolMatrix(string Str)
        {
            try
            {
                string[] Rows = Str.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                string[] Line = Rows[0].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                bool[,] Matrix = new bool[Rows.Length, Line.Length];
                for (int i = 0; i < Matrix.GetLength(0); i++)
                {
                    Line = Rows[i].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        switch (Line[j])
                        {
                            case "0":
                                Matrix[i, j] = false;
                                break;
                            case "1":
                                Matrix[i, j] = true;
                                break;
                            default:
                                throw new Exception();
                        }
                    }
                }
                return Matrix;
            }
            catch (Exception)
            {
                throw new Exception("некорректная матрица");
            }
        }
        public static int[,] StringToIntMatrix(string Str)
        {
            try
            {
                string[] Rows = Str.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                string[] Line = Rows[0].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int[,] Matrix = new int[Rows.Length, Line.Length];
                for (int i = 0; i < Matrix.GetLength(0); i++)
                {
                    Line = Rows[i].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        Matrix[i, j] = int.Parse(Line[j]);
                    }
                }
                return Matrix;
            }
            catch (Exception)
            {
                throw new Exception("некорректная матрица");
            }
        }
    }
}
