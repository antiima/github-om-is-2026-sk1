string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"  
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a" )
{
    // Vymazání konzole
    Console.Clear();
    
    // Hlavička programu
    Console.WriteLine("*************************************");
    Console.WriteLine("****** Vykreslování trojúhelníků *******");
    Console.WriteLine("*************************************");
    Console.WriteLine("*********** Ondřej Marušák **********");
    Console.WriteLine("*************************************");
    Console.WriteLine();
    Console.WriteLine();

    // Načtení šířky obrazce
    // Console.Write("Zadejte šířku obrazce (celé kladné číslo):");
    // int width;
    // while(!int.TryParse(Console.ReadLine(), out width) || width <= 0) {
    //     Console.ForegroundColor = ConsoleColor.Red;
    //     Console.Write("Nezadali jste celé kladné číslo. Zadejte výšku znovu: ");
    //     Console.ResetColor();
    //}

    // Načtení výšky obrazce
    Console.Write("Zadejte výšku obrazce (celé kladné číslo):");
    int height;
    
    while(!int.TryParse(Console.ReadLine(), out height) || height <= 0) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé kladné číslo. Zadejte výšku znovu: ");
        Console.ResetColor();
    }
int width = height;

    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Výška: {height};");
    Console.WriteLine("=============================");
    Console.WriteLine();
    Console.WriteLine();

    // Zde budeme pokračovat konkrétním algoritmem
    //Jádro vykreslovacího algoritmu
    //Vnější cyklus, který nám bude hlídat počet řádků (shora dolů)
    for(int i = 1; i <= height; i++) //Operátor i++ == i +1, i-- == i - 1
{    
    {
        if (i % 2 == 0)
        {Console.ForegroundColor = ConsoleColor.Cyan;}
        else
        {Console.ForegroundColor = ConsoleColor.Magenta;}

    }
        //vnitřní cyklus, který nám bude hlídat počet sloupců (zleva doprava)
        for(int j = 1; j <= width; j++ ) 
        {if (j <= i)
        
            
           
            {Console.Write("* ");
            //System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); // Efekt animace vykreslování
            }
            else
            {Console.Write("  ");
            }        
        }
        
        Console.ResetColor();
        Console.WriteLine();
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