using System;
using System.Collections.Generic;
using System.Linq;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<int> digitNumbersTicket = new List<int>();
                Console.WriteLine("Enter your ticket number!");
                var numberTicket = Console.ReadLine();

                while (numberTicket.Length < 4 || numberTicket.Length > 8 || !numberTicket.All(char.IsDigit))
                {
                    Console.WriteLine("You have entered your ticket number incorrectly! Please enter again!");
                    numberTicket = Console.ReadLine();
                }

                foreach (var number in numberTicket)
                {
                    digitNumbersTicket.Add(Int32.Parse(number.ToString()));
                }

                int firstHalf = 0;
                int secondHalf = 0;
                for (var i = 0; i < digitNumbersTicket.Count; i++)
                {
                    if (i < digitNumbersTicket.Count / 2)
                    {
                        firstHalf += digitNumbersTicket[i];
                    }
                    else
                        secondHalf += digitNumbersTicket[i];
                }
                if (firstHalf == secondHalf)
                {
                    Console.WriteLine("Your ticket is lucky!");
                }
                else
                    Console.WriteLine("Unfortunately you were unlucky!");
            }
        }
    }
}
