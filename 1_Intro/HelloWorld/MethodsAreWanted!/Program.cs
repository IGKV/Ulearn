namespace methots
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
        }
        static string GetLastHalf(string text)
        {
            return text.Substring(text.Length / 2).Replace(" ", "");
             
        }

    }
}