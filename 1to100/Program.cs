using System;
namespace _1to100
{
    //гра вгадай число від 1 до 100, по черзі гравці вводять число, 
    //якщо число більше або менше то виводиться повідомлення чи загадане число менше за n чи більше,
    //якщо число вгадано то виводиться повідомлення про перемогу
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введіть число 1-й гравець: ");
                int p1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.Write("Введіть число 2-й гравець: ");
                int p2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                int guess1 = 0, guess2 = 0;
                while (guess1 != p2 && guess2 != p1)
                {
                    Console.Write("1-й гравець, введіть число: ");
                    guess1 = Convert.ToInt32(Console.ReadLine());
                    if (guess1 < p2)
                    {
                        Console.WriteLine("Загадане число більше за " + guess1);
                    }
                    else if (guess1 > p2)
                    {
                        Console.WriteLine("Загадане число менше за " + guess1);
                    }
                    else
                    {
                        Console.WriteLine("1-й гравець вгадав число!");
                        break;
                    }
                    Console.Write("2-й гравець, введіть число: ");
                    guess2 = Convert.ToInt32(Console.ReadLine());
                    if (guess2 < p1)
                    {
                        Console.WriteLine("Загадане число більше за " + guess2);
                    }
                    else if (guess2 > p1)
                    {
                        Console.WriteLine("Загадане число менше за " + guess2);
                    }
                    else
                    {
                        Console.WriteLine("2-й гравець вгадав число!");
                        break;
                    }
                }
                Console.Write("Продовжити? (1 - так, 0 - ні): "); byte ans = Convert.ToByte(Console.ReadLine());
                if (ans == 0)
                {
                    break;
                }
            }

        }
    }
}
