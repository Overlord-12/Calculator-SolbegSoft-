using System;
using System.Linq;

namespace Calculator_SolbegSoft_
{
    class Solution
    {
        static void MainInfo()
        {
            Console.WriteLine("-- + Операция сложения  \n" +
                            "-- - Операция вычитания \n" +
                            "-- * Операция умножения \n" +
                            "-- / Операция деления   \n" +
                            "-- Введите С, чтобы очистить консоль    \n" +
                            "-- Введите E, чтобы выйти из приложения \n");
        }

        static void Main(string[] args)
        {
            MainInfo();
            StartProgram();
        }


        static void StartProgram()
        {
            do
            {
                char[] сharList = { '+', '-', '*', '/', 'C', 'E' };
                var input = Console.ReadLine().Replace("=", "");
                char oper = сharList.First(input.Contains);
                if (oper == 'C' || oper == 'С')
                {
                    Console.Clear();
                    MainInfo();
                    continue;
                }     
                if (oper == 'E' || oper == 'E') break;
                double[] nums = input.Split(сharList.ToArray())
                    .Select(double.Parse)
                    .ToArray();    
                Console.WriteLine(Calculation(nums[0], nums[1], oper));
            }
            while (true);
             
        }
        

        static double Calculation(double firsNumb,double secondNumb, char oper)
        {
            switch (oper)
            {
                case '+':
                    return firsNumb + secondNumb;
                case '-':
                    return firsNumb - secondNumb;
                case '*':
                    return firsNumb * secondNumb;
                case '/':
                    return firsNumb / secondNumb;
                default:
                    Console.WriteLine("Ошибка");
                    return 0;   
            }
             

        }




    }
}
