using System.Xml.Serialization;

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
    Console.WriteLine("** Generátor - max, min, hodiny ***");
    Console.WriteLine("*************************************");
    Console.WriteLine("*********** Ondřej Marušák *************");
    Console.WriteLine("*************************************");
    Console.WriteLine();
    Console.WriteLine();

    // Počet generovaných čísel (větší než nula)
    Console.Write("Zadejte počet generovaných čísel (přirozené číslo): ");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n) || n <= 0) {
        Console.Write("Nezadali jste přirozené číslo. Zadejte počet čísel znovu: ");
    }

    // Načtení dolní meze
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while(!int.TryParse(Console.ReadLine(), out lowerBound)) {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    // Načtení horní meze
    Console.Write("Zadejte horní mez (celé číslo větší nebo rovno hodnotě dolní meze): ");
    int upperBound;
    while(!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound) {
        Console.Write("Nezadali jste celé číslo větší nebo rovno hodnotě dolní meze. Zadejte horní mez znovu: ");
    }

    // Rekapitulace zadaných vstupních hodnot
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Počet čísel: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound};");
    Console.WriteLine("=============================");
    Console.WriteLine();
    Console.WriteLine();

    // Zde budeme pokračovat konkrétním algoritmem
    
    // Deklarace a alokace pole v paměti
    int[] myRandNumbs = new int[n];

    // Inicializace generátoru nahodných čísel
    Random myRandNumb = new Random();
    // Random myRandNumb = new Random(50); 

    // Generování náhodných čísel a jejich uložení do pole
    Console.WriteLine("Vygenerovaná pseudonáhodná čísla: ");
    for(int i = 0; i < myRandNumbs.Length; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write($"{myRandNumbs[i]}; ");
    }

    // Hledání maxima, minima a jejich prvních pozic
    int max = myRandNumbs[0];
    int min = myRandNumbs[0];
    int posMax = 0; // pozice prvního maxima
    int posMin = 0; // pozice prvního minima

    for(int i = 1; i < n; i++)
    {
        // zjišťujeme zda i-tý prvek není větší než aktuální hodnota maxima
        if(myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
            posMax = i;
        }

        // zjišťujeme zda i-tý prvek není menší než aktuální hodnota minima
        if(myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
            posMin = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Pozice prvního maxima: {posMax}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Pozice prvního minima: {posMin}");
    Console.WriteLine("=============================");

//Vykreslení přesýpacích hodin
if (max >= min)
    {
        //Vnější cyklus řídí vykreslování jednotlivých řádků
        for(int i = 0; i < max; i++)
        {
            int space = 0; //Proměnná pro počet úvodních mezer v aktuálním řádku
            int stars = 0; //Proměnná pro počet hvězdiček v aktiálním řádku
            if(i < max /2)
            {//Horní polovina obrazce
              space = i;
              stars = max - (2*i);  
            }
            else
            {//Dolní polovina obrazce - HW
                
            }
        //Samostatné vykreslení aktuálního řádku
        //Nejprve vykreslujeme mezery
        for (int sp = 0; sp < space; sp++ )
        {
            Console.Write(" ");
        }

        //Následně vykreslujeme hvězdičky
        for (int st = 0; st < stars; st++ )
        {
            Console.Write("*");
        }
        Console.WriteLine();
        }
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