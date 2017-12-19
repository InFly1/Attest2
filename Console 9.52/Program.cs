using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsLibrary;

namespace Console_9._52
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
            int[,] Matrix = ReadIntMatrix();
            IntMatrix intMatrix = new IntMatrix(Matrix);
            int[] Arr = intMatrix.GetArr();
            WriteArr(Arr);
        }

        private static int[,] IntMatrixFile()
        {
            while (true)
            {
                try
                {
                    Console.Write("введите имя файла: ");
                    FileTls fileTls = new FileTls(Console.ReadLine());
                    int[,] Matrix = fileTls.ReadIntMatrix();
                    if (Matrix.GetLength(0) != Matrix.GetLength(1))
                    {
                        throw new Exception("матрица не квадратная");
                    }
                    return Matrix;
                }
                catch (Exception eror)
                {
                    Console.WriteLine(eror.Message);
                }
            }
        }
        private static int[,] IntMatrixConsole()
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
                    int[,] Matrix = MatrixConvert.StringToIntMatrix(sb.ToString());
                    if (Matrix.GetLength(0) != Matrix.GetLength(1))
                    {
                        throw new Exception("матрица не квадратная");
                    }
                    return Matrix;
                }
                catch (Exception eror)
                {
                    Console.WriteLine(eror.Message);
                }
            }
        }
        public static int[,] ReadIntMatrix()
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
                        return IntMatrixConsole();
                    case 'Y':
                    case 'y':
                        return IntMatrixFile();
                }
            }
        }
        private static void ArrFile(int[] Arr)
        {
            while (true)
            {
                try
                {
                    Console.Write("введите имя файла: ");
                    FileTls fileTls = new FileTls(Console.ReadLine());
                    fileTls.WriteArr(Arr);
                    return;
                }
                catch (Exception eror)
                {
                    Console.WriteLine(eror.Message);
                }
            }
        }
        public static void WriteArr(int[] Arr)
        {
            while (true)
            {
                Console.Write("сохранить массив в файл (y/n)? ");
                ConsoleKeyInfo Key = Console.ReadKey();
                Console.WriteLine();
                switch (Key.KeyChar)
                {
                    case 'N':
                    case 'n':
                        Console.WriteLine(ArrConverter.ArrayToStr(Arr));
                        return;
                    case 'Y':
                    case 'y':
                        ArrFile(Arr);
                        return;
                }
            }
        }
    }
}
