using System;

namespace ObjekterOgKlasser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person person1 = new Person();
            person1.Alder = 44;
            person1.ForNavn = "Martin";
            person1.EfterNavn = "Knudsen";
            person1.Nationalitet = "Danmark";

            person1 = new Person("Martin", "Knudsen", 44, "Danmark");

            Person person2 = new Person(forNavn:"Martin",efterNavn: "Knudsen",alder: 44,nationalitet:"Danmark");
            Person person3 = new Person("Jens","Knudsen",nationalitet:"Sverige");
            Person person4 = new Person(alder: 33, forNavn: "Jens");

            person1.birthDay();
            Console.WriteLine(person1.Alder);
            Console.WriteLine("Dansker? : "+person1.DanskPerson());
            Console.WriteLine("Dansker? : "+person3.DanskPerson());

            Console.WriteLine(person1.ToString());
            Console.WriteLine(person1);

            BetterPerson betterPerson1 = new BetterPerson(forNavn:"Martin",alder:-4, nationalitet:"Dansker");
            Console.WriteLine(betterPerson1);

            BetterPerson betterPerson2 = new BetterPerson(forNavn: "Benny");
            betterPerson2.Alder = 20;
            Console.WriteLine(betterPerson2);

          /*  betterPerson2.alder = 3;
            Console.WriteLine(betterPerson2);*/






        }
    }
}
