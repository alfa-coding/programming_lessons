using System;

namespace Conditionals
{
    public class If_Elif_Else_Statements
    {
        public static bool ExElifElse1()
        {
            int numA = 8;
            int numB = 13;

            if (numA > numB)
            {
                numA = 1;
            }
            else if (numB < numA)
            {
                numA = -1;
            }
            else if (numA == numB)
            {
                numA = 0;
            }
          
            return false;

        }
    }
}
