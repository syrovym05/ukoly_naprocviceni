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
    public partial class u3 : Form
    {
        public u3()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int liche = 0, minimum = int.MaxValue,maximum = int.MinValue, cif_soucet=0;
            int cislo = 0;
            long soucin = 1;
            bool je_cislo = true, je_velke = false;
            
            foreach (string line in textBox1.Lines)
            {
                try
                {
                    je_cislo = true;
                    cislo = int.Parse(line);
                }
                catch
                {
                    je_cislo = false;
                }
                if (je_cislo)
                {
                    if (cislo % 2 != 0) liche++;
                    if (minimum > cislo) minimum = cislo;
                    if (maximum < cislo) maximum = cislo;
                    try
                    {
                        if (cislo >= 20 || cislo < 5) soucin *= cislo;
                    }
                    catch
                    {
                        je_velke = true;
                    }                    
                    
                }
            }

            for (int i = maximum; i > 0; i /= 10) cif_soucet += i % 10;
            
            string _soucin = "\nc) Součin čísel mimo <5;20): " + soucin.ToString();
            if (je_velke) _soucin = "\nc)ZADAL JSI MOC ČÍSEL --> SOUČIN JE MOC VELKÝ ";
            MessageBox.Show("Výsledky:\na) Počet lichých čísel: " + liche + "\nb) Minimální číslo: " + minimum + "\nc) Součin čísel mimo <5;20): " + soucin + "\nd) Ciferný součet maxima("+maximum+"): " + cif_soucet, "Výsledky", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pomocí cyklu foreach procházejte všechny řádky komponenty TextBox. Řádky obsahují čísla.\na.Vypište počet čísel lichých\nb.Vypište minimální číslo\nc.Vypište součin čísel neležících v intervalu < 5; 20)\nd.Zjistěte ciferný součet maximálního čísla\n", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
