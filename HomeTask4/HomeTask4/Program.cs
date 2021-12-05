using System;
using System.Collections.Generic;


namespace HomeTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заполняем массив
            Console.WriteLine("Укажите длинну массива");
            int len = int.Parse(Console.ReadLine());
            Random rand = new Random();
            List<double> array = new List<double>();
            for (int i = 0; i < len; i++) {
                array.Add((double)Math.Round((double)rand.NextDouble() * 2.0 -1.0 , 2));
            }
            double minElement = array[0];
            int minElementIndex;
            Console.WriteLine("----------------------------------------------");
            // часть 1
            int negativeIndex = array.FindIndex(el => el < 0);
            foreach (double el in array) {
                if (Math.Abs(minElement) > Math.Abs(el)) {
                    minElement = el;
                }
                Console.WriteLine(el);
            }
            Console.WriteLine("----------------------------------------------");
            minElementIndex = array.LastIndexOf(minElement);

            Console.WriteLine($"Минимальный по модулю элемент массива: {minElement}, на позиции: {minElementIndex}");
            
            Console.WriteLine("----------------------------------------------");
            // часть 2
            Console.WriteLine($"Первый отрицательный элемент на позиции: {negativeIndex}");
            double sum = 0;
            for (int i = negativeIndex + 1 ; i < array.Count; i++) {
                sum += Math.Abs(array[i]);
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Сумма модулей элементов массива после первого отрицательного: {sum}");
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Введиет значение интервала a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введиет значение интервала B");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------");
            // часть 3

            for (int i=0; i < array.Count; i++)
            {
                if (array[i] >= a && array[i] <= b)
                {
                    array.Remove(array[i]);
                    array.Add(0);
                }
            }
            foreach (double el in array) {

                Console.WriteLine(el);
            }
        }
    }
}

