using System;
using System.Collections.Generic;

namespace Klasskamrater
{
   public class KlassKamrat
    {
        private string namn;
        private int ålder;
        private int längd;
        private string bor;
        private string hobby;
        private string favoritMat;
        private string favoritDryck;
        private string favoritBand;
        private int barn;
        private string programmeringsDriv;

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

            public string Namn { get => namn; set => namn = value; }
            public int Ålder { get => ålder; set => ålder = value; }
            public int Längd { get => längd; set => längd = value; }
            public string Bor { get => bor; set => bor = value; }
            public string Hobby { get => hobby; set => hobby = value; }
            public string FavoritMat { get => favoritMat; set => favoritMat = value; }
            public string FavoritDryck { get => favoritDryck; set => favoritDryck = value; }
            public string FavoritBand { get => favoritBand; set => favoritBand = value; }
            public int Barn { get => barn; set => barn = value; }
            public string ProgrammeringsDriv { get => programmeringsDriv; set => programmeringsDriv = value; }
            public static List<KlassKamrat> People { get => People; set => People = value; }

        public override string ToString()
        {
            return $"{namn} , {ålder} , {längd}";
        }
    }
}
