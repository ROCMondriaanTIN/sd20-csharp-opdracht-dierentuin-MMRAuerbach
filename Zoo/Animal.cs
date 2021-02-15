using System;

namespace Zoo
{
    class Animal
    {
        // Attributes
        public string spieces;
        public string name;
        public string sound;
        public int legs;

        /**
         * Constructor
         */
        public Animal(string spieces, string name, string sound, int legs)
        {
            this.spieces = spieces;
            this.name = name;
            this.sound = sound;
            this.legs = legs;
        }

        /**
         * Methode MakeSound
         */
        public void MakeSound()
        {
            Console.WriteLine(this.sound);
        }

        /**
         * Methode Getter GetName
         */
        public string GetName()
        {
            return this.name;
        }

        /**
         * Methode Getter GetSpieces
         */
        public string GetSpieces()
        {
            return this.spieces;
        }

        /**
         * Methode Getter GetLegs
         */
        public int GetLegs()
        {
            return this.legs;
        }
    }
}
