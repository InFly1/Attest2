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

namespace _8._21
{/*
    21. Необходимо из списка чисел составить новый список, состоящий из чисел, которые останутся на своем месте в переданном списке, если этот список отсортировать по возрастанию, например:

{ 3, 1, 3, 7, 7, 5, 9, 9, 15, 12, 10 } → { 3, 7, 9, 9, 12 }

Переданный список не должен измениться (самый простой вариант – создать дополнительный список из элементов переданного списка, новый список отсортировать, а затем сравнивать элементы двух списков).

Реализовать в виде функции

public List<int> CreateNewList(IList<int> list)
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
                List<int> list = ListConvert.StringToList(ListInput.Text);
                ListTls listTls = new ListTls(list);
                List<int> listNew = listTls.GetNewList();
                ListOut.Text = ListConvert.ListToString(listNew);
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
