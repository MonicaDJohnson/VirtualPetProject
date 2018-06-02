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
        public void Tick()
        {

        }

        public void Feed()
        {

        }

        public void Sleep()
        {

        }

        public void Play()
        {

        }

    } 

}
