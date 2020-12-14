﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InlämningsUppgift2
{
    class Methods
    {
        //--------------------------------------------------------------------------------------------------------------------------
        // En publik lista som innehåller objekt med specifik information om varje person.
        //--------------------------------------------------------------------------------------------------------------------------
        public static List<GroupMember> memberList = new List<GroupMember>() { GroupMember.Benny, GroupMember.Dennis, GroupMember.Emil, GroupMember.Fredrik, GroupMember.Håkan, GroupMember.Josefine, GroupMember.Mattias, GroupMember.Nicklas, GroupMember.Tina, GroupMember.Tobias };




        //--------------------------------------------------------------------------------------------------------------------------
        // När denna metod kallas på i Program.cs körs programmet igång från start.
        //--------------------------------------------------------------------------------------------------------------------------
        public static void StartProgram()
        {
            LoginCode();
            StartMenu();
        }




        //--------------------------------------------------------------------------------------------------------------------------
        // Änvändaren får mata in ett lösenord och "Skriv in lösenord" loopar tills användaren skrivit in rätt.
        //--------------------------------------------------------------------------------------------------------------------------
        static void LoginCode()
        {
            List<string> members = new List<string>() { "Benny", "Dennis", "Emil", "Fredrik", "Håkan", "Josefine", "Mattias", "Nicklas", "Tina", "Tobias" };

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
                    ErrorMessage();
                }

                Console.Clear();

            } while (loginCode != secretCode);

        }




        //--------------------------------------------------------------------------------------------------------------------------
        // StartMenu och menyvalen loopar om användaren skriver fel ("TryParse"). I menyval 1 och 2 kan "b" användas för att backa.
        //--------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------
        // Menyn har 4 olika alternativ. Beroende vilkent alternativ som väljs anropas en specifik metod. 
        //--------------------------------------------------------------------------------------------------------------------------
        static void StartMenu()
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
                    ErrorMessage();
                }

                Console.Clear();

                switch (menuChoiceString)
                {
                    case "1":
                        MembersMenu(memberList); 
                        break;
                    case "2":
                        DeleteMember(); 
                        break;
                    case "3":
                        PrintAllMembers(); 
                        break;
                    case "4":
                        Exit(); 
                        break;

                }

                Console.Clear();

            } while (keepMenuGo);
        }




        //--------------------------------------------------------------------------------------------------------------------------
        // En numrerad lista med namn skrivs ut. Beroenda på vilken siffra som välj skrivs specific information om den personen ut.
        //--------------------------------------------------------------------------------------------------------------------------
        static void MembersMenu(List<GroupMember> memberList)
        {
            bool keepShowing = true;
            string memberChoiceString;

            do
            {
                PrintNumberdListWithName(memberList); 

                Console.WriteLine("\nVälj person för att visa specifik information (eller b för att backa)"); 
                Console.Write("Välj: ");
                memberChoiceString = Console.ReadLine();
                
                Console.Clear();

                if (memberChoiceString == "b")
                {
                    keepShowing = false;
                }
                else if (int.TryParse(memberChoiceString, out int memberChoiceInt) == true && memberChoiceInt <= memberList.Count)
                {
                    ShowInfoOfSpecificMember(memberChoiceInt - 1);
                }
                else if (!int.TryParse(memberChoiceString, out memberChoiceInt) || memberChoiceInt < 1 || memberChoiceInt > memberList.Count)
                {
                    ErrorMessage();
                }

                Console.Clear();

            } while (keepShowing);
        }




        //--------------------------------------------------------------------------------------------------------------------------
        // Tar bort en person från listan memberList och listan uppdateras i alla menyval.
        //--------------------------------------------------------------------------------------------------------------------------
        static void DeleteMember()
        {
            bool keepDeleting = true;
            string deleteMemberString;

            do
            {
                PrintNumberdListWithName(memberList);

                Console.WriteLine();
                Console.WriteLine("Välj person för att ta bort den personen från listan (eller b för att backa)");
                Console.Write("Välj: ");
                deleteMemberString = Console.ReadLine();

                if (deleteMemberString == "b")
                {
                    keepDeleting = false;
                }
                else if (int.TryParse(deleteMemberString, out int deleteMemberInt) == true && deleteMemberInt <= memberList.Count)
                {
                    memberList.RemoveAt(deleteMemberInt - 1);
                }
                else if (!int.TryParse(deleteMemberString, out deleteMemberInt) || deleteMemberInt < 1 || deleteMemberInt > memberList.Count)
                {
                    ErrorMessage();
                }

                Console.Clear();

            } while (keepDeleting);
        }




        //--------------------------------------------------------------------------------------------------------------------------
        // Skriver ut all information om varje person samtidgt.
        //--------------------------------------------------------------------------------------------------------------------------
        public static List<GroupMember> PrintAllMembers()
        {
            foreach (var member in memberList)
            {
                PrintMemberInfo(member);
                Console.WriteLine("\n\n\n");
            }

            Console.ReadLine();

            return memberList;
        }




        //--------------------------------------------------------------------------------------------------------------------------
        // Stänger ner programmet.
        //--------------------------------------------------------------------------------------------------------------------------
        static void Exit()
        {
            Console.WriteLine("Tack för att du använt mitt program");
            Environment.Exit(0);
        }




        //--------------------------------------------------------------------------------------------------------------------------
        // Skriver ut ett rött felmeddelnade vid nmetodanrop.
        //--------------------------------------------------------------------------------------------------------------------------
        private static void ErrorMessage() 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fel inmatning, försök igen"); 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ReadLine();
        }




        //--------------------------------------------------------------------------------------------------------------------------
        // Skriver ut en numrerad lista av objektens namn från memberList.
        //--------------------------------------------------------------------------------------------------------------------------
        private static void PrintNumberdListWithName(List<GroupMember> memberList)
        {
            int i = 1;
            foreach (var groupMember in memberList) 
            {
                Console.WriteLine($"{i}. {groupMember.Name}");
                i++;
            }
        }




        //--------------------------------------------------------------------------------------------------------------------------
        // Beroende på vilken person(siffra) användaren väljer i MembersMenu skrivs information om den personen ut när metoden anropas.
        //--------------------------------------------------------------------------------------------------------------------------
        static void ShowInfoOfSpecificMember(int memberChoiceInt)
        {
            PrintMemberInfo(memberList[memberChoiceInt]);
            Console.ReadLine();
        }
       




        //--------------------------------------------------------------------------------------------------------------------------
        // En mall över hur information om personerna skrivs ut med färgmönster när metodanrop av denna metod sker.
        //--------------------------------------------------------------------------------------------------------------------------
        public static void PrintMemberInfo(GroupMember groupMember)
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
