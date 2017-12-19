using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLibrary
{
    public class IntMatrix
    {
        public int[,] Matrix { get; set; }
        public IntMatrix(int[,] Matrix)
        {
            this.Matrix = Matrix;
        }
        private int GetMaxMultiplyRow()
        {
            int index = 0;
            int multiply = 0;
            int temp = 1;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                temp = GetMultiplyRow(i);
                if(temp > multiply)
                {
                    index = i;
                    multiply = temp;
                }
            }
            return index;
        }
        private int GetMaxMultiplyColumn()
        {
            int index = 0;
            int multiply = 0;
            int temp = 1;
            for (int i = 0; i < Matrix.GetLength(1); i++)
            {
                temp = GetMultiplyColumn(i);
                if (temp > multiply)
                {
                    index = i;
                    multiply = temp;
                }
            }
            return index;
        }

        private int GetMultiplyRow(int index)
        {
            int temp = 1;
            for (int i = 0; i < Matrix.GetLength(1); i++)
            {
                temp *= Matrix[index, i];
            }

            return temp;
        }
        private int GetMultiplyColumn(int index)
        {
            int temp = 1;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                temp *= Matrix[i, index];
            }

            return temp;
        }
        public int[] GetArr()
        {
            if (Matrix.GetLength(0) != Matrix.GetLength(0))
                throw new Exception("матрица не квадратная");
            int K = GetMaxMultiplyColumn();
            int l = GetMaxMultiplyRow();
            int[] Arr = new int[Matrix.GetLength(0) * 2];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                Arr[2 * i] = Matrix[l, i] + Matrix[i, K];
                Arr[2 * i + 1] = Math.Abs(Matrix[l, i] - Matrix[i, K]);
            }
            return Arr;
        }
    }
}
