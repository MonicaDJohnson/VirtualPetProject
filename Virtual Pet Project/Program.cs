using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet Pet = new VirtualPet("Waggy", 15, 12, 7);
            int hungerLevel = 0;
            int sleepyLevel = 0;
            int happyLevel = 0;
            int userSelection;
            string userActionFeed;
            string userActionSleep;
            string userActionPlay;
            string checkAgain = "";
          
                

            while (checkAgain != "no")
            {
                Pet.Tick(true, true, true);

                Console.WriteLine("Your pet's name is {0}.", Pet.Name);
                Console.WriteLine("Your pet's hunger level is currently at {0}. Your pet's sleepiness level is currently at {1}. Your pet's happiness level is currently at {2}.", Pet.HungerLevel, Pet.SleepyLevel, Pet.HappyLevel);
                Console.WriteLine("Type 1 to feed pet. Type 2 to give pet a nap. Type 3 to play with pet. ");
                userSelection = int.Parse(Console.ReadLine());


                if (userSelection == 1)
                {
                    Pet.Feed();
                    Console.WriteLine("Your pet's new hunger level is {0}.", Pet.HungerLevel);

                }

                else if (userSelection == 2)
                {
                    Pet.Sleep();
                    Console.WriteLine("Your pet's new sleep level is {0}.", Pet.SleepyLevel);
                }

                else if (userSelection == 3)
                {
                    Pet.Play();
                    Console.WriteLine("Your pet's new happy level is {0}.", Pet.HappyLevel);
                }

                if (hungerLevel > 10)
                {
                    Console.WriteLine("Your pet is hungry. Would you like to feed it?");
                    userActionFeed = Console.ReadLine().ToLower();
                    if (userActionFeed == "yes")
                    {
                        Pet.Feed();
                        Console.WriteLine("Your pet's new hunger level is {0}.", Pet.HungerLevel);
                    }

                    else
                    {

                    }
                }

                if (sleepyLevel < 10)
                {
                    Console.WriteLine("Your pet is sleepy. Would you like to give it a nap?");
                    userActionSleep = Console.ReadLine().ToLower();
                    if (userActionSleep == "yes")
                    {
                        Pet.Sleep();
                        Console.WriteLine("Your pet's new sleep level is {0}.", Pet.SleepyLevel);
                    }

                    else
                    {

                    }
                }

                if (happyLevel < 10)
                {
                    Console.WriteLine("Your pet is sad. Would you like to play with it?");
                    userActionPlay = Console.ReadLine().ToLower();
                    if (userActionPlay == "yes")
                    {
                        Pet.Play();
                        Console.WriteLine("Your pet's new happy level is {0}.", Pet.HappyLevel);
                    }

                    else
                    {

                    }
                }










            }


        }




    }
    
}
