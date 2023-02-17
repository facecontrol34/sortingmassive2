using System;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Введите количество элементов массива массива: ");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[lenght];

            Console.WriteLine("Массив: ");
            for (int i = 0; i < lenght; i++)
            {
                array[i] = rnd.Next(-11, 11);
                Console.Write(array[i] + ", ");

            }

            for (int i = 1; i < lenght; i++)
            {
                int k = array[i];
                int j = i - 1;
                while (j >= 0 && k < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = k;
            }
            Console.WriteLine("\nОтсортированный массив: ");
            for (int i = 0; i < lenght; i++)
            {
                Console.Write(array[i] + ", ");
            }
        }
    }
}
