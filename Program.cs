using System;

namespace MyLesson
{
    class Program
    {
        static void NumPalindrome(int[] array)
        {
            foreach(int a in array)
            {
                if((a / 10) >= 1 && (a / 10) < 10)
                {
                    if(a % 11 == 0)
                    {
                        Console.WriteLine($"Число {a} является палиндромом!");
                    }
                    else
                    {
                        Console.WriteLine($"Число {a} неявляется палиндромом!");
                    }
                }
                else if((a / 100) >= 1 && (a / 100) < 10)
                {
                    int num1 = a / 100;
                    int num2 = (a % 100) / 10;
                    int num3 = a % 10;
                    if(num1 == num3)
                    {
                        Console.WriteLine($"Число {a} является палиндромом!");
                    }
                    else
                    {
                        Console.WriteLine($"Число {a} неявляется палиндромом!");
                    }
                    
                }
                else if((a / 1000) > 0 && (a / 1000) < 10)
                {
                    int num1 = a / 1000;
                    int num2 = (a % 1000) / 100;
                    int num3 = (a % 100) / 10;
                    int num4 = a % 10;
                    if(num1 == num4 && num2 == num3)
                    {
                        Console.WriteLine($"Число {a} является палиндромом!");
                    }
                    else
                    {
                        Console.WriteLine($"Число {a} неявляется палиндромом!");
                    }
                }
            }
        } 

        static int[,] FullArray(int size1,int size2, int rand1, int rand2)
        {
            Random rand = new Random();
            int[,] mac = new int [size1, size2];
            int rowsMac = mac.GetUpperBound(0)+1;
            int columsMac = mac.Length / rowsMac;
            foreach (var i in mac)
            {
                for(int j = 0; j < rowsMac; j++)
                {
                    for (int k = 0; k < columsMac; k++)
                    {
                        int randomNum = rand.Next(rand1, rand2);
                        mac[j, k] = randomNum;
                    }
                }
            }
            return mac;
        }
        static void SumArrayPositive(int[,] array)
        {
            int sum = 0;
            foreach(int i in array)
            {
                if(i >= 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Сумма положительных чисел равен: {sum}");

        }

        static void SumArrayNegative(int[,] array)
        {
            int sum = 0;
            foreach(int i in array)
            {
                if(i < 0)
                {
                    sum -= i;
                }
            }
            Console.WriteLine($"Сумма отрицательных чисел равен: -{sum}");

        }

        static int MaxValue(int[,] a)
        {

            int max = 0;
            int rowsMac = a.GetUpperBound(0)+1;
            int columsMac = a.Length / rowsMac;
            for(int j = 0; j < rowsMac; j++)
            {
                for (int k = 0; k < columsMac; k++)
                {
                    Console.WriteLine(a[j, k]);
                    if(a[j,k] > max)
                    {
                        max = a[j,k];
                    }
                }
            }
            return max;
        }

        static int  MinValue(int[,] a)
        {

            int min = 100;
            int rowsMac = a.GetUpperBound(0)+1;
            int columsMac = a.Length / rowsMac;
            for(int j = 0; j < rowsMac; j++)
            {
                for (int k = 0; k < columsMac; k++)
                {
                    Console.WriteLine(a[j, k]);
                    if(a[j,k] < min)
                    {
                        min = a[j,k];
                    }
                }
            }
            return min;
        }
        static void Main()
        {
            // // Задание 1. Определить число на полиндром
            // int[] array = {121, 234, 1221, 456, 989};
            // NumPalindrome(array);
            
            // // Задание 2. Сумма всех положительных и отрицательных чисел во многомнрном массиве.
            // int[,] a = FullArray(3, 4, -100, 100);            
            // SumArrayPositive(a);
            // SumArrayNegative(a);

            // Задание 3 
            int resultMax = MaxValue(FullArray(3, 4, 0, 100));
            Console.WriteLine($"Максимальная значения {resultMax}");

            int resultMin = MinValue(FullArray(3, 4, 0, 100));
            Console.WriteLine($"Минимальная значения {resultMin}");

            
        }
    }
}