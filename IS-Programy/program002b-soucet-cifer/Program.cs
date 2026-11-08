﻿string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();

    Console.WriteLine("*************************************");
    Console.WriteLine("************ Ciferný součet *************");
    Console.WriteLine("*************************************");
    Console.WriteLine("********* Ondřej Marušák *********");
    Console.WriteLine("************ Zadávejte cifry čísla zleva doprava. ************");
    Console.WriteLine("************ Pokud číslo další cifru nemá, zadejte k. ************");
    Console.WriteLine();

    int sum = 0;
    int product = 1;           
    int digit;          
    string cislo = "";  

     while (true)
    {
        Console.Write("Zadejte cifru nebo k: ");
        string vstup = Console.ReadLine()?.Trim().ToLower() ?? "";

        if (vstup == "k")
        {
            break;
        }

        if (vstup.Length == 1 && int.TryParse(vstup, out digit))
        {
            sum = sum + digit;
            product = product * digit;
            cislo = cislo + vstup;
        }
        else
        {
            Console.WriteLine("Zadejte jednu cifru 0-9 nebo k.");
        }
    }

    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Zadané číslo: {cislo}");
    Console.WriteLine($"Součet číslic: {sum}");
    Console.WriteLine($"Součin číslic: {product}");
    Console.WriteLine("=============================");
    Console.WriteLine();

    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter.");
    Console.WriteLine("Jakoukoli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}