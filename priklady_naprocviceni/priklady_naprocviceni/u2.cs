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
    public partial class u2 : Form
    {
        public u2()
        {
            InitializeComponent();
            listBox1.Items.Clear();
            label1.Text = "\nVyber jak chceš ukončit cyklus";
            label4.Text = "Zadej počet čísel\nk vygenerování";
        }
       

        private void forBreak_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int pocetNahodnych = Convert.ToInt32(numericUpDown1.Value);

            listBox1.Items.Clear();
            for (int i = 0; i < pocetNahodnych; i++)
            {
                int cislo = rnd.Next(-5, 21);
                listBox1.Items.Add(cislo);
                if (cislo > 2 && cislo <= 5) break;
                if(i == pocetNahodnych-1) MessageBox.Show("Cyklus se neukončíl pomocí break, ale protože se vygenerovalo " + pocetNahodnych + " čísel a cyklus se tedy nemohl ukončit", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //listBox1.Size = new Size(147,20+(i+1)*16);
            }

        }
       
        private void forBool_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int pocetNahodnych = Convert.ToInt32(numericUpDown1.Value);
            bool konec = false;

            listBox1.Items.Clear();
            for (int i = 0; i < pocetNahodnych && konec == false; i++)
            {
                int cislo = rnd.Next(-5, 21);
                listBox1.Items.Add(cislo);
                konec = cislo > 2 && cislo <= 5;
            }
            if (konec == false) MessageBox.Show("Cyklus se neukončíl pomocí bool, ale protože se vygenerovalo " + pocetNahodnych + " čísel a cyklus se tedy nemohl ukončit", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void whileBool_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int pocetNahodnych = Convert.ToInt32(numericUpDown1.Value);
            int i = 0;
            bool konec = false;

            listBox1.Items.Clear();
            while (i < pocetNahodnych && konec == false)
            {
                int cislo = rnd.Next(-5, 21);
                listBox1.Items.Add(cislo);
                konec = cislo > 2 && cislo <= 5;
                i++;
            }
            if (konec == false) MessageBox.Show("Cyklus se neukončíl pomocí bool, ale protože se vygenerovalo " + pocetNahodnych + " čísel a cyklus se tedy nemohl ukončit", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dowhileBool_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int pocetNahodnych = Convert.ToInt32(numericUpDown1.Value);
            int i = -1;
            bool konec = false;

            listBox1.Items.Clear();
            do
            {
                i++;
                int cislo = rnd.Next(-5, 21);
                listBox1.Items.Add(cislo);
                konec = cislo > 2 && cislo <= 5;                
            } while (i < pocetNahodnych && konec == false) ;
            if (konec == false) MessageBox.Show("Cyklus se neukončíl pomocí bool, ale protože se vygenerovalo " + pocetNahodnych + " čísel a cyklus se tedy nemohl ukončit", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Na vstupu je dáno celé číslo n a n-prvková posloupnost náhodných reálných čísel z intervalu <-5;20). Čísla zobrazuj do ListBoxu. Zjistěte, zda posloupnost obsahuje číslo z intervalu (2;5>. Cyklus časově optimalizujte (po nalezení čísla z intervalu cyklus předčasně ukončete). Projekt bude obsahovat 4 tlačítka. V prvním tlačítku použijte cyklus for a cyklus předčasně ukončete pomocí break. V druhém tlačítku použijte cyklus for a cyklus předčasně ukončete pomocí bool. V třetím tlačítku použijte cyklus while a cyklus předčasně ukončete pomocí bool. Ve čtvrtém tlačítku použijte cyklus do while a cyklus předčasně ukončete pomocí bool", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
