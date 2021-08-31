using System;
using System.Linq;

namespace Calculator_SolbegSoft_
{
    class Solution
    {

        public  static double result = 0;
        static void MainInfo()
        {
            Console.WriteLine("-- + Operation summation \n" +
                              "-- - Operation substraction \n" +
                              "-- * Operation multiply \n" +
                              "-- / Operation division \n" +
                              "-- Enter С, to clear the console \n" +
                              "-- Enter E, to escape from app \n");
        }

        static void Main(string[] args)
        {
            MainInfo();
            StartProgram();
        }

        static void StartProgram()
        {
            var input = "";
            do
            {
                try
                {
                    char[] сharList = { '+', '-', '*', '/', 'C', 'E' };
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
                catch(Exception)
                {
                    Console.WriteLine("Произошла ошибка, попробуйте снова!");
                }
               
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
                    if (firsNumb == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя");
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
