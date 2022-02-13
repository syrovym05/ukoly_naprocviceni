using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace priklady_naprocviceni
{
    public partial class u1 : Form
    {
        public u1()
        {
            InitializeComponent();
            listBox1.Items.Clear();
            { label1.Text = ""; label2.Text = ""; label3.Text = ""; }
            label4.Text = "Zadej počet čísel\nk vygenerování";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int pocetNahodnych = Convert.ToInt32(numericUpDown1.Value);
            int maximum = -16, minimum = 61;
            int poziceMax =0, poziceMin =0 ;
            int pocetMax = 1, pocetMin = 1;
            double prumer, soucet = 0, pocet = 0;            

            listBox1.Items.Clear();
            for (int i = 0; i < pocetNahodnych; i++)
            {
                int cislo = rnd.Next(0,6);
                soucet += cislo;
               
                if (cislo <= minimum)
                {
                    if (cislo == minimum) pocetMin++;
                    else
                    {
                        pocetMin = 1;
                        poziceMin = i + 1;
                    }
                    minimum = cislo;                                                            
                }
                if (cislo >= maximum)
                {
                    if (cislo == maximum) pocetMax++;
                    else pocetMax = 1;
                    poziceMax = i + 1;
                    maximum = cislo;
                }
                pocet++;
                listBox1.Items.Add((i+1)+")\t  "+cislo+"");                
            }
            pocet -= pocetMax + pocetMin;
            soucet -= pocetMax * maximum + pocetMin * minimum;
            
            prumer = Math.Round(soucet / pocet, 3);
            label1.Text = "První pozice minimálního čísla je: " + poziceMin + "\nVyskytuje se v posloupnosti " + pocetMin + "x";
            label2.Text = "Poslední pozice maximálního čísla je: " + poziceMax + "\nVyskytuje se v posloupnosti " + pocetMax + "x";
            label3.Text = pocet > 0 ?  "Průměr čísel bez nejmeších a\nnejvětších hodnot je: " + prumer : "Průměr nelze vypočítat!!";
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {            
            MessageBox.Show("Na vstupu je posloupnost N náhodných celých čísel z intervalu <-15,60). Čísla vypište do ListBoxu. Vypište maximum posloupnosti a jeho pořadí v posloupnosti. Pokud je těchto hodnot více, vypište pořadí posledního z nich, dále vypište i kolikrát se v posloupnosti maximum vyskytuje. Vypište minimum posloupnosti a jeho pořadí v posloupnosti. Pokud je těchto hodnot více, vypište pořadí prvního z nich, dále vypište i kolikrát se v posloupnosti minimum vyskytuje. Dále spočítejte aritmetický průměr bez všech minimálních a maximálních čísel.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
