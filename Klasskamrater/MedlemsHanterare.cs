using System;
using System.Collections.Generic;
using System.Text;

namespace Klasskamrater
{
    public class MedlemsHanterare
    {
        public static List<KlassKamrat> LoadSampleData()
        {
            //Lägger till alla medlemmar i lista people med all information från denna fil , separat och fint!
            List<KlassKamrat> populera = new List<KlassKamrat>();

            populera.Add(new KlassKamrat { Namn = "Emil Örjes", Ålder = 26, Längd = 184, Bor = "Falun", Hobby = "Snowboard, Gitarr, Musik, Hunden, Tv-spel", FavoritMat = "Feta hamburgare ", FavoritDryck = "Öl", FavoritBand = "System Of a Down", Barn = 0, ProgrammeringsDriv = "Att lära sig ett nytt yrke helt från grunden som känns givande." });
            populera.Add(new KlassKamrat { Namn = "Tina Eriksson", Ålder = 30, Längd = 165, Bor = "Östersund", Hobby = "Spela TV-spel", FavoritMat = "Potatis & Purjolöksoppa", FavoritDryck = "Kaffe", FavoritBand = "Avicii", Barn = 2, ProgrammeringsDriv = "Få ett bra jobb, som jag tycker om." });
            populera.Add(new KlassKamrat { Namn = "Benny Christensen", Ålder = 38, Längd = 194, Bor = "Brunflo", Hobby = "Datorspel, Fiske, Programmering, Landsvägscykling", FavoritMat = "Älgkebab", FavoritDryck = "Coca cola", FavoritBand = "Foo Fighters", Barn = 2, ProgrammeringsDriv = "Att kunna skapa något från grunden och lösa problem med det jag skapat. Att sedan kunna använda detta till att tjäna hutlösa summor pengar är ju i sig ytterligare en morot." });
            populera.Add(new KlassKamrat { Namn = "Josefine Rönnqvist", Ålder = 34, Längd = 164, Bor = "Gideå", Hobby = "Sy, pussla, umgås", FavoritMat = "Frukt", FavoritDryck = "Vatten", FavoritBand = "Halsbandet", Barn = 2, ProgrammeringsDriv = "Personlig utveckling och karriärbyte" });
            populera.Add(new KlassKamrat { Namn = "Fredrik Hoffman", Ålder = 28, Längd = 192, Bor = "Östersund", Hobby = "musik, socialisera, film, serier, automation och skriptning, programmering, testa nytt, äta ute, whiskykväll och öl", FavoritMat = "Entrecote med rotfrukter och vitlökssmör", FavoritDryck = "Trocadero Zero, Ardbeg och Budvar", FavoritBand = "Armin Van Buuren (annars progressive trance, house, trance, electronic, progressive house, rock, metal, heavy metal)", Barn = 0, ProgrammeringsDriv = "Möjlighet till karriärutveckling" });
            populera.Add(new KlassKamrat { Namn = "Dennis Lindquist", Ålder = 32, Längd = 182, Bor = "Älvdalen", Hobby = "Gitarr/Musik", FavoritMat = "Friterad kyckling", FavoritDryck = "Öl", FavoritBand = "Metallica", Barn = 1, ProgrammeringsDriv = "Att få skapa och kunna vara kreativ. Men även att få göra ett byte av karriär." });
            populera.Add(new KlassKamrat { Namn = "Håkan Eriksson", Ålder = 44, Längd = 187, Bor = "Uppsala", Hobby = "Moto-X, Sporthojar, Online gaming", FavoritMat = "Shish kebab", FavoritDryck = "Loka Citron", FavoritBand = "Disturbed", Barn = 0, ProgrammeringsDriv = "Social engineering, datasäkerhet, pentesting" });
            populera.Add(new KlassKamrat { Namn = "Tobias Binett", Ålder = 31, Längd = 192, Bor = "Hudiksvall", Hobby = "Träning, Musik, Spel och Familjen", FavoritMat = "Kött", FavoritDryck = "Öl", FavoritBand = "The Black Dahlia Murder", Barn = 2, ProgrammeringsDriv = "Att kunna skapa något användbart för mig själv och andra och att ha möjligheten att arbeta med det." });
            populera.Add(new KlassKamrat { Namn = "Nicklas Eriksson", Ålder = 26, Längd = 175, Bor = "Umeå", Hobby = "Skidor, cykel, simma, springa, fjällvandring, klättring och dataspel", FavoritMat = "Gröt med jordnötssmör", FavoritDryck = "Whiskey", FavoritBand = "Falling in Reverse och Self Deception", Barn = 0, ProgrammeringsDriv = "Drivet kommer från att man får vara kreativ och en problemlösare på samma gång. Sen så drivs man såklart av att få testa på en annan karriär än den man har haft tidigare " });
            populera.Add(new KlassKamrat { Namn = "Mattias Vikström", Ålder = 33, Längd = 187, Bor = "Umeå", Hobby = "odla gurka", FavoritMat = "Cowboysoppa", FavoritDryck = "Gin och Tonic", FavoritBand = "Infected Mushroom", Barn = 0, ProgrammeringsDriv = "Personlig utveckling och kreativitet" });
            return populera;
        }
    }
}
