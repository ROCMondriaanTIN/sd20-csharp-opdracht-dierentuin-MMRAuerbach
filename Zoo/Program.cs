using System;
// Belangrijk bij het gebruik van een List class
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Niveau Expert
             * De dierentuin opdracht. In de README.md file vind je een uitgebreide uitleg van deze opdrachten.
             * Zorg ervoor dat zodra je een opdracht hebt gemaakt en getest je een commit maakt - Zie README voor meer info.
             * Door het maken van commits kunnen je git-skills trainen en je makkelijk online feedback geven.
             * Succes met de opdrachten!
             * 
             * Opdracht 1a. De code die jij hebt gekregen werkt niet :( vindt het probleem en los deze op.
             * Opdracht 1b. Verzin 4 nieuwe dieren voor in de dierentuin en stop ze in de lijst.
             * Opdracht 2. Print de dieren uit in de console.
             * Opdracht 3. Pas de if-statement aan en maak deze code efficienter.
             * Opdracht 4. Bestudeer de class Animal (Animal.cs). Laat het dier in de dierentuin een geluid maken.
             * Opdracht 5. Bestudeer de class Animal. Verander de attributes aan van de class Animal van public naar private.
             *             Wat gebeurt er nu met je code? Repareer nu jouw code. 
             *             Tip. Maak gebruik van de methodes die public zijn gebleven.
             */

            // Expert
            Console.WriteLine("Hallo en welkom bij dierentuin Blijdorp!");
            List<Animal> blijdorp = new List<Animal>();
            blijdorp.Add(new Animal("Zoogdier", "Orang-oetan", "Whoo ooeh Aaah Aah!", 2));
            blijdorp.Add(new Animal("Reptiel", "Schildpad", "Wheeerddh", 4));
            blijdorp.Add(new Animal("Reptiel", "Barracuda", "Bluhhp", 4));
            blijdorp.Add(new Animal("Zoogdier", "Giraffe", "Bhheehh", 4));
            blijdorp.Add(new Animal("Zoogdier", "Stokstaartje", "Phhieeep", 4));

            // FIXME Repareer de for-loop
            for ()
            {
                // Het dier uit de lijst halen met de [j]
                Animal animal = blijdorp[j];

                if (animal.name == "Orang-oetan")
                {
                    Console.WriteLine(animal.sound);
                }
                else if (animal.name == "Schildpad")
                {
                    Console.WriteLine(animal.sound);
                }
                else if (animal.name == "Barracuda")
                {
                    Console.WriteLine(animal.sound);
                }
                else if (animal.name == "Giraffe")
                {
                    Console.WriteLine(animal.sound);
                }
                else if (animal.name == "Stokstaartje")
                {
                    Console.WriteLine(animal.sound);
                }
            }
        }
    }
}
