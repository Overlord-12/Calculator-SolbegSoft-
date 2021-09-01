using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_SolbegSoft_
{
    class ExecutionLogic
    {

        private static double result = 0;
        private static readonly char[] сharList = { '+', '-', '*', '/', 'C', 'E' };
       private static void MainInfo()
       {
            Console.WriteLine("-- + Operation summation \n" +
                              "-- - Operation substraction \n" +
                              "-- * Operation multiply \n" +
                              "-- / Operation division \n" +
                              "-- Enter С, to clear the console \n" +
                              "-- Enter E, to escape from app \n");
       }
       public static void StartProgram()
        {
            MainInfo();
            var input = "";
            do
            {
                try
                {
                    string userExample = Console.ReadLine();
                    if (result != 0 && !char.IsDigit(userExample[0])) input = result + userExample;
                    else input = userExample;
                    char oper = сharList.First(input.Contains);
                    if (oper == 'C' || oper == 'С')
                    {
                        Console.Clear();
                        MainInfo();
                        result = 0;
                        continue;
                    }
                    if (oper == 'E' || oper == 'E') break;
                    double[] nums = input.Split(сharList.ToArray())
                        .Select(double.Parse)
                        .ToArray();

                    result = Calculation(nums[0], nums[1], oper);
                    Console.WriteLine(result);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error, please try again!");
                }
            }
            while (true);

        }

       public static double Calculation(double firsNumb, double secondNumb, char oper)
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
                    if (secondNumb == 0)
                    {
                        Console.WriteLine("You can't divide by zero");
                        return 0;
                    }
                    return firsNumb / secondNumb;
                default:
                    Console.WriteLine("Ошибка");
                    return 0;
            }
        }

    }
}
