using System;

namespace tastCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит два числа. Вывести на экран большее
            Console.WriteLine("Enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber> secondNumber)
            {
                Console.WriteLine("Bigger is:"+firstNumber);
            }
            else
            {
                Console.WriteLine("Bigger is:" + secondNumber);
            }
            Console.ReadKey();
        }
    }
}
