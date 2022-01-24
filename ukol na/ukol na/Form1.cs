using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_na
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void prevod_Click(object sender, EventArgs e)
        {
            double aktualnicislo = 0;
            double pocet = 0;
            double soucet = 0;
            int pocetciselvintervalu = 0;
            double minimum = 100000000;
            int cislo3prvni = 0;
            int cislo3posledni = 0;
            bool cislo3 = false;
            bool catch1 = false;

            for (int i = 0; i < textBox1.Lines.Length ;i++, pocet++)
            {
                
                try {
                    aktualnicislo = double.Parse(textBox1.Lines[i]);
                    soucet += aktualnicislo; 
                }
                catch
                {
                    MessageBox.Show("v texboxu je nějaká chyba, proto výsledky nemusejí být správně");
                    catch1 = true;
                }

                if(aktualnicislo < minimum)
                {
                    minimum = aktualnicislo;
                }

                if(aktualnicislo >= 5 && aktualnicislo < 30)
                {
                    pocetciselvintervalu++;
                }

                if(aktualnicislo == 3)
                {
                    if (cislo3 == false) cislo3prvni = i;
                    cislo3 = true;
                    cislo3posledni = i;
                }
            }

            labelsoucet.Text = soucet.ToString();
            if(catch1 == false) 
            {
                labelprumer.Text = (soucet / pocet).ToString();
            }
            labelmin.Text = minimum.ToString();
            labelinterval.Text = pocetciselvintervalu.ToString();
            if(cislo3 == false)
            {
                labelprvni3.Text = "neni zde";
                labelposledni3.Text = "neni zde";
            }
            else
            {
                cislo3prvni += 1;
                cislo3posledni += 1;
                labelprvni3.Text = cislo3prvni.ToString();
                labelposledni3.Text = cislo3posledni.ToString();
            }

        }
    }
}
