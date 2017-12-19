using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GridViewLibrary;
using ToolsLibrary;

namespace _9._52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(InputGrid, 40, false, false, false, true, true, true);
            DataGridViewUtils.InitGridForArr(OutputGrid, 40, true, false, false, false, false, false);
        }

        private void open_Click(object sender, EventArgs e)
        {

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileTls fileTls = new FileTls(openFileDialog.FileName);
                    int[,] Matrix = fileTls.ReadIntMatrix();
                    if(Matrix.GetLength(0) == Matrix.GetLength(0))
                    {
                        DataGridViewUtils.Array2ToGrid(InputGrid, Matrix);
                    }
                    else
                    {
                        throw new Exception("матрица должна быть квадратной");
                    }
                }
                catch (Exception eror)
                {
                    MessageBox.Show(eror.Message, "ошибка");
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileTls fileTls = new FileTls(saveFileDialog.FileName);
                    fileTls.WriteArr(DataGridViewUtils.GridToArray<int>(OutputGrid));
                }
                catch (Exception eror)
                {
                    MessageBox.Show(eror.Message, "ошибка");
                }
            }
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] Matrix = DataGridViewUtils.GridToArray2<int>(InputGrid);
                IntMatrix intMatrix = new IntMatrix(Matrix);
                int[] Arr = intMatrix.GetArr();
                DataGridViewUtils.ArrayToGrid(OutputGrid, Arr);
                save.Enabled = true;
            }
            catch (Exception eror)
            {
                save.Enabled = false;
                MessageBox.Show(eror.Message, "ошибка");
            }
        }
    }
}
