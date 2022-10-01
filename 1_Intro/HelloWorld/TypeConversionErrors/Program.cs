using System;

namespace Errors
{
    class Program
    {
        static void Main()
        {
            double pi = Math.PI;
            long tenThousand = 10000L;
            float tenThousandPi = (float)(pi * tenThousand);
            int roundedTenThousandPi = (int)tenThousandPi;
            int integerPartOfTenThousandPi = (int)Math.Round(tenThousandPi);
            Console.WriteLine(integerPartOfTenThousandPi);
            Console.WriteLine(roundedTenThousandPi);
        }
    }
}