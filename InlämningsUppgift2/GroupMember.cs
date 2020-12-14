using System;
using System.Collections.Generic;
using System.Text;

namespace InlämningsUppgift2
{
    class GroupMember : Group // D.
    {
        //--------------------------------------------------------------------------------------------------------------------------
        // 1D. Constructor
        //--------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------
        // Skapar upp constructorn på två olika sätt så jag kan välja hur jag vill skapa objekten på för vis.
        //--------------------------------------------------------------------------------------------------------------------------

        public GroupMember()
        {
            
        }
        //--------------------------------------------------------
        public GroupMember
        (string name,                                
         string homeTown,
         string hobby,
         string favoriteFood,
         string favoriteDrink,
         string favoriteBand,
         string codeMotivation,
         int age,
         int height,
         int numberOfKids
        )
        {
            this.Name = name;
            this.HomeTown = homeTown;
            this.Hobby = hobby;
            this.FavoriteFood = favoriteFood;
            this.FavoriteDrink = favoriteDrink;
            this.FavoriteBand = favoriteBand;
            this.CodeMotivation = codeMotivation;
            this.Age = age;
            this.Height = height;
            this.NumberOfKids = numberOfKids;
        }
        //--------------------------------------------------------




        //--------------------------------------------------------------------------------------------------------------------------
        // 2D. Objects
        //--------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------
        // Skapar upp objecten på detta vis för att det blir tydligar för mig att se vad jag angivit för värden. (Använder den "tomma" constructorn)
        //--------------------------------------------------------------------------------------------------------------------------
        
        //--------------------------------------------------------
        // Benny
        //--------------------------------------------------------
        public static GroupMember Benny = new GroupMember() 
        {
            Name = "Benny Christensen",
            HomeTown = "Brunflo / Östersund",
            Hobby = "Datorspel, Fiske, Programmering, Landsvägscykling",
            FavoriteFood = "Älgkebab",
            FavoriteDrink = "Coca Cola",
            FavoriteBand = "Foo Fighters",
            CodeMotivation = "Att kunna skapa något från grunden och lösa problem med det jag skapat. Att sedan kunna använda detta till att tjäna hutlösa summor pengar är ju i sig ytterligare en morot.",
            Age = 38,
            Height = 194,
            NumberOfKids = 2
        };
        //--------------------------------------------------------





        //--------------------------------------------------------
        // Dennis
        //--------------------------------------------------------
        public static GroupMember Dennis = new GroupMember() 
        {
            Name = "Dennis Lindquist",
            HomeTown = "Älvdalen",
            Hobby = "Gitarr,Musik",
            FavoriteFood = "Friterad kyckling",
            FavoriteDrink = "Öl",
            FavoriteBand = "Metallica",
            CodeMotivation = "Att få skapa och kunna vara kreativ. Men även att få göra ett byte av karriär",
            Age = 32,
            Height = 182,
            NumberOfKids = 1
        };
        //--------------------------------------------------------





        //--------------------------------------------------------
        // Emil
        //--------------------------------------------------------
        public static GroupMember Emil = new GroupMember() 
        {
            Name = "Emil Örjes",
            HomeTown = "Falun",
            Hobby = "Snowboard, Gitarr, Musik, Hunden, Tv-spel",
            FavoriteFood = "Feta hamburgare",
            FavoriteDrink = "Öl",
            FavoriteBand = "System Of A Down",
            CodeMotivation = "Att lära sig ett nytt yrke helt från grunden som känns givande",
            Age = 26,
            Height = 184,
            NumberOfKids = 0
        };
        //--------------------------------------------------------





        //--------------------------------------------------------
        // Fredrik
        //--------------------------------------------------------
        public static GroupMember Fredrik = new GroupMember() 
        {
            Name = "Fredrik Hoffman",
            HomeTown = "Östersund / Odensala",
            Hobby = "Musik, Socialisera, Film, Serier, Automation, Skriptning, Programmering, Testa nytt, Äta ute, Whiskykväll och öl",
            FavoriteFood = "Entrecote med rotfrukter och vitlökssmör",
            FavoriteDrink = "Trocadero Zero, Ardbeg och Budvar",
            FavoriteBand = "Armin Van Buuren ",
            CodeMotivation = "Möjlighet till karriärutveckling",
            Age = 28,
            Height = 192,
            NumberOfKids = 0
        };
        //--------------------------------------------------------





