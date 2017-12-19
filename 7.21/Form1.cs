using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolsLibrary;

namespace _7._21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeArrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int[] Arr = ArrConverter.StrToArray<int>(ArrInput.Text);
                int K = int.Parse(KInput.Text);
                ArrayTls arrayTls = new ArrayTls(Arr);
                int[] ArrNew = arrayTls.SwapFirstAndK(K);
                FirstArrOut.Text = ArrConverter.ArrayToStr(ArrNew);
                ArrNew = arrayTls.SwapLastAndK(K);
                LastArrOut.Text = ArrConverter.ArrayToStr(ArrNew);
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
