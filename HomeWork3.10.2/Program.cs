using System;

namespace HomeWork3._10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите количество карт на руках");
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Вводите карты от 2 до туза, для ввода вальта используйте - j, дамы - q, король - k, туза - t");
            //int j = 11;
            //int q = 12;
            //int k = 13;
            //int t = 1;
            int cardSum = 0;
            for (int i = 0; i != quantity; i++)
            {
                string numCard = Console.ReadLine();
                
                switch (numCard)
                {

                    case "2":
                        Console.WriteLine("Введена карта номиналом 2");
                        cardSum = cardSum + 2;
                        break;
                    case "3":
                        Console.WriteLine("Введена карта номиналом 3");
                        cardSum = cardSum + 3;
                        break;
                    case "4":
                        Console.WriteLine("Введена карта номиналом 4");
                        cardSum = cardSum + 4;
                        break;
                    case "5":
                        Console.WriteLine("Введена карта номиналом 5");
                        cardSum = cardSum + 5;
                        break;
                    case "6":
                        Console.WriteLine("Введена карта номиналом 6");
                        cardSum = cardSum + 6;
                        break;
                    case "7":
                        Console.WriteLine("Введена карта номиналом 7");
                        cardSum = cardSum + 7;
                        break;
                    case "8":
                        Console.WriteLine("Введена карта номиналом 8");
                        cardSum = cardSum + 8;
                        break;
                    case "9":
                        Console.WriteLine("Введена карта номиналом 9");
                        cardSum = cardSum + 9;
                        break;
                    case "10":
                        Console.WriteLine("Введена карта номиналом 10");
                        cardSum = cardSum + 10;
                        break;
                    case "j":
                        Console.WriteLine("Введена карта номиналом ВАЛЕТ");
                        cardSum = cardSum + 11;
                        break;
                    case "q":
                        Console.WriteLine("Введена карта номиналом ДАМА");
                        cardSum = cardSum + 12;
                        break;
                    case "k":
                        Console.WriteLine("Введена карта номиналом КОРОЛЬ");
                        cardSum = cardSum + 13;
                        break;
                    case "t":
                        Console.WriteLine("Введена карта номиналом ТУЗ");
                        cardSum = cardSum + 1;
                        break;

                }
                Console.WriteLine($"сумма карт {cardSum}");
                


            }
            if (cardSum > 21)
            {
                Console.WriteLine("Перебор, вы проиграли");
            }
            else if (cardSum < 21)
            {
                Console.WriteLine("Недобор вы проиграли");

            }
            else
            {
                Console.WriteLine("ДВАДЦАТЬ ОДНО ВЫ ПОБЕДИЛИ");
            }

        }
    }
}
