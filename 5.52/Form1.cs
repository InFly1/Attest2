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

namespace _5._52
{   /* 
    e*x=1+x+(x*2/2!)+(x*3/3!)+...+(x*n/n!)+...  (R=¥)
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            try
            {
                double X = double.Parse(InputX.Text);
                double epselan = double.Parse(InputE.Text);
                MathTls mathTls = new MathTls(X, epselan);
                OutputX1.Text = mathTls.CalcWay1().ToString();
                OutputX2.Text = mathTls.CalcWay2(out int n).ToString();
                OutputN.Text = n.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
