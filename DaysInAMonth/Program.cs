using System;

namespace DaysInAMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Here you can find out the number of days of any month");
            Console.WriteLine("1. January");
            Console.WriteLine("2. February");
            Console.WriteLine("3. March");
            Console.WriteLine("4. April");
            Console.WriteLine("5. May");
            Console.WriteLine("6. June");
            Console.WriteLine("7. July");
            Console.WriteLine("8. August");
            Console.WriteLine("9. September");
            Console.WriteLine("10. October");
            Console.WriteLine("11. November");
            Console.WriteLine("12. December");
            Console.Write("Enter the ordinal number of the month - ");
            int Month;
            if (!int.TryParse(Console.ReadLine(), out Month))
            {
                Console.WriteLine("Invalid input. The program will be completed");
                return;
            }

            switch (Month)
            {
                case 1:
                    Console.WriteLine("January 31 days");
                    break;

                case 2:
                    Console.WriteLine("Is it a leap year?");
                    Console.WriteLine("Enter '1' or '2'");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    int Answer;
                    if(!int.TryParse(Console.ReadLine(), out Answer))
                    {
                        Console.WriteLine("Incorrect input.The program will be completed");
                        return;
                    }

                    switch (Answer)
                    {
                        case 1:
                            Console.WriteLine("February 29 days");
                            break;
                        case 2:
                            Console.WriteLine("February 28 days");
                            break;
                        default:
                            Console.WriteLine("Incorrect input. The program will be completed");
                            break;
                    }
                    break;

                case 3:
                    Console.WriteLine("March 31 days");
                    break;

                case 4:
                    Console.WriteLine("April 30 days");
                    break;

                case 5:
                    Console.WriteLine("May 31 days");
                    break;

                case 6:
                    Console.WriteLine("June 30 days");
                    break;

                case 7:
                    Console.WriteLine("July 31 days");
                    break;

                case 8:
                    Console.WriteLine("August 31 days");
                    break;

                case 9:
                    Console.WriteLine("September 30 days");
                    break;

                case 10:
                    Console.WriteLine("October 31 days");
                    break;

                case 11:
                    Console.WriteLine("November 30 days");
                    break;

                case 12:
                    Console.WriteLine("December 31 days");
                    break;

                default:
                    Console.WriteLine("Incorrect input. The program will be completed");
                    break;
            }
        }
    }
}
