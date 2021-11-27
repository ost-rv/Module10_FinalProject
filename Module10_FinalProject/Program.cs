using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10_FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator calculator = new Calculator(new Logger());
            int a = 0;
            int b = 0;
            bool mustExit;

            while (true)
            {
                //Ввод
                while (true)
                {
                    a = calculator.EnterNumber("a", out mustExit);
                    if (mustExit)
                        return;

                    b = calculator.EnterNumber("b", out mustExit);
                    if (mustExit)
                        return;

                    calculator.Sum(a, b);

                }

            }
        }


    }
}
