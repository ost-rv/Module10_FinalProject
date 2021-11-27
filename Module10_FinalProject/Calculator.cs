using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10_FinalProject
{
    public class Calculator : ICalculator
    {

        public ILogger Logger { get; }
        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        public void Sum(int a, int b)
        {
            Logger.Event($"{a} + {b} = {a+b}");
        }

        public int EnterNumber(string nameArgumet, out bool flagExit)
        {
            int result = 0;
            flagExit = false;
            //Ввод
            while (true)
            {
                Console.Write($"Введите аргумент \"{nameArgumet}\" (для выхода введите exit):");
                try
                {
                    string enterValue = Console.ReadLine();
                    if (enterValue.ToLower() == "exit")
                    {
                        result = 0;
                        flagExit = true;
                        break;
                    }
                    result = Convert.ToInt32(enterValue);
                    break;
                }
                catch (FormatException ex)
                {
                    Logger.Error(ex.Message);
                    continue;
                }
                catch (Exception ex)
                {
                    Logger.Error(ex.Message);
                    continue;
                }
            }
            return result;
        }
    }
}
