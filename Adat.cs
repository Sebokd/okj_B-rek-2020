using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berek2020_GUI
{
    class Adat
    {

        //Név;Neme;Részleg;Belépés;Bér


        public string Nev { get; set; }
        public string Nem { get; set; }
        public string Reszleg { get; set; }
        public int Ber { get; set; }
        public int Belepes { get; set; }

        public Adat(string sor)
        {
            string[] s = sor.Split(';');
            Nev = s[0];
            Nem = s[1];
            Reszleg = s[2];
            Belepes = int.Parse(s[3]);
            Ber = int.Parse(s[4]);
            
        }

        public string reszleg()
        {
            return Reszleg;
        }

    }
}
