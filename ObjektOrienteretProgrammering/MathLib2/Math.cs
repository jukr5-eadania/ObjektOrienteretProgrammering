using System;

namespace MathLib2
{
    public class Math
    {
        private int number1;
        private int number2;
        private int result;

        public void Addition()
        {
            Console.WriteLine("Enter the first number you want to add toghether");
            number1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the second number you want to add toghether");
            number2 = Convert.ToInt16(Console.ReadLine());
            result = number1 + number2;
            Console.WriteLine(result);
        }

        public void Subraction()
        {
            Console.WriteLine("Enter the first number you want to add toghether");
            number1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the second number you want to add toghether");
            number2 = Convert.ToInt16(Console.ReadLine());
            result = number1 - number2;
            Console.WriteLine(result);
        }

        public void Division()
        {
            Console.WriteLine("Enter the first number you want to add toghether");
            number1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the second number you want to add toghether");
            number2 = Convert.ToInt16(Console.ReadLine());
            result = number1 / number2;
            Console.WriteLine(result);
        }
    }
}
