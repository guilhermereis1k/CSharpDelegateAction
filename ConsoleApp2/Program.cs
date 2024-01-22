using System.Collections.Generic;

internal class Program
{
    delegate void StringDelegate(string str);

    static void Main()
    {
        Console.WriteLine("Digite seu nome (digite 'N' para encerrar): ");

        List<string> list = new List<string>();

        while (true)
        {
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            if (name.ToLower() == "n")
            {
                break;
            }

            list.Add(name);
        }

        StringDelegate printNames = delegate(string x) { Console.WriteLine(x + " é um nome fei"); };


        foreach (var name in list)
        {
            printNames(name);
        }
    }
}