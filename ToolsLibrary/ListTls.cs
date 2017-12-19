using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLibrary
{
    public class ListTls
    {
        public List<int> list { get; set; }
        public ListTls(List<int> list)
        {
            this.list = list;
        }
        private List<int> CreateNewList(IList<int> list)
        {
            List<int> ListNew = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                ListNew.Add(list[i]);
            }
            return ListNew;
        }
        public List<int> GetNewList()
        {
            List<int> listNew = CreateNewList(list);
            listNew.Sort();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (listNew[i] != list[i])
                    listNew.RemoveAt(i);
            }
            return listNew;
        }
    }
}
