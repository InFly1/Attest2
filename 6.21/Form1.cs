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

namespace _6._21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            string Str = StringInput.Text;
            string Word = WordInput.Text;
            StringTls stringTls = new StringTls(Str);
            if (stringTls.CheckOnWord(Word))
                Output.Text = "удволетворяет условию";
            else
                Output.Text = "не удволетворяет условию";
        }
    }
}
