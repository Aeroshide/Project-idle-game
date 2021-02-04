using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Project_idle_game.Properties;

namespace Project_idle_game
{
    public partial class Form2 : Form
    {
        int Cash = 0;
        // Vein miner variables
        int Vein = 0;
        int VeinPrice = 50;
        int VeinFunc = 1;
        // Vein miner variables
        // Mining device variables
        int Dev = 0;
        int DevPrice = 200;
        int DevFunc = 5;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Cash += VeinFunc;
            
        }   

        private void timer1_Tick(object sender, EventArgs e)
        {
            ok.Text = Cash.ToString();
            agika1.Text = Vein.ToString();
            hhu.Text = VeinPrice.ToString();
            agika.Text = Dev.ToString();
            uhh.Text = DevPrice.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (Cash >= VeinPrice)
            {
                Cash -= VeinPrice;
                Vein++;
                VeinFunc++;
                VeinPrice += 75;
            }
            else
            {
                MessageBox.Show("You dont have enough money!, Grind more to get money.");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Cash >= DevPrice)
            {
                Cash -= DevPrice;
                Dev++;
                DevPrice += 100;
                DevFunc += 5;
                Drill.Start();
            }
            else
            {
                MessageBox.Show("You dont have enough money!, Grind more to get money.");
            }
        }

        private void Drill_Tick(object sender, EventArgs e)
        {
            Cash += DevFunc;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            Cash *= Cash;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Cash = Properties.Settings.Default["cash"].GetHashCode();
            MessageBox.Show("work!!");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            Settings.Default["Cash"] = Cash;
            Properties.Settings.Default.Save();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Settings.Default["Cash"] = Cash;
            Properties.Settings.Default.Save();

        }
    }
}
