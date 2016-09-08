using System;

namespace _01_Calculator
{
    public class Calculator
    {

        public static int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        public static int Subtract(int v1, int v2)
        {
            return v1 - v2;
        }

        public static int Sum(int[] numbers)
        {
            int numout = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numout = numout + numbers[i];
            };
            return numout;
        }

        public static int Multiply(int[] numbers)
        {
            int numout = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                numout = numout * numbers[i];
            };
            return numout;
        }

        public static int Power(int v1, int v2)
        {
            int numout = v1;

            for (int i = 0; i < (v2-1); i++)
            {
                numout = numout * v1;
            }
            if (v2 == 0)
            {
                return 1;
            }
            else
            {
                return numout;

            }
        }

        public static int Factorial(int v)
        {
            int numout = v;
            for (int i = v-1; i >= 1; i--)
            {
                numout = numout * i; 
            }
            if (v == 0)
            {
                return 1;
            }
            else
                return numout;
        }
    }
}

