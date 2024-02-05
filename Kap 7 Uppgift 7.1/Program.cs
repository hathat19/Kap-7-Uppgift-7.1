using System;
using System.Collections.Generic;
namespace Uppgift7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            //Input
            Console.WriteLine("Skriv in hur många namn som du vill. Lämnas raden tom avslutas du inmatningen.");
            string tempUserInput = Console.ReadLine();
            while (tempUserInput != "") 
            {
                names.Add(tempUserInput);
                tempUserInput = Console.ReadLine();
            }

            //Utskrift
            names.Sort();
            for (int i = names.Count-1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
/*Skapa ett konsolprogram där användaren ska få skriva in namn. Användaren ska inte
behöva ange hur många namn som ska skrivas in när programmet börjar.
Användaren ska få mata in nya namn ända tills hen skriver en tom rad. Alla de
inmatade namnen ska skrivas ut i omvänd bokstavsordning.*/