using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Virtual_Pet_Project
{
    class VirtualPet
    {
        //Define fields
        private string name;
        private int hungerLevel;
        private int sleepyLevel;
        private int happyLevel;
        private bool isPetHungry;
        private bool isPetSleepy;
        private bool isPetHappy;
        //Define properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int HungerLevel
        {
            get { return this.hungerLevel; }
            set { this.hungerLevel = value; }
        }
        public int SleepyLevel
        {
            get { return this.sleepyLevel; }
            set { this.sleepyLevel = value; }
        }
        public int HappyLevel
        {
            get { return this.happyLevel; }
            set { this.happyLevel = value; }
        }
        public bool IsPetHungry
        {
            get { return this.isPetHungry; }
            set { this.isPetHungry = value; }
        }
        public bool IsPetSleepy
        {
            get { return this.isPetSleepy; }
            set { this.isPetSleepy = value; }
        }
        public bool IsPetHappy
        {
            get { return this.isPetHappy; }
            set { this.isPetHappy = value; }
        }
        public VirtualPet()
        {
            //Default constructor
        }
        public VirtualPet(string name, int hungerLevel, int sleepyLevel, int happyLevel)//loaded constructor
        {
            this.name = name;
            this.hungerLevel = hungerLevel;
            this.sleepyLevel = sleepyLevel;
            this.happyLevel = happyLevel;
        }
        //Methods
        public void Tick(bool isPetHungry, bool isPetSleepy, bool isPetHappy)//I was not sure if I should put this method before or after Main.
        {
            Random r = new Random();
            hungerLevel = r.Next(0, 30);
            sleepyLevel = r.Next(0, 30);
            happyLevel = r.Next(0, 30);
            if (hungerLevel < 10)
            {
                isPetHungry = (true);
            }
            else
            {
                isPetHungry = (false);
            }
            if (sleepyLevel < 10)
            {
                isPetSleepy = (true);
            }
            else
            {
                isPetSleepy = (false);
            }
            if (happyLevel < 10)
            {
                isPetHappy = (false);
            }
            else
            {
                isPetHappy = (true);
            }
        }
        public void Feed()
        {
            hungerLevel++;
            if (hungerLevel < 10)
            {
                hungerLevel = hungerLevel + 10;
            }
        }
        public void Sleep()
        {
            sleepyLevel++;
            if (sleepyLevel < 10)
            {
                sleepyLevel = sleepyLevel + 10;
            }
        }
        public void Play()
        {
            happyLevel++;
            if (happyLevel < 10)
            {
                happyLevel = happyLevel + 10;
            }
        }//play
    }//class
}//namespace