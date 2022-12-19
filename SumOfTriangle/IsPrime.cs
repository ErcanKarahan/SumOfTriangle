﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTriangle
{
    public class IsPrime
    {

      public  static bool IsPrimes(int number)
        {
            // Test whether the parameter is a prime number.
          // Number mod 1 eşitse 0 a
            if ((number & 1) == 0)
            {
                //number eşitse 2 ye
                if (number == 2)
                {
                    return true;
                }
                return false;
            }

            for (int i = 3; (i * i) <= number; i += 2)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            return number != 1;
        }


    }
}
