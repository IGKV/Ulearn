using System.Data;

internal class Program
{
    static string who = "class";

    static void Mixed()
    {
        Console.Write(who + " ");
        string who = "Mixed";
        Console.Write(who);
    }
    static void Main()
    {
        Mixed();
    }
}