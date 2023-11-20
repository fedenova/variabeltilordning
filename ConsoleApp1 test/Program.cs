// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {

        WriteToConsole();
        int a = 69;
        int b = 420;
        int sum = TallSummerer(a, b);

        Console.WriteLine("Tall A = " + a);
        Console.WriteLine("Tall B = " + b);
        Console.WriteLine("sum = " + sum);
        
        Console.ReadLine();
    }

    string tekst = "Denne metoden returnerer ingenting";

    public string ReturnString()
    {
        return tekst;
    }

    public static int ReturnWholeNumber()
    {
        return 5;
    }

    public static int TallSummerer(int tall1, int tall2)
    {
        return tall1 + tall2;
    }

    public static void WriteToConsole()
    {
        Console.WriteLine("Denne metoden returnerer ingenting");


    }
}

