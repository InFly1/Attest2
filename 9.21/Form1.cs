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

namespace _9._21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Grid.RowTemplate.Height = 30;
            DataGridViewUtils.InitGridForArr(Grid, Grid.RowTemplate.Height, true, false, false, false, false, false);
        }

        private void Grid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Grid[e.ColumnIndex, e.RowIndex].Value = true;
            if (e.Button == MouseButtons.Right)
                Grid[e.ColumnIndex, e.RowIndex].Value = false;
        }

        private void Grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (Grid[e.ColumnIndex, e.RowIndex].Value == null)
                Grid[e.ColumnIndex, e.RowIndex].Value = false;
            if ((bool)Grid[e.ColumnIndex, e.RowIndex].Value == false)
                e.CellStyle.BackColor = Color.White;
            else
                e.CellStyle.BackColor = Color.Gray;
            e.PaintBackground(e.CellBounds, false);
            e.Handled = true;
        }
        private void AddColumn_Click(object sender, EventArgs e)
        {
            Grid.ColumnCount++;
        }

        private void DeleteColumn_Click(object sender, EventArgs e)
        {
            if (Grid.ColumnCount > 1)
                Grid.ColumnCount--;
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            if (Grid.RowCount > 1)
                Grid.RowCount--;
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            Grid.RowCount++;
        }

        private void SearchMaxRectangle_Click(object sender, EventArgs e)
        {
            bool[,] matrix = DataGridViewUtils.GridToArray2<bool>(Grid);
            BoolMatrix boolMatrix = new BoolMatrix(matrix);
            if (boolMatrix.SearchMaxRectangle(out int Row, out int Column, out int height, out int width))
            {
                Output.Text = "(" + Row + ", " + Column + ", " + height + ", " + width + ")";
                save.Enabled = true;
            }
            else
            {
                Output.Text = "прямоугольник не найден";
                save.Enabled = false;
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog()== DialogResult.OK)
            {
                try
                {
                    FileTls fileTls = new FileTls(openFileDialog.FileName);
                    bool[,] Matrix = fileTls.ReadBoolMatrix();
                    DataGridViewUtils.Array2ToGrid(Grid, Matrix);
                }
                catch (Exception eror)
                {
                    MessageBox.Show(eror.Message, "ошибка");
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileTls fileTls = new FileTls(saveFileDialog.FileName);
                    fileTls.WriteString(Output.Text);
                }
                catch (Exception eror)
                {
                    MessageBox.Show(eror.Message, "ошибка");
                }
            }
        }
    }
}
