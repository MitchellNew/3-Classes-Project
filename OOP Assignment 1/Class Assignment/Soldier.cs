using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Soldier
    {
        public string name = "Clark";
        public string age = "21";
        public string rescue()
        {
            string rescue = "I've got your back John!";
            return rescue;
        }

        public string jump()
        {
            string jump = "*Jumps on the dragon's neck, Sword in hand.*";
            return jump;
        }

        public string warCry()
        {
            string warCry = "Die demon spawn!";
            return warCry;
        }
        public string Slay()
        {
            string Slay = "*Slits Dragon's throat*";
            return Slay ;
        }

        public string intro()
        {
            string intro = "My name is " + name + " I am a soldier.";
            return intro;
        }
    }
}
