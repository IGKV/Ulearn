using System.Globalization;

namespace ConvertString
{
    class Program
    {
        static void Main()
        {
            string doublename = "89123.23123";
            double numbe = double.Parse(doublename, CultureInfo.InvariantCulture);
            Console.WriteLine(numbe+1);
        }
    }
}