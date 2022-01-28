using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjekterOgKlasser
{
    internal class BetterPerson
    {

        private string forNavn;
        private string efterNavn;
        private int alder;
        private string nationalitet;

        public string ForNavn
        {
            get { return forNavn; }
            set { forNavn = value; }
        }
        public string EfterNavn
        {
            get { return efterNavn; }
            set { efterNavn = value; }
        }

        public int Alder
        {
            get { return alder; }   
            set { if (value>=0) alder = value; }
        }

        public string Nationalitet
        {
            get { return nationalitet; }    
            set { nationalitet = value; }
        }

        public BetterPerson(string forNavn = "", string efterNavn = "", int alder = 0, string nationalitet = "")
        {
            this.ForNavn = forNavn;
            this.EfterNavn = efterNavn;
            this.Alder = alder;
            this.Nationalitet = nationalitet;
        }


        override public String ToString()
        {
            return $"{ForNavn} {EfterNavn} er {Alder} år og nationaliteten er {Nationalitet}";
        }
    }
}
