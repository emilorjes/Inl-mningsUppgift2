using System;
using System.Collections.Generic;
using System.Text;

namespace InlämningsUppgift2
{
    class Methods // B.
    {
        //--------------------------------------------------------------------------------------------------------------------------
        // B1. En publik lista som innehåller objekt med specifik information om varje person.
        //--------------------------------------------------------------------------------------------------------------------------
        public static List<GroupMember> groupMemberList = new List<GroupMember>() { GroupMember.Benny, GroupMember.Dennis, GroupMember.Emil, GroupMember.Fredrik, GroupMember.Håkan, GroupMember.Josefine, GroupMember.Mattias, GroupMember.Nicklas, GroupMember.Tina, GroupMember.Tobias };




        //--------------------------------------------------------------------------------------------------------------------------
        // B2. När denna metod kallas på i Program.cs körs programmet igång från start.
        //--------------------------------------------------------------------------------------------------------------------------
        public static void StartProgram()
        {
            LoginCode(); // B3. Rad 29
            StartMenu(); // B4. Rad 61
        }




        //--------------------------------------------------------------------------------------------------------------------------
        // B3. Änvändaren får mata in ett lösenord och "Skriv in lösenord" loopar tills användaren skrivit in rätt.
        //--------------------------------------------------------------------------------------------------------------------------
        private static void LoginCode()
        {
            List<string> members = new List<string>() { "Benny", " Dennis", " Emil", " Fredrik", " Håkan", " Josefine", " Mattias", " Nicklas", " Tina", " Tobias" };

            Console.ForegroundColor = ConsoleColor.Blue;
            string secretCode = "norrlänningarna"; 
            string loginCode;
            Console.WriteLine("Välkommen till persondatatbas över basgruppen som jag är med i!\n");
            Console.WriteLine($"Medlemmar i basgruppen: {string.Join(',', members)}\n");

            do
            {
                Console.WriteLine("Ange basgruppens lösenord för att fortsätta");
                Console.Write("Skriv in lösenord: ");
                loginCode = Console.ReadLine().ToLower();
                if (loginCode != secretCode)
                {
                    ErrorMessage(); // B8 Rad 223
                }

                Console.Clear();

            } while (loginCode != secretCode);

        }




        //--------------------------------------------------------------------------------------------------------------------------
        // B4. Menyvalen loopar om användaren skriver fel ("TryParse"). Inuti metoderna i case 1 och 2 kan "b" användas för att backa.
        //--------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------
        // Menyn har 4 olika alternativ. Beroende vilkent alternativ som väljs anropas en specifik metod. 
        //--------------------------------------------------------------------------------------------------------------------------
        private static void StartMenu()
        {
            bool keepMenuGo = true;
            string menuChoiceString;

            Console.WriteLine("Snyggt rätt kod!\n"); 

            do
            {
                Console.WriteLine("1.  Personlista");
                Console.WriteLine("2.  Ta bort personer från listan");
                Console.WriteLine("3.  Visa alla personers information samtidigt");
                Console.WriteLine("4.  Exit\n");
                Console.Write("Välj alternativ: ");
                menuChoiceString = Console.ReadLine();

                if (!int.TryParse(menuChoiceString, out int menuChoiceInt) || menuChoiceInt < 1 || menuChoiceInt > 4)
                {
                    ErrorMessage(); // B8. Rad 223
                }

                Console.Clear();

                switch (menuChoiceString)
                {
                    case "1":
                        MembersMenu(groupMemberList); // B5. Rad 115
                        break;
                    case "2":
                        DeleteMember(); // B6. Rad 154
                        break;
                    case "3":
                        PrintAllMembers(); // B7. Rad 192
                        break;
                    case "4":
                        Exit(); // B8. Rad 211
                        break;

                }

                Console.Clear();

            } while (keepMenuGo);
        }




        //--------------------------------------------------------------------------------------------------------------------------
        // B5. En numrerad lista med namn skrivs ut. Beroenda på vilken siffra som väljs skrivs specific information om den personen ut.
        //--------------------------------------------------------------------------------------------------------------------------
        private static void MembersMenu(List<GroupMember> groupMemberList)
        {
            bool keepShowing = true;
            string memberChoiceString;

            do
            {
                PrintNumberdListWithName(groupMemberList); // B10. Rad 237

                Console.WriteLine("\nVälj person för att visa specifik information (eller b för att backa)"); 
                Console.Write("Välj: ");
                memberChoiceString = Console.ReadLine();

                Console.Clear();

                if (memberChoiceString == "b")
                {
                    keepShowing = false;
                }
                else if (int.TryParse(memberChoiceString, out int memberChoiceInt) == true && memberChoiceInt <= groupMemberList.Count)
                {
                    ShowInfoOfSpecificMember(memberChoiceInt - 1); // B11. Rad 253
                }
                else if (!int.TryParse(memberChoiceString, out memberChoiceInt) || memberChoiceInt < 1 || memberChoiceInt > groupMemberList.Count)
                {
                    ErrorMessage(); // B8. Rad 223
                }

                Console.Clear();

            } while (keepShowing);
        }




