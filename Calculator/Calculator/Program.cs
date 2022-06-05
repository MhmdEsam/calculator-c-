using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char cal;
            double num1, num2;
        start:
            Console.WriteLine("Choose what you want ( + , - , / , * )");
            cal = Console.ReadLine()[0];


            Console.WriteLine("Enter a numbers");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (cal)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));
                    break;

                case '/':
                    if (num2 == 0.0)
                        Console.WriteLine("Error");
                    else
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));
                    break;
                case '*':
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, (num1 * num2));
                    break;

                default:
                    Console.WriteLine("{0}", cal);
                    break;
            }
            Console.WriteLine("Do you want more calculations? Yes or No If yes, press y If not, press any key ");

            string rst = Console.ReadLine();

            if (rst == "y")
            {
                goto start;
            }
            else
            {

            }
            Console.WriteLine("Thanks press any key to close");
            Console.ReadKey(true);
        }
    }
}
