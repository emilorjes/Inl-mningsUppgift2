using System;
namespace InlämningsUppgift2
{
    class Program // A.
    {
        static void Main(string[] args)
        {
            
            /*
             * Klasserna refereras med en bokstav.
             * Metoder och annat i klasserna refereras med klassens bokstav med en unik siffra. Bredvid står radnummret.
             * Jag vet att det inte är optimalt att ha radnummret eftersom den ändras så fort jag skriver till en rad i koden.
             * Jag har gjort så för att göra det lättare för dig som rättar att hitta i koden.
             * Program.cs = A || Methods.cs = B || Group.cs = C || GroupMembers.cs = D
            */

            //--------------------------------------------------------------------------------------------------------------------------
            // A1. Metodanrop från "StartProgram" och programmet kör igång.
            //--------------------------------------------------------------------------------------------------------------------------
            Methods.StartProgram();
            
        }
    }
}
