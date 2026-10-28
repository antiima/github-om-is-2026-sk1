﻿string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"  
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a" )
{
    // Vymazání konzole
    Console.Clear();
    
    // Hlavička programu
    Console.WriteLine("*************************************");
    Console.WriteLine("************ Výpis řady *************");
    Console.WriteLine("*************************************");
    Console.WriteLine("*********** Tomáš Žižka *************");
    Console.WriteLine("*************************************");
    Console.WriteLine();
    Console.WriteLine();

    // Vstup počáteční hodnoty - špatně řešený
    // Console.Write("Zadejte první číslo řady: ");
    // int first = int.Parse(Console.ReadLine());
    
    // Načtení počáteční hodnoty řady
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while(!int.TryParse(Console.ReadLine(), out first)) {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }

    // Načtení koncové hodnoty řady
    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while(!int.TryParse(Console.ReadLine(), out last)) {
        Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo řady znovu: ");
    }

    // Načtení diference s kontrolou kladného nenulového čísla
    Console.Write("Zadejte diferenci (kladné celé číslo): ");
    int step;
    while(!int.TryParse(Console.ReadLine(), out step) || step <= 0 ) {
        Console.Write("Nezadali jste kladné celé číslo. Zadejte diferenci znovu: ");
    }

    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("=============================");
    // Console.WriteLine($"První číslo: {first}");
    // Console.WriteLine($"Poslední číslo: {last}");
    // Console.WriteLine($"Diference (krok): {step}");
    Console.WriteLine($"První číslo: {first}; Poslední číslo: {last}; Diference (krok): {step}");
    Console.WriteLine("=============================");
    Console.WriteLine();
    Console.WriteLine();

    // Výpis řady
    Console.WriteLine("Výpis číselné řady:");
    if(first <= last)
    {
        int current = first;
        while(current <= last)
        {
           Console.WriteLine(current);
           // Console.Write($"{current}; ");
           // current = current + step;
           // stručnější zápis přechozího řádku
           current += step;  
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("První číslo je větší než poslední.");
        Console.WriteLine("Tento program umí vypsat vzestupnou řadu (od menšího k věšímu)!");
    }

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stislněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}