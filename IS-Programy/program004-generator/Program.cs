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
    Console.WriteLine("******* Generátor psoudonáhodných čísel ******");
    Console.WriteLine("*************************************");
    Console.WriteLine("*********** Ondřej Marušák **********");
    Console.WriteLine("*************************************");
    Console.WriteLine();
    Console.WriteLine();

    // Počet generovaných čísel (větší než 0)
    Console.Write("Zadejte počet generovaných čísel (celé kladné číslo):");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n) || n <= 0){
        Console.Write("Nezadali jste celé kladné číslo. Zadejte počet čísel znovu: ");
    }

    // Načtení doní meze
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while(!int.TryParse(Console.ReadLine(), out lowerBound)) {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

// Načtení horní meze
    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;
    while(!int.TryParse(Console.ReadLine(), out upperBound)|| upperBound <= lowerBound) {
        Console.Write("Nezadali jste celé číslo nebo horní mez není větší než dolní mez. Zadejte horní mez znovu: ");
    }



    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Počet generovaných čísel: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound}");
    Console.WriteLine("=============================");
    Console.WriteLine();
    Console.WriteLine();

    // Zde budeme pokračovat konkrétním algoritmem
    
//Deklarace a alokace pole v patměti
    int[] myRandNumbs = new int[n];

//Inicializace generátoru náhodnýchh čísel
Random myRandNumb = new Random();
//Random myRandNumb = new Random(50);

//Generování náhodných čísel a jejich uložení do pole
Console.WriteLine("Vygenerovaná pseudonáhodná čísla:");
for(int i = 0; i < myRandNumbs.Length; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);   
        Console.Write($"{myRandNumbs[i]}; ");
    }

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}