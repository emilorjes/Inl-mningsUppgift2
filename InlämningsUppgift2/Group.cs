using System;
using System.Collections.Generic;
using System.Text;

namespace InlämningsUppgift2
{
    class Group // C.
    {
        //----------------------------------------
        // 1C. Fields (string)
        //----------------------------------------
        private string name;
        private string homeTown;
        private string hobby;
        private string favoriteFood;
        private string favoriteDrink;
        private string favoriteBand;
        private string codeMotivation;
        //----------------------------------------




        //----------------------------------------
        // 2C. Fields (int)
        //----------------------------------------
        private int age;
        private int height;
        private int numberOfKids;
        //----------------------------------------




        //----------------------------------------
        // 3C. Property (string)
        //----------------------------------------

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //----------------------------------------
        public string HomeTown
        {
            get { return homeTown; }
            set { homeTown = value; }
        }
        //----------------------------------------
        public string Hobby
        {
            get { return hobby; }
            set { hobby = value; }
        }
        //----------------------------------------
        public string FavoriteFood
        {
            get { return favoriteFood; }
            set { favoriteFood = value; }
        }
        //----------------------------------------
        public string FavoriteDrink
        {
            get { return favoriteDrink; }
            set { favoriteDrink = value; }
        }
        //----------------------------------------
        public string FavoriteBand
        {
            get { return favoriteBand; }
            set { favoriteBand = value; }
        }
        //----------------------------------------
        public string CodeMotivation
        {
            get { return codeMotivation; }
            set { codeMotivation = value; }
        }
        //----------------------------------------


        //----------------------------------------
        // 4C. Property (int)                                
        //----------------------------------------
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        //----------------------------------------
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        //----------------------------------------
        public int NumberOfKids
        {
            get { return numberOfKids; }
            set { numberOfKids = value; }
        }
        //----------------------------------------
    }
}
