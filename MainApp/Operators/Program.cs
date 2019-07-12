using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            //simpleSum();
            //checkAnswer();
            //checkBiggerOrSmaller();
            checkWIthOperator();
        }

        static int getSum()
        {
            Console.WriteLine("Введите первое число:");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            int sum = firstNum + secondNum;

            return sum;
        }

        static string getOperator()
        {
            Console.WriteLine("Введите оператор:");
            string operation = Console.ReadLine();

            return operation;
        }

        static void simpleSum()
        {

            int result = getSum();

            Console.WriteLine($"Сумма: {result}");
            Console.ReadLine();
        }

        static void checkAnswer()
        {
            int result = getSum();

            Console.WriteLine("Введите ваш ответ: ");
            int userAnswer = Convert.ToInt32(Console.ReadLine());

            if (userAnswer == result)
            {
                Console.WriteLine("Правильно!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Неправильно! Правильный ответ: {result}");
                Console.ReadLine();
            }
        }

        static void checkBiggerOrSmaller()
        {
            int result = getSum();

            Console.WriteLine("Введите ваш ответ: ");
            int userAnswer = Convert.ToInt32(Console.ReadLine());

            if (userAnswer == result)
            {
                Console.WriteLine("Правильно!");
                Console.ReadLine();
            }
            else if (userAnswer > result)
            {
                Console.WriteLine("Неправильно! Ваше число должно быть меньше.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Неправильно! Ваше число должно быть больше.");
                Console.ReadLine();
            }
        }

        static void checkWIthOperator()
        {
            int result;

            Console.WriteLine("Введите первое число:");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            string oper = getOperator();

            if (oper == "+")
            {
                result = firstNum + secondNum;
            }
            else if (oper == "-")
            {
                result = firstNum - secondNum;
            }
            else
            {
                result = 0;
                Console.WriteLine("Таких операторов мы не знаем.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Введите ваш ответ: ");
            int userAnswer = Convert.ToInt32(Console.ReadLine());

            if (userAnswer == result)
            {
                Console.WriteLine("Правильно!");
                Console.ReadLine();
            }
            else if (userAnswer > result)
            {
                Console.WriteLine("Неправильно! Ваше число должно быть меньше.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Неправильно! Ваше число должно быть больше.");
                Console.ReadLine();
            }
        }
    }
}