        //--------------------------------------------------------------------------------------------------------------------------
        // B6. En numrerad lista skrivs ut och användaren kan ta bort en person från groupMemberList och listan uppdateras då i alla menyvalen.
        //--------------------------------------------------------------------------------------------------------------------------
        private static void DeleteMember()
        {
            bool keepDeleting = true;
            string deleteMemberString;

            do
            {
                PrintNumberdListWithName(groupMemberList); // B10. Rad 237 

                Console.WriteLine();
                Console.WriteLine("Välj person för att ta bort den personen från listan (eller b för att backa)");
                Console.Write("Välj: ");
                deleteMemberString = Console.ReadLine();

                if (deleteMemberString == "b")
                {
                    keepDeleting = false;
                }
                else if (int.TryParse(deleteMemberString, out int deleteMemberInt) == true && deleteMemberInt <= groupMemberList.Count)
                {
                    groupMemberList.RemoveAt(deleteMemberInt - 1);
                }
                else if (!int.TryParse(deleteMemberString, out deleteMemberInt) || deleteMemberInt < 1 || deleteMemberInt > groupMemberList.Count)
                {
                    ErrorMessage(); // B8. Rad 223
                }

                Console.Clear();

            } while (keepDeleting);
        }




        //--------------------------------------------------------------------------------------------------------------------------
        // B7. Skriver ut all information om varje person samtidgt när metoden kallas på.
        //--------------------------------------------------------------------------------------------------------------------------
        private static List<GroupMember> PrintAllMembers()
        {
            foreach (var member in groupMemberList)
            {
                PrintMemberInfo(member); // B12. Rad 265
                Console.WriteLine("\n\n\n");
            }

            Console.ReadLine();

            return groupMemberList;
        }




        //--------------------------------------------------------------------------------------------------------------------------
        // B8. Stänger ner programmet vid metodanrop.
        //--------------------------------------------------------------------------------------------------------------------------
        private static void Exit()
        {
            Console.Write("Tack för att du använt mitt program!");
            Environment.Exit(0);
        }




        //--------------------------------------------------------------------------------------------------------------------------
        // B9. Skriver ut ett rött felmeddelnade vid metodanrop.
        //--------------------------------------------------------------------------------------------------------------------------
        private static void ErrorMessage() 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fel inmatning, försök igen"); 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ReadLine();
        }




        //--------------------------------------------------------------------------------------------------------------------------
        // B10. Skriver ut en numrerad lista av objektens .Name från groupMember vid metodanrop.
        //--------------------------------------------------------------------------------------------------------------------------
        private static void PrintNumberdListWithName(List<GroupMember> groupMemberList)
        {
            int i = 1;
            foreach (var groupMember in groupMemberList) 
            {
                Console.WriteLine($"{i}. {groupMember.Name}");
                i++;
            }
        }




        //--------------------------------------------------------------------------------------------------------------------------
        // B11. Beroende på vilken person(siffra) användaren väljer i MembersMenu skrivs information om den personen ut när metoden anropas.
        //--------------------------------------------------------------------------------------------------------------------------
        private static void ShowInfoOfSpecificMember(int memberChoiceInt)
        {
            PrintMemberInfo(groupMemberList[memberChoiceInt]); // B12. Rad 265
            Console.ReadLine();
        }




        //--------------------------------------------------------------------------------------------------------------------------
        // B12. En mall över hur information om personerna skrivs ut med färgmönster när metodanrop av denna metod sker.
        //--------------------------------------------------------------------------------------------------------------------------
        private static void PrintMemberInfo(GroupMember groupMember)
        {
            Console.Write("Fullständigt namn: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(groupMember.Name);
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write("\nÅlder: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{groupMember.Age} år");
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write("\nLängd: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{groupMember.Height} cm");
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write("\nBor i: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(groupMember.HomeTown);
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write("\nAntal barn: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{groupMember.NumberOfKids} st");
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write("\nFavoritmat: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(groupMember.FavoriteFood);
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write("\nFavoritdryck: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(groupMember.FavoriteDrink);
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write("\nFavoritband: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(groupMember.FavoriteBand);
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write("\nHobby: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(groupMember.Hobby);
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write("\nKod motivation: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(groupMember.CodeMotivation);
            Console.ForegroundColor = ConsoleColor.Blue;

        }
    }
}
