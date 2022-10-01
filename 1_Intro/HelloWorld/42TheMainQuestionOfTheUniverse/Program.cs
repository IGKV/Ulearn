namespace TheUniverse
{
    class Program
    {
        public static void Main()
        {
            Print(GetSquare(42));
        }
        public static int GetSquare(int a)
        {
            return a * a; // a = a*a
}
        static void Print(int b)
        {
            Console.WriteLine(b);
        }
    }

}