        //--------------------------------------------------------
        // Håkan
        //--------------------------------------------------------
        public static GroupMember Håkan = new GroupMember() 
        {
            Name = "Håkan Eriksson",
            HomeTown = "Uppsala",
            Hobby = "Moto-X, Sporthojar, Online gaming",
            FavoriteFood = "Shish kebab",
            FavoriteDrink = "Loka citron",
            FavoriteBand = "Disturbed",
            CodeMotivation = "Social engineering, Datasäkerhet, Pentesting",
            Age = 44,
            Height = 187,
            NumberOfKids = 0
        };
        //--------------------------------------------------------





        //--------------------------------------------------------
        // Josefine
        //--------------------------------------------------------
        public static GroupMember Josefine = new GroupMember() 
        {
            Name = "Josefine Rönnqvist",
            HomeTown = "Gideå",
            Hobby = "Sy, pussla, umgås",
            FavoriteFood = "Frukt",
            FavoriteDrink = "Vatten",
            FavoriteBand = "Halsbandet",
            CodeMotivation = "Personlig utveckling och karriärbyte",
            Age = 34,
            Height = 164,
            NumberOfKids = 2
        };
        //--------------------------------------------------------





        //--------------------------------------------------------
        // Mattias
        //--------------------------------------------------------
        public static GroupMember Mattias = new GroupMember() 
        {
            Name = "Mattias Vikström",
            HomeTown = "Umeå",
            Hobby = "Fiske, Matlagning",
            FavoriteFood = "Comboysoppa",
            FavoriteDrink = "Gin och tonic",
            FavoriteBand = "Infected Mushroom",
            CodeMotivation = "Personlig utveckling och kreativitet",
            Age = 33,
            Height = 187,
            NumberOfKids = 0
        };
        //--------------------------------------------------------





        //--------------------------------------------------------
        // Nicklas
        //--------------------------------------------------------
        public static GroupMember Nicklas = new GroupMember() 
        {
            Name = "Nicklas Eriksson",
            HomeTown = "Umeå",
            Hobby = "Skidor, Cykel, Simma, Springa, Fjällvandring, Klättring och Dataspel",
            FavoriteFood = "Gröt med jordnötssmör",
            FavoriteDrink = "Whiskey",
            FavoriteBand = "Falling in Reverse och Self Deception",
            CodeMotivation = " Drivet kommer från att man får vara kreativ och en problemlösare på samma gång. Sen så drivs man såklart av att få testa på en annan karriär än den man har haft tidigare ",
            Age = 26,
            Height = 175,
            NumberOfKids = 0
        };
        //--------------------------------------------------------





        //--------------------------------------------------------
        // Tina
        //--------------------------------------------------------
        public static GroupMember Tina = new GroupMember() 
        {
            Name = "Tina Eriksson",
            HomeTown = "Östersund/Brunflo",
            Hobby = "Spela Tv-spel",
            FavoriteFood = "Potatis och purjolöksoppa",
            FavoriteDrink = "Kaffe",
            FavoriteBand = "Avicci",
            CodeMotivation = "Få ett bra jobb som jag tycker om",
            Age = 30,
            Height = 165,
            NumberOfKids = 2
        };
        //--------------------------------------------------------





        //--------------------------------------------------------
        // Tobias
        //--------------------------------------------------------
        public static GroupMember Tobias = new GroupMember() 
        {
            Name = "Tobias Binett",
            HomeTown = "Hudiksvall",
            Hobby = "Träning, Musik, Spel, Familjen",
            FavoriteFood = "Kött",
            FavoriteDrink = "Öl",
            FavoriteBand = "The Black Dahlia Murder",
            CodeMotivation = " Att kunna skapa något användbart för mig själv och andra och att ha möjligheten att arbeta med det",
            Age = 31,
            Height = 192,
            NumberOfKids = 2
        };
        //--------------------------------------------------------
    }
}
