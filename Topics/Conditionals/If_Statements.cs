using System;

namespace Conditionals
{
 
    public class If_Statements
    {
          /*
          *  a | b | result a && b
          *  0   0          0
          *  0   1          0
          *  1   0          0
          *  1   1          1
          */
        public static bool ExAnd()
        {
            bool isSunny = false;
            bool isWeekend = true;
            bool imTravelling = isSunny && isWeekend;

            if (imTravelling)
            {
                return true;
            }
            return false;
        }

        /*
        *  a | b | result a || b
        *  0   0          0
        *  0   1          1
        *  1   0          1
        *  1   1          1
        */
        public static bool ExOr()
        {

            bool imHungry = true;
            bool isRaining = false;
            bool stayAtHome = imHungry || isRaining;

            if (stayAtHome)
            {
                return true;
            }
            return false;
        }

        /*
        *  a |  result !a  
        *  0           1
        *  1           0
        */
        public static bool ExNot()
        {
            bool isRaining = true;

            if (!isRaining)
            {
                return true;
            }
            return false;
        }
    }
}
