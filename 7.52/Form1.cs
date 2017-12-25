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

namespace _7._52
{   /*
     Вводится массив целых чисел. Найти наиболее длинную подпоследовательность подряд идущих элементов, которые чередуются (очевидно, что любые два подряд идущих элемента чередуются; реализовать функцию, которая будет возвращать позицию первого элемента такой подпоследовательности и кол-во элементов ).
     В случае нескольких таких подпоследовательностей вывести вторую по счету справа.
     Для массива { 4, 6, 1, 2, 1, 2, 3, 2, 3, 5, 4, 7, 4, 1, 5, 1, 5, 6} правильным ответом будет {2, 3, 2, 3}.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int[] Arr = ArrConverter.StrToArray<int>(ArrInput.Text);
                ArrayTls arrayTls = new ArrayTls(Arr);
                int[] ArrNew = arrayTls.Find2LastMaxAltSeq();
                ArrOutput.Text = ArrConverter.ArrayToStr(ArrNew);
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
