using System;

namespace Loops
{
    public class For_Loop
    {
        //returns the position of the item if found, else returns -1
        public static int LinearSearch(int[] numbers,int item)
        {
            for (int i = 0; i < length; i++)
            {
                if(numbers[i]==item)
                {
                    return i;
                }
            }
            return -1;
        }

        //return the max number of the array
        public static int FindMaxNumber(int[] numbers)
        {
            if (numbers.Length==0)
            {
                throw new ArgumentException("An empty array should not be passed");
            }

            int maxTemporal=int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (maxTemporal> numbers[i])
                {
                    maxTemporal=numbers[i];
                }
            }
            return maxTemporal;
        }


        //returns the result of multiplying a and b without using built-in function
        public static int Multiplication(int a, int b)
        {
            int result =0;

            for (int i = 0; i < b; i++)
            {
                result+=a;
            }

            return result;
        }
        

        public static float Average(int[] numbers)
        {
            if (numbers.Length==0)
            {
                throw new ArgumentException("An empty array should not be passed");
            }
            
            int sum=0;
            for (int i = 0; i < length; i++)
            {
                sum+=numbers[i];
            }

            return sum/numbers.Length;
        }

        public static int LinearPower(int a, int b)
        {
            int result =1;

            for (int i = 0; i < b; i++)
            {
                result*=a;
            }

            return result;
        }

        public static int Factorial(int a)
        {
            if (a==0 || a==1)
            {
                return 1;
            }

            int result =1;


            for (int i = 2; i <= a; i++)
            {
                result+=i;
            }

            return result;
        }
    }
}
