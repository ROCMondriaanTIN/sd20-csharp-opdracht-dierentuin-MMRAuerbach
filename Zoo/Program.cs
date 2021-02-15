using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Niveau Advanced
             * De dierentuin opdracht. In de README.md file vind je een uitgebreide uitleg van deze opdrachten.
             * Zorg ervoor dat zodra je een opdracht hebt gemaakt en getest je een commit maakt - Zie README voor meer info.
             * Door het maken van commits kunnen je git-skills trainen en je makkelijk online feedback geven.
             * Succes met de opdrachten!
             */
            Console.WriteLine("Hallo en welkom bij dierentuin Artis!");

            /* Opdracht 1. Verzin 4 nieuwe dieren voor in de dierentuin en stop ze in de lijst. */
            Animal[] artis = {
                new Animal("Zoogdier", "Orang-oetan", "Whoo ooeh Aaah Aah!", 2),
                new Animal("Reptiel", "Schildpad", "Wheeerddh", 4),
                new Animal("Baarsachtige", "Barracuda", "Bluhhp", 4),
                new Animal("Zoogdier", "Giraffe", "Bhheehh", 4),
                new Animal("Zoogdier", "Stokstaartje", "Phhieeep", 4),
            };

            for (int i = 0; i < artis.Length; i++)
            {
                // Het dier uit de lijst halen met de [i]
                Animal animal = artis[i];
                /* Opdracht 2: Print hieronder de animal uit. */

                /**
                 * Opdracht 3. Pas de if-statement aan en zorg dat elk dier een geluid maakt.
                 * Opdracht 3a. Maak de if-statement effienter. De volgende if-statement zit veel herhaling in.
                 *              Zie jij hoe je de volgende code efficienter kan maken? 
                 */
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

                /* Opdracht 4. Bestudeer de class Animal (Animal.cs) en laat het dier in de dierentuin een geluid maken via de methode in Animal. Zorg dat je nergens meer animal.sound gebruikt. */  
                /* Opdracht 5. Bestudeer de class Animal (Animal.cs) en print het aantal poten uit van de dieren. */  
            }
        }
    }
}
