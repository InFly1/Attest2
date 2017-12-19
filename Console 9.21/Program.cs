using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsLibrary;

namespace Console_9._21
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                run();
            }
        }

        private static void run()
        {
            bool[,] Matrix = ReadBoolMatrix();
            BoolMatrix boolMatrix = new BoolMatrix(Matrix);
            if(boolMatrix.SearchMaxRectangle(out int Row, out int Column, out int height, out int width))
            {
                WriteString("(" + Row + "," + Column + "," + height + "," + width + ")");
            }
            else
            {
                WriteString("прямоугольник не найден");
            }
        }
        private static bool[,] BoolMatrixFile()
        {
            while (true)
            {
                try
                {
                    Console.Write("введите имя файла: ");
                    FileTls fileTls = new FileTls(Console.ReadLine());
                    bool[,] Matrix = fileTls.ReadBoolMatrix();
                    return Matrix;
                }
                catch (Exception eror)
                {
                    Console.WriteLine(eror.Message);
                }
            }
        }
        private static bool[,] BoolMatrixConsole()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("введите матрицу");
                    StringBuilder sb = new StringBuilder();
                    string line = "";
                    do
                    {
                        line = Console.ReadLine();
                        sb.AppendLine(line);
                    } while (line != "");
                    bool[,] Matrix = MatrixConvert.StringToBoolMatrix(sb.ToString());
                    return Matrix;
                }
                catch (Exception eror)
                {
                    Console.WriteLine(eror.Message);
                }
            }
        }
        public static bool[,] ReadBoolMatrix()
        {
            while (true)
            {
                Console.Write("считать матрицу из файла (y/n)? ");
                ConsoleKeyInfo Key = Console.ReadKey();
                Console.WriteLine();
                switch (Key.KeyChar)
                {
                    case 'N':
                    case 'n':
                        return BoolMatrixConsole();
                    case 'Y':
                    case 'y':
                        return BoolMatrixFile();
                }
            }
        }
        private static void StringFile(string str)
        {
            while (true)
            {
                try
                {
                    Console.Write("введите имя файла: ");
                    FileTls fileTls = new FileTls(Console.ReadLine());
                    fileTls.WriteString(str);
                    return;
                }
                catch (Exception eror)
                {
                    Console.WriteLine(eror.Message);
                }
            }
        }
        public static void WriteString(string str)
        {
            while (true)
            {
                Console.Write("сохранить результат в файл (y/n)? ");
                ConsoleKeyInfo Key = Console.ReadKey();
                Console.WriteLine();
                switch (Key.KeyChar)
                {
                    case 'N':
                    case 'n':
                        Console.WriteLine(str);
                        return;
                    case 'Y':
                    case 'y':
                        StringFile(str);
                        return;
                }
            }
        }
    }
}
