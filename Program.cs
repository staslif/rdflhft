using System;
using System.Diagnostics;

internal class Program
{
    static void Main(string[] args)
    {
        static void Main()
        {
            Random rand = new Random();
            Console.WriteLine("введите кол-во элементов до 10000");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 10000)//проверка
            {
                Console.WriteLine("кол-во элементов  до 10000");
                return;
            }
            int[] mass = new int[n];//массив
            for (int i = 0; i < n; i++)//заполнение массива
            {
                mass[i] = rand.Next(1, 101);
            }
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 10; j < n; j++)
                {
                    int sum = mass[i] * mass[i] + mass[j] * mass[j];

                    if (sum > max)
                    {
                        max = sum;
                    }
                }
            }
            Console.WriteLine("сумма квадратов = " + max);
        }
    }
}
