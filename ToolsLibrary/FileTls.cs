using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToolsLibrary
{
    public class FileTls
    {
        public string Path { get; set; }
        public FileTls(string Path)
        {
            this.Path = Path;
        }
        public int[,] ReadIntMatrix()
        {
            try
            {
                return MatrixConvert.StringToIntMatrix(File.ReadAllText(Path));
            }
            catch (Exception)
            {
                throw new Exception("ошибка чтения");
            }
        }
        public bool[,] ReadBoolMatrix()
        {
            try
            {
                return MatrixConvert.StringToBoolMatrix(File.ReadAllText(Path));
            }
            catch (Exception)
            {
                throw new Exception("ошибка чтения");
            }
        }
        public void WriteArr(int[] Arr)
        {
            try
            {
                File.WriteAllText(Path, ArrConverter.ArrayToStr(Arr));
            }
            catch (Exception)
            {
                throw new Exception("ошибка записи");
            }
        }
        public void WriteString(string s)
        {
            try
            {
                File.WriteAllText(Path, s);
            }
            catch (Exception)
            {
                throw new Exception("ошибка записи");
            }
        }
    }
}
