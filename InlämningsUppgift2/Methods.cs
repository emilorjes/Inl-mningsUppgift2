using System;
using System.Collections.Generic;
using System.Text;

namespace InlämningsUppgift2
{
    class Methods
    {
        //--------------------------------------------------------------------------------------------------------------------------
        //
        //--------------------------------------------------------------------------------------------------------------------------
        public static List<GroupMember> memberList = new List<GroupMember>() { GroupMember.Benny, GroupMember.Dennis, GroupMember.Emil, GroupMember.Fredrik, GroupMember.Håkan, GroupMember.Josefine, GroupMember.Mattias, GroupMember.Nicklas, GroupMember.Tina, GroupMember.Tobias };




        //--------------------------------------------------------------------------------------------------------------------------
        //
        //--------------------------------------------------------------------------------------------------------------------------
        public static void StartProgram()
        {
            LoginCode();
            StartMenu();
        }




        //--------------------------------------------------------------------------------------------------------------------------
        //
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
        //
        //--------------------------------------------------------------------------------------------------------------------------
        static void StartMenu()
        {
            bool keepMenuGo = true;
            string menuChoiceString;

            Console.WriteLine("Snyggt rätt kod!\n"); // Använd backslash istället för consol.writeline 

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
        //
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

                if (memberChoiceString == "b")
                {
                    keepShowing = false;
                }
                else if (!int.TryParse(memberChoiceString, out int memberChoiceInt) || memberChoiceInt < 1 || memberChoiceInt > memberList.Count)
                {
                    ErrorMessage();
                }

                Console.Clear();

                switch (memberChoiceString)
                {
                    case "1":
                        ShowIndexZeroOfMemberList(); 
                        break;
                    case "2":
                        ShowIndexOneOfMemberList();
                        break;
                    case "3":
                        ShowIndexTwoOfMemberList();
                        break;
                    case "4":
                        ShowIndexThreeOfMemberList();
                        break;
                    case "5":
                        ShowIndexFourOfMemberList();
                        break;
                    case "6":
                        ShowIndexFiveOfMemberList();
                        break;
                    case "7":
                        ShowIndexSixfMemberList();
                        break;
                    case "8":
                        ShowIndexSevenOfMemberList();
                        break;
                    case "9":
                        ShowIndexEightOfMemberList();
                        break;
                    case "10":
                        ShowIndexNineOfMemberList();
                        break;
                }

                Console.Clear();

            } while (keepShowing);
        }




        //--------------------------------------------------------------------------------------------------------------------------
        //
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
        //
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
        //
        //--------------------------------------------------------------------------------------------------------------------------
        static void Exit()
        {
            Console.WriteLine("Tack för att du använt mitt program");
            Environment.Exit(0);
        }




        //--------------------------------------------------------------------------------------------------------------------------
        //
        //--------------------------------------------------------------------------------------------------------------------------
        private static void ErrorMessage() 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fel inmatning, försök igen"); 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ReadLine();
        }




        //--------------------------------------------------------------------------------------------------------------------------
        //
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
        //
        //--------------------------------------------------------------------------------------------------------------------------
        static void ShowIndexZeroOfMemberList()
        {
            PrintMemberInfo(memberList[0]);
            Console.ReadLine();
        }
        static void ShowIndexOneOfMemberList()
        {
            PrintMemberInfo(memberList[1]);
            Console.ReadLine();
        }
        static void ShowIndexTwoOfMemberList()
        {
            PrintMemberInfo(memberList[2]);
            Console.ReadLine();
        }
        static void ShowIndexThreeOfMemberList()
        {
            PrintMemberInfo(memberList[3]);
            Console.ReadLine();
        }
        static void ShowIndexFourOfMemberList()
        {
            PrintMemberInfo(memberList[4]);
            Console.ReadLine();
        }
        static void ShowIndexFiveOfMemberList()
        {
            PrintMemberInfo(memberList[5]);
            Console.ReadLine();
        }
        static void ShowIndexSixfMemberList()
        {
            PrintMemberInfo(memberList[6]);
            Console.ReadLine();
        }
        static void ShowIndexSevenOfMemberList()
        {
            PrintMemberInfo(memberList[7]);
            Console.ReadLine();
        }
        static void ShowIndexEightOfMemberList()
        {
            PrintMemberInfo(memberList[8]);
            Console.ReadLine();
        }
        static void ShowIndexNineOfMemberList()
        {
            PrintMemberInfo(memberList[9]);
            Console.ReadLine();
        }




        //--------------------------------------------------------------------------------------------------------------------------
        //
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
