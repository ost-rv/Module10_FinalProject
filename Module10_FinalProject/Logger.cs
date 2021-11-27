using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10_FinalProject
{
    public class Logger : ILogger
    {
        public void Error(string message)
        {
            ConsoleColor foregroundColorBefore = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = foregroundColorBefore;
        }

        public void Event(string message)
        {
            ConsoleColor foregroundColorBefore = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = foregroundColorBefore;
        }
    }
}
