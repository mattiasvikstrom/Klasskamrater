using System;
using System.Collections.Generic;


namespace Klasskamrater
{
   public class KlassKamrat
    {
        public string namn;
        public int ålder;
        public int längd;
        public string bor;
        public string hobby;
        public string favoritMat;
        public string favoritDryck;
        public string favoritBand;
        public int barn;
        public string programmeringsDriv;
        
        public KlassKamrat()
        {

        }
        public KlassKamrat(string namn, int ålder, int längd, string bor, string hobby, string favoritMat, string favoritDryck, string favoritBand, int barn, string programmeringsDriv)
        {
            this.namn = namn;
            this.ålder = ålder;
            this.längd = längd;
            this.bor = bor;
            this.hobby = hobby;
            this.favoritMat = favoritMat;
            this.favoritDryck = favoritDryck;
            this.favoritBand = favoritBand;
            this.barn = barn;
            this.programmeringsDriv = programmeringsDriv;
        }
        
        public string Describe() // skriver ut beksivning på medlemmar i KlassKamrat
        {
            string description = $"\nHej jag heter {namn}, är {ålder} gammal och {längd}cm lång. Jag bor i {bor} och på min fritid tycker jag om att {hobby}. Min favoritmat är {favoritMat} " +
                                 $"och dricker helst {favoritDryck}, när det kommer till musik så lyssnar jag mest på {favoritBand}. Slutligen om mig så har jag {barn} barn, trevligt att träffas!\n" +
                                 $"\n{namn}'s driv när det kommer till programmering: {programmeringsDriv}";
            return description;
        }
           // Skapa upp alla klassmedlemmar
           public static KlassKamrat emil = new KlassKamrat("Emil Örjes", 26, 184, "Falun", "Snowboard, Gitarr, Musik, Hunden, Tv-spel", "Feta hamburgare ", "Öl", "System Of a Down", 0, "Att lära sig ett nytt yrke helt från grunden som känns givande.");
           public static KlassKamrat tina = new KlassKamrat("Tina Eriksson", 30, 165, "Östersund", "Spela TV-spel", "Potatis & Purjolöksoppa", "Kaffe", "Avicii", 2, "Få ett bra jobb, som jag tycker om.");
           public static KlassKamrat benny = new KlassKamrat("Benny", 38, 194, "Brunflo", "Datorspel, Fiske, Programmering, Landsvägscykling", "Älgkebab", "Coca cola", "Foo Fighters", 2, "Att kunna skapa något från grunden och lösa problem med det jag skapat. Att sedan kunna använda detta till att tjäna hutlösa summor pengar är ju i sig ytterligare en morot.");
           public static KlassKamrat josefine = new KlassKamrat("Josefine", 33, 187, "Umeå", "odla gurka", "Cowboysoppa", "Gin och Tonic", "Infected Mushroom", 0, "utvecklas och så");
           public static KlassKamrat fredrik = new KlassKamrat("Fredrik Hoffman", 28, 192, "Östersund", "musik, socialisera, film, serier, automation och skriptning, programmering, testa nytt, äta ute, whiskykväll och öl", "Entrecote med rotfrukter och vitlökssmör", "Trocadero Zero, Ardbeg och Budvar", "Armin Van Buuren (annars progressive trance, house, trance, electronic, progressive house, rock, metal, heavy metal)", 0, "Möjlighet till karriärutveckling");
           public static KlassKamrat dennis = new KlassKamrat("Dennis Lindquist", 32, 182, "Älvdalen", "Gitarr/Musik", "Friterad kyckling", "Öl", "Metallica", 1, "Att få skapa och kunna vara kreativ. Men även att få göra ett byte av karriär.");
           public static KlassKamrat håkan = new KlassKamrat("Håkan Eriksson", 44, 187, "Uppsala", "Moto-X, Sporthojar, Online gaming", "Shish kebab", "Loka Citron", "Disturbed", 0, "Social engineering, datasäkerhet, pentesting");
           public static KlassKamrat tobias = new KlassKamrat("Tobias Binett", 31, 192, "Hudiksvall", "Träning, Musik, Spel och Familjen", "Kött", "Öl", "The Black Dahlia Murder", 2, "Att kunna skapa något användbart för mig själv och andra och att ha möjligheten att arbeta med det.");
           public static KlassKamrat nicklas = new KlassKamrat("Nicklas Eriksson", 26, 175, "Umeå", "Skidor, cykel, simma, springa, fjällvandring, klättring och dataspel", "Gröt med jordnötssmör", "Whiskey", "Falling in Reverse och Self Deception", 0, "Drivet kommer från att man får vara kreativ och en problemlösare på samma gång. Sen så drivs man såklart av att få testa på en annan karriär än den man har haft tidigare ");
           public static KlassKamrat mattias = new KlassKamrat("Mattias Vikström", 33, 187, "Umeå", "odla gurka", "Cowboysoppa", "Gin och Tonic", "Infected Mushroom", 0, "Personlig utveckling och kreativitet");

           public static List<KlassKamrat> medlemmar = new List<KlassKamrat>() { emil, tina, benny, josefine, fredrik, dennis, håkan, tobias, nicklas, mattias, };
    }
}
