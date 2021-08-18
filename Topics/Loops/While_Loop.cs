using System;

namespace Loops
{
    public class While_Loop
    {
        public static int CountPositiveNumbers(int[] numbers)
        {
            int index = 0;
            int counter = 0;
            while (index < numbers.Length)
            {
                if (numbers[index] > 0)
                {
                    counter++;
                }

                index++;
            }

            return counter;
        }

        public static int BinarySearch(int[] numbers, int item)
        {
            int min = 0;
            int max = numbers.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                //checking whether I've found the number
                if (item == numbers[mid])
                {
                    return ++mid;
                }

                //given that I didnt found it, it should be at the left or right.
                else if (item < numbers[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            //not found
            return -1;
        }

        public static int GCD(int a, int b)
        {
            int r=a%b;

            while (r!=0)
            {
                r=a%b;
                a=b;
                b=r;
            }
            return a;
            
        }
    }
}
