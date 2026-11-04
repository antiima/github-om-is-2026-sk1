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
    Console.WriteLine("************ Součet cifer *************");
    Console.WriteLine("*************************************");
    Console.WriteLine("*********** Ondřej Marušák *************");
    Console.WriteLine("*************************************");
    Console.WriteLine();
    Console.WriteLine();

    // Načtení první hodnoty 
    Console.Write("Zadejte číslo (celé číslo): ");
    int number;
    while(!int.TryParse(Console.ReadLine(), out number)) {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }



    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Zadané číslo: {number}");
    Console.WriteLine("=============================");
    Console.WriteLine();
    Console.WriteLine();

    // Zde budeme pokračovat konkrétním algoritmem
    
    //Příprava pomocí proměnných
    int NumberBackup = number; //Záloha původního čísla
    int sum = 0;    //Neutrální hodnota po sčítaní je 0
    int digit;      //Proměnná pro jednotlivé cifry


    //Ošetření záporných čísel
    if(number < 0)
    {
        number = -number;

    }
    //Zvláštní případ pro nulu
    if (number == 0)
    {
        sum = 0;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Průběh rozkladu čísla na čílice (zprava):");

        //Matematický rozklad čísla pomocí cyklu
        //Využíváme operaci modulo - určení zbytku po celočíselném dělení
        while (number > 0)
        {
            digit = number %10; //Modulo 10 - získáme poslední číslici
            sum = sum + digit; //Přičtení číslice k celkovému součtu

            Console.WriteLine($"Získané číslice: {digit}");

            number = number / 10; //Celočíselné dělení 10 odstraní poslední číslici

           

        }

    }

    //Výpis výsledku
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"=====Zadané číslo: {NumberBackup}=====");
    Console.WriteLine("=============================");
    Console.WriteLine("=============================");
    Console.WriteLine($"====Součet cifer: {sum}====");
    


























    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stislněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}