using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string stroka = Console.ReadLine();
        Ispalindrom(stroka);
    }
    public static void Ispalindrom(string stroka)
    {
        string cleanStr = new string(stroka.Where(char.IsLetterOrDigit).ToArray());

        cleanStr = cleanStr.ToLower();

        char[] characters = cleanStr.ToCharArray();
        Array.Reverse(characters);
        string backwards = new string(characters);

        if (backwards == cleanStr)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
