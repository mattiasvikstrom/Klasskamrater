using System;
using System.Collections.Generic;

namespace Klasskamrater
{
   public class ClassMates
    {
        private string name;
        private int age;
        private int length;
        private string city;
        private string hobby;
        private string favouriteFood;
        private string favouriteDrink;
        private string favouriteBand;
        private int children;
        private string programmingMotivation;

        public ClassMates()
        {

        }
        public ClassMates(string name, int age, int length, string city, string hobby, string favouriteFood, string favouriteDrink, string favouriteBand, int children, string programmingMotivation)
        {
            this.name = name;
            this.age = age;
            this.length = length;
            this.city = city;
            this.hobby = hobby;
            this.favouriteFood = favouriteFood;
            this.favouriteDrink = favouriteDrink;
            this.favouriteBand = favouriteBand;
            this.children = children;
            this.programmingMotivation = programmingMotivation;
        }

            public string Name { get => name; set => name = value; }
            public int Age { get => age; set => age = value; }
            public int Length { get => length; set => length = value; }
            public string City { get => city; set => city = value; }
            public string Hobby { get => hobby; set => hobby = value; }
            public string FavouriteFood { get => favouriteFood; set => favouriteFood = value; }
            public string FavouriteDrink { get => favouriteDrink; set => favouriteDrink = value; }
            public string FavouriteBand { get => favouriteBand; set => favouriteBand = value; }
            public int Children { get => children; set => children = value; }
            public string ProgrammingMotivation { get => programmingMotivation; set => programmingMotivation = value; }
            public static List<ClassMates> People { get => People; set => People = value; }

        // skriver ut beksivningen på medlemmar i KlassKamrat
        public override string ToString()
        {
            return $"\nHej jag heter {name}, är {age} gammal och {length}cm lång. Jag bor i {city} och på min fritid tycker jag om att {hobby}. Min favoritmat är {favouriteFood} " +
                   $"och dricker helst {favouriteDrink}, när det kommer till musik så lyssnar jag mest på {favouriteBand}. Slutligen om mig så har jag {children} barn, trevligt att träffas!\n" +
                   $"\n{name}'s driv när det kommer till programmering: {programmingMotivation}";
        }
        //När en medlem tas bort från listan skrivs det även ut namnet på den som blev borttagen då man väljer med en siffra.
        public string Deleted() 
        {
            string output = $"\nDu tog bort {name}";
            return output;
        }
    }
}
