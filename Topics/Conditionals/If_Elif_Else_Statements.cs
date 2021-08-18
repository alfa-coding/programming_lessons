using System;

namespace Conditionals
{
    public class If_Elif_Else_Statements
    {
        public static int ExElifElse1()
        {
            int numA = 8;
            int numB = 13;

            if (numA > numB)
            {
                return 1;
            }
            else
            {
                if (numA < numB)
                {
                    return -1;
                }
                return 0;
            }
           
            

        }


    }
}
