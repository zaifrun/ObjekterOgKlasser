using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjekterOgKlasser
{
    internal class AutomaticPerson
    {

        public string ForNavn {  get; set; }
        public string EfterNavn { get; set; }   
        public int Alder { get; set; }
        public string Nationalitet { get; set;  }

        public AutomaticPerson(string forNavn = "", string efterNavn = "", int alder = 0, string nationalitet = "")
        {
            this.ForNavn = forNavn;
            this.EfterNavn = efterNavn;
            this.Alder = alder;
            this.Nationalitet = nationalitet;
        }
    }
}
