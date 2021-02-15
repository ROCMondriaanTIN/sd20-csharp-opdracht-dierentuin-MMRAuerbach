using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Niveau Starter
             * De dierentuin opdracht. In de README.md file vind je een uitgebreide uitleg van deze opdrachten.
             * Zorg ervoor dat zodra je een opdracht hebt gemaakt en getest je een commit maakt - Zie README voor meer info.
             * Door het maken van commits kunnen je git-skills trainen en je makkelijk online feedback geven.
             * Succes met de opdrachten!
             * 
             * 
             * Kijk voor de vervolg opdracht helemaal onderaan.
             */

            Console.WriteLine("Hallo en welkom bij dierentuin Wildlands!");
            // Opdracht 1. Verzin 4 nieuwe dieren voor in de dierentuin en stop ze in de lijst.
            string[] wildlands = { "Orang-oetan", "Schildpad", "Barracuda", "Giraffe", "Stokstaartje",
                                   "Tarantula", "Olifant", "Gekko", "Bizon" };

            /**
             * Met de for-loop lopen we door de array heen.
             * Door een variabele i te maken kunnen we steeds met i de index ophalen. 
             * De i begint op 0, het eerste dier is dan wildlands[i], of terwijl wildlands[0] en dat is de Oerang-oetan.
             * Als alle code van de for-loop gedaan is (dus na het vertellen hoeveel poten het beest heeft)
             * Wordt i automatisch opgehoogd met 1 (i++)
             * Zolang i kleiner is als het aantal elementen in de array (9 beesten) blijft hij door tellen
             * Als i 9 wordt, dan gaat de for-loop niet verder.
            */
            for(int i = 0; i < wildlands.Length; i++)
            {
                string animal = wildlands[i]; //Dit is de naam van het dier
                // Opdracht 2: Print hieronder de animal uit.

                // Opdracht 3. Pas de switch aan en zorg dat elk dier een geluid maakt.
                switch(animal)
                {
                    case "Orang-oetan":
                        Console.WriteLine($"{animal} doet Oeehh Hoeee Aaah aaah!");
                        break;
                    case "Schildpad":
                        Console.WriteLine($"{animal} doet uhh geen idee?");
                        break;
                    case "Barracuda":
                        Console.WriteLine($"{animal} doet BlubBlub");
                        break;
                    case "Giraffe":
                        Console.WriteLine($"{animal} doet giraffig");
                        break;
                    case "Stokstaartje":
                        Console.WriteLine($"{animal} doet iieee ieee");
                        break;
                    case "Tarantula":
                        Console.WriteLine($"{animal} doet tippeltippel");
                        break;
                    case "Olifant":
                        Console.WriteLine($"{animal} doet poweeeeeep");
                        break;
                    case "Gekko":
                        Console.WriteLine($"{animal} doet gggkggggkk");
                        break;
                    case "Bizon":
                        Console.WriteLine($"{animal} doet gnoegnoe");
                        break;
                    default:
                        Console.WriteLine("Hey dit dier heeft geen geluidje :-s");
                        break;
                }

                // Opdracht 4. Zorg ervoor dat je met een if-statement het aantal poten uitprint van het dier.
                if (animal == "Orang-" +
                    "oetan" || animal == "Schildpad" || animal == "Giraffe" ||
                     animal == "Olifant" || animal == "Bizon" || animal == "Gekko")
                {
                    Console.WriteLine($"Een {animal} heeft 4 poten");
                }
                else if (animal == "Stokstaartje")
                {
                    Console.WriteLine($"Een {animal} heeft 2 poten");
                }
                else if (animal == "Tarantula")
                {
                    Console.WriteLine($"Een {animal} heeft 8 poten");
                }
                else
                {
                    Console.WriteLine($"Een {animal} heeft geen poten");
                }
            }

            /**
             * Nieuwe opdracht
             * Hieronder heb je een array van getallen (datatype int en [] geeft aan dat het een arary is)
             * 
             * Opdracht 1: Vul de lijst aan met 4 extra getallen tussen de 0 en 100
             */
            int[] myNumbers = { 12, 15, 20, 33, 7, 55, 75 };
            int totalNumbers = 0;

            for (int i = 0; i < myNumbers.Length; i++)
            {
                int number = myNumbers[i];

                /*
                 * Opdracht 2: Maak een if-statement
                 *  - als een getal kleiner is als 10 toon je de tekst: "Dit is een laag getal, onder de 10"
                 *  - als een getal groter of gelijk is aan 10 maar kleiner dan 30 toon je: "Dit is nog laag, maar wel meer dan 10"
                 *  - als een getal groter of gelijk is aan 30 maar kleiner dan 60 toon je: "Dit is een middelmatig getal tussen de 30 en 60"
                 *  - als een getal groter of gelijk is aan 60 toon je: "Dit is een hoog getal"
                 */


                //Opdracht 3: Er is een variabel totalNumbers, zorg ervoor dat elk getal bij deze variabel opgeteld wordt


                /*Extra opdracht: Probeer eens iets te verzinnen waarin je verteld of het vorige getal hoger 
                 * of lager was dan het vorige getal in de for-loop. Je moet hiervoor in ieder geval
                 * een extra variabele aanmaken buiten de for-loop (dus direct onder int totalNumbers) 
                 * en een if-statement gebruiken. Gebruik een Console.WriteLine om de info te tonen.
                 */

            }

            //Als het goed is krijg je hier een optelling van minimaal 220
            Console.WriteLine($"Het totaal van alle getallen is: {totalNumbers}");
        }
    }
}