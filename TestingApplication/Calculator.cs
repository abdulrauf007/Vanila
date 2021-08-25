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

        public double Add(double Num1, double Num2)
        {

            return Num1 + Num2;

        }

        

        public float Add(float Num1, float Num2)
        {

            return Num1 + Num2;

        }

        public decimal Add(decimal Num1, decimal Num2)
        {

            return Num1 + Num2;

        }

        public long Add(long Num1, long Num2)
        {
            return Num1 - Num2;
        }


        public int Sub(int Num1, int Num2)
        {
            return Num1 - Num2;
        }

        public double Sub(double Num1, double Num2)
        {
            return Num1 - Num2;
        }

        public float Sub(float Num1, float Num2)
        {
            return Num1 - Num2;
        }

         public decimal Sub(decimal Num1, decimal Num2)
        {
            return Num1 - Num2;
        }

        public long Sub(long Num1, long Num2)
        {
            return Num1 - Num2;
        }

        public int Multiplication(int Num1, int Num2)
        {
            return Num1 * Num2;
        }

        public double Multiplication(double Num1, double Num2)
        {
            return Num1 * Num2;
        }

        public float Multiplication(float Num1, float Num2)
        {
            return Num1 * Num2;
        }

        public decimal Multiplication(decimal Num1, decimal Num2)
        {
            return Num1 * Num2;
        }

        public long Multiplication(long Num1, long Num2)
        {
            return Num1 * Num2;
        }
        public int Division(int Num1, int Num2)
        {
            if (Num2 == 0)
                return 0;
            return Num1 / Num2;
        }

        public double Division(double Num1, double Num2)
        {
            if (Num2 == 0)
                return 0;
            return Num1 / Num2;
        }

        public decimal Division(decimal Num1, decimal Num2)
        {
            if (Num2 == 0)
                return 0;
            return Num1 / Num2;
        }

        public long Division(long Num1, long Num2)
        {
            if (Num2 == 0)
                return 0;
            return Num1 / Num2;
        }

    }
}
