using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{

    class Dragon
    {
        //numbers
        public int DragonPopulation = 1;
        public static int age = 100;
        public int appetite = 25;
        public string DragonName = "Rakshiss";

        //dialog
        public string Talk()
        {
            string intro = "My name is " + DragonName + ". I am here to claim my land.";
            return intro;
        }
        public string eat()
        {
            string Eat = "*Chomp*, *Gulp*";
            return Eat;
        }
        public string Threat()
        {
            string Roar = "Rwwaaaaar!";
            return Roar;
        }
 
         public string Tease()
        {
          string Taunt = "*lands on the roof of the cottage* Time to play with my pretty ones!";
            return Taunt;
        }
        
    }
}

