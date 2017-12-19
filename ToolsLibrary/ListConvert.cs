using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLibrary
{
    public class ListConvert
    {
        public static List<int> StringToList(string str)
        {
            List<int> list = new List<int>();
            string[] arr = str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.Length; i++)
            {
                list.Add(int.Parse(arr[i]));
            }
            return list;
        }
        public static string ListToString(IList<int> list)
        {
            return string.Join(", ", list);
        }
    }
}
