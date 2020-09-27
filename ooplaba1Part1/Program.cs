using System;

namespace ooplaba1Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть розмарі масивів S та R");
            int lenght = int.Parse(Console.ReadLine());
            int[] R, S;
            R = new int[lenght];
            S = new int[lenght];

            Random rnd = new Random();

            for (int i = 0; i < lenght; i++)
            {
                R[i] = rnd.Next(0, 9);
                S[i] = rnd.Next(10, 14);
            }

            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine("{0}  - елемент масиву S , {1} - елемент масиву R", S[i], R[i]);
            }

            int[,] A = new int[lenght, lenght];

            for (int i = 0; i < lenght; i++)
            {

                for (int j = 0; j < lenght; j++)
                {
                    A[i, j] = R[i] + S[j];
                }
            }

            Console.WriteLine("Вміст матриці A");
            ShowArray(A);
            int[,] transArr = TransArray(A);
            Console.WriteLine("Вміст транспонованої матриці A");
            ShowArray(transArr);
            Console.WriteLine("Інвіртовані рядки  матриці A");
            int[,] invertRow = ReverseRow(transArr);
            ShowArray(invertRow);
            Console.WriteLine("Поміняні місцями перший та останній рядоки");
            int[,] swapRow = SwapRows(invertRow);
            ShowArray(swapRow);
        }

        public static void ShowArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        public static int[,] TransArray(int[,] arr)
        {

            //    int tmp;

            int[,] rez = new int[arr.GetLength(0), arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    rez[i, j] = arr[j, i];

                }
            }
            return rez;

            //   int tmp;
            //   for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //      for (int j = 0; j < arr.GetLength(1); j++)
            //      {
            //       tmp = arr[j, i];
            //      arr[j, i] = arr[i,j];
            //      arr[i, j] = tmp;

            //    }
            //  }
            //  return arr;
        }

        public static int[,] ReverseRow(int[,] arr)
        {
            int tmp = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0, p = arr.GetLength(0) - 1; p >= arr.GetLength(0) / 2 && j <= arr.GetLength(0) / 2; j++, p--)
                {
                    tmp = arr[i, p];
                    arr[i, p] = arr[i, j];
                    arr[i, j] = tmp;
                }
            }
            return arr;
        }


        public static int[,] SwapRows(int[,] arr)
        {
            int tmp;

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                tmp = arr[0, j];
                arr[0, j] = arr[arr.GetLength(0) - 1, j];
                arr[arr.GetLength(0) - 1, j] = tmp;
            }

            return arr;
        }
    }
}
