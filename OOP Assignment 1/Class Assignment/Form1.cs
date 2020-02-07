using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Assignment
{
    
    public partial class Form1 : Form
    {
        string[] dialog;
        int currentLine = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
           var peasants = new Peasants();
            //Peasants.talk();
            var dragon = new Dragon();
            //Dragon.intro();
            var soldier = new Soldier();

            dialog = new string[30];

            dialog[0] = peasants.Peasant1Talk();

            dialog [1] = peasants.Peasant2Talk();

            dialog[2] = soldier.intro();

            dialog[3] = dragon.Talk();

            dialog[4] = dragon.Tease();

            dialog[5] = peasants.warning();

            dialog[6] = dragon.eat();

            dialog[7] = dragon.Threat();

            dialog[8] = soldier.rescue();

            dialog[9] = soldier.jump();

            dialog[10] = soldier.warCry();

            dialog[11] = soldier.Slay();

            dialog[12] = peasants.thankYou();

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = dialog[currentLine];
            currentLine++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
