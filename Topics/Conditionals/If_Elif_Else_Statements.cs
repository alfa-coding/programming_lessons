using System;

namespace Conditionals
{
    public class If_Elif_Else_Statements
    {
        public static bool ExElifElse1()
        {
            int numA = 8;
            int numB = 13;

            if (numA == numB || numA > numB && numB < numA)
            {
                return false;
            }
            else if (numA == numB || numA < numB && numB > numA)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
