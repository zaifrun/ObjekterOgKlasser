using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjekterOgKlasser
{
    internal class Person
    {
        public string ForNavn;
        public string EfterNavn;
        public int Alder;
        public string Nationalitet; 

     /*   public Person(string forNavn, string efterNavn, int alder, string nationalitet)
        {
            this.ForNavn = forNavn;
            this.EfterNavn = efterNavn;
            this.Alder = alder;
            this.Nationalitet = nationalitet;
        }*/

        public Person(string forNavn = "", string efterNavn = "", int alder = 0, string nationalitet = "")
        {
            this.ForNavn = forNavn;
            this.EfterNavn = efterNavn;
            this.Alder = alder;
            this.Nationalitet = nationalitet;
        }

        public void birthDay()
        {
            Alder++;
        }

        override public String ToString()
        {
            return $"{ForNavn} {EfterNavn} er {Alder} år og nationaliteten er {Nationalitet}";
        }

        public bool DanskPerson()
        {
            if (Nationalitet.Equals("Danmark"))
                return true;
            else
                return false;
        }
    }
}
