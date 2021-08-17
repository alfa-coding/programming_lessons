using System;

namespace Conditionals
{
    public class If_Else_Statements
    {
        public static bool ExIfElse1()
        {
            bool isSummer = true;
            bool sheHasMoney = false;

            if (isSummer && sheHasMoney)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        //retuns true when the number is even 
        public static bool ExIfElse2()
        {
            int numA = 80;

            if (numA % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //testing mutual exclusivity
        public static bool ExIfElse3()
        {
            int numA = 4;

            if (numA < 5)//enter here and doesnt continue to else. Result = false because numA != 7
            {
                numA = 10;
            }
            else
            {
                numA = 7;
            }
            return numA == 7;
        }
    }
}
