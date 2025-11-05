using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fajlfeldolgozas
{
    internal class Film
    {
        public string cim;
        public List<string> mufaj;
        public int hossz;
        public DateOnly datum;
        public List<string> szereplok;
        public List<string> dijak;
        public string rendezo;
        public string forgatokonyv;
        public string zene;
        public string gyarto;
        public int korhatar;
        
        //"Cim;Műfaj;Hossz;Datum;Szereplok;Dijak;Rendezo;Forgatokonyv;Zene;Gyarto;Korhatar"

        public Film(string cim, List<string> mufaj, int hossz, DateOnly datum, List<string> szereplok, List<string> dijak, string rendezo, string forgatokonyv, string zene, string gyarto, int korhatar)
        {
            this.cim = cim;
            this.mufaj = mufaj;
            this.hossz = hossz;
            this.datum = datum;
            this.szereplok = szereplok;
            this.dijak = dijak;
            this.rendezo = rendezo;
            this.forgatokonyv = forgatokonyv;
            this.zene = zene;
            this.gyarto = gyarto;
            this.korhatar = korhatar;

        }

    }
}
