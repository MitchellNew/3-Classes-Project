using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Peasants
    {

      public int PeasantPopulation = 2;

      public string Peasant1_name = "John";
      public int Peasant1_age = 46;

      public string Peasant2_name = "Martha";
      public int Peasant2_age = 45;

      public string Peasant1Talk()
      {
          string Peasant1_intro = "Hello my name is " + Peasant1_name + " I am " + Peasant1_age + ".";
            return Peasant1_intro;
      }

        public string Peasant2Talk()
        {
            string Peasant2_intro = "Hello my name is " + Peasant2_name + " I am " + Peasant2_age + ".";
            return Peasant2_intro;
        }

        public string warning()
        {
            string Warning = "Martha look out!";
            return Warning;
        }

        public string thankYou()
        {
            string thankYou = "Thank you Clark.";
            return thankYou;
        }
    }
}
