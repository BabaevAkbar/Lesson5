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
        static void Main()
        {
            // Задание 1. Определить число на полиндром
            int[] array = {121, 234, 1221, 456, 989};
            NumPalindrome(array);

            
            
        }
    }
}