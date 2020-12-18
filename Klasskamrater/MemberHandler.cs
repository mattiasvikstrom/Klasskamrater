using System;
using System.Collections.Generic;

namespace Klasskamrater
{
    public class MemberHandler
    {
        public static List<ClassMates> PopulateList()
        {
            //Lägger till alla medlemmar i lista people med all information från denna fil , separat och fint!
            //Här kan fler klasskamrater läggas till och programmet kan hantera det.
            List<ClassMates> populate = new List<ClassMates>();

            populate.Add(new ClassMates { Name = "Emil Örjes", Age = 26, Length = 184, City = "Falun", Hobby = "Snowboard, Gitarr, Musik, Hunden, Tv-spel", FavouriteFood = "Feta hamburgare ", FavouriteDrink = "Öl", FavouriteBand = "System Of a Down", Children = 0, ProgrammingMotivation = "Att lära sig ett nytt yrke helt från grunden som känns givande." });
            populate.Add(new ClassMates { Name = "Tina Eriksson", Age = 30, Length = 165, City = "Östersund", Hobby = "Spela TV-spel", FavouriteFood = "Potatis & Purjolöksoppa", FavouriteDrink = "Kaffe", FavouriteBand = "Avicii", Children = 2, ProgrammingMotivation = "Få ett bra jobb, som jag tycker om." });
            populate.Add(new ClassMates { Name = "Benny Christensen", Age = 38, Length = 194, City = "Brunflo", Hobby = "Datorspel, Fiske, Programmering, Landsvägscykling", FavouriteFood = "Älgkebab", FavouriteDrink = "Coca cola", FavouriteBand = "Foo Fighters", Children = 2, ProgrammingMotivation = "Att kunna skapa något från grunden och lösa problem med det jag skapat. Att sedan kunna använda detta till att tjäna hutlösa summor pengar är ju i sig ytterligare en morot." });
            populate.Add(new ClassMates { Name = "Josefine Rönnqvist", Age = 34, Length = 164, City = "Gideå", Hobby = "Sy, pussla, umgås", FavouriteFood = "Frukt", FavouriteDrink = "Vatten", FavouriteBand = "Halsbandet", Children = 2, ProgrammingMotivation = "Personlig utveckling och karriärbyte" });
            populate.Add(new ClassMates { Name = "Fredrik Hoffman", Age = 28, Length = 192, City = "Östersund", Hobby = "musik, socialisera, film, serier, automation och skriptning, programmering, testa nytt, äta ute, whiskykväll och öl", FavouriteFood = "Entrecote med rotfrukter och vitlökssmör", FavouriteDrink = "Trocadero Zero, Ardbeg och Budvar", FavouriteBand = "Armin Van Buuren (annars progressive trance, house, trance, electronic, progressive house, rock, metal, heavy metal)", Children = 0, ProgrammingMotivation = "Möjlighet till karriärutveckling" });
            populate.Add(new ClassMates { Name = "Dennis Lindquist", Age = 32, Length = 182, City = "Älvdalen", Hobby = "Gitarr/Musik", FavouriteFood = "Friterad kyckling", FavouriteDrink = "Öl", FavouriteBand = "Metallica", Children = 1, ProgrammingMotivation = "Att få skapa och kunna vara kreativ. Men även att få göra ett byte av karriär." });
            populate.Add(new ClassMates { Name = "Håkan Eriksson", Age = 44, Length = 187, City = "Uppsala", Hobby = "Moto-X, Sporthojar, Online gaming", FavouriteFood = "Shish kebab", FavouriteDrink = "Loka Citron", FavouriteBand = "Disturbed", Children = 0, ProgrammingMotivation = "Social engineering, datasäkerhet, pentesting" });
            populate.Add(new ClassMates { Name = "Tobias Binett", Age = 31, Length = 192, City = "Hudiksvall", Hobby = "Träning, Musik, Spel och Familjen", FavouriteFood = "Kött", FavouriteDrink = "Öl", FavouriteBand = "The Black Dahlia Murder", Children = 2, ProgrammingMotivation = "Att kunna skapa något användbart för mig själv och andra och att ha möjligheten att arbeta med det." });
            populate.Add(new ClassMates { Name = "Nicklas Eriksson", Age = 26, Length = 175, City = "Umeå", Hobby = "Skidor, cykel, simma, springa, fjällvandring, klättring och dataspel", FavouriteFood = "Gröt med jordnötssmör", FavouriteDrink = "Whiskey", FavouriteBand = "Falling in Reverse och Self Deception", Children = 0, ProgrammingMotivation = "Drivet kommer från att man får vara kreativ och en problemlösare på samma gång. Sen så drivs man såklart av att få testa på en annan karriär än den man har haft tidigare " });
            populate.Add(new ClassMates { Name = "Mattias Vikström", Age = 33, Length = 187, City = "Umeå", Hobby = "odla gurka", FavouriteFood = "Cowboysoppa", FavouriteDrink = "Gin och Tonic", FavouriteBand = "Infected Mushroom", Children = 0, ProgrammingMotivation = "Personlig utveckling och kreativitet" });
            
           
            //extrapersoner för att expandera listan ytterligare.
            //var pelle = new ClassMates("Pelle andersson", 33, 134, "stockholm", "äta mat", "korv", "vatten", "leifkristers", 2, "vill göra grejer");
            //populate.Add(pelle);
            //populate.Add(new KlassKamrat { Name = "Ännu Person", Age = 31, Length = 192, City = "Hudiksvall", Hobby = "Träning, Musik, Spel och Familjen", FavouriteFood = "Kött", FavouriteDrink = "Öl", FavouriteBand = "The Black Dahlia Murder", Children = 2, ProgrammingMotivation = "Att kunna skapa något användbart för mig själv och andra och att ha möjligheten att arbeta med det." });
            //populate.Add(new KlassKamrat { Name = "ÄnnuAnnan Person", Age = 26, Length = 175, City = "Umeå", Hobby = "Skidor, cykel, simma, springa, fjällvandring, klättring och dataspel", FavouriteFood = "Gröt med jordnötssmör", FavouriteDrink = "Whiskey", FavouriteBand = "Falling in Reverse och Self Deception", Children = 0, ProgrammingMotivation = "Drivet kommer från att man får vara kreativ och en problemlösare på samma gång. Sen så drivs man såklart av att få testa på en annan karriär än den man har haft tidigare " });
            return populate;
        }
    }
}
