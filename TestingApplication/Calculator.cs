using System;
using System.Collections.Generic;
using System.Text;

namespace TestingApplication
{
    public class Calculator
  
    {
        public int Add(int Num1, int Num2)
        {

            return Num1 + Num2;

        }

        public int Sub(int Num1, int Num2)
        {
            return Num1 - Num2;
        }

        public int Multiplication(int Num1, int Num2)
        {
            return Num1 * Num2;
        }

        public int Division(int Num1, int Num2)
        {
            if (Num2 == 0)
                return 0;
            return Num1 / Num2;
        }
    }
}
