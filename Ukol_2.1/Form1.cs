using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_vypocet_Click(object sender, EventArgs e)
        {
            listBoxVystup.Items.Clear();
            int min, max, pocitadlo, x;
            try
            {

                min = int.Parse(textBoxMIN.Text);
                max = int.Parse(textBoxMAX.Text);
                if (min >= max) { 
                    MessageBox.Show("Chyba"); 
                }
                else
                {
                    x = min;
                    while (min <= max)
                    {
                        pocitadlo = 0;
                        x = min;
                        while (x > 0)
                        {
                            if (min % x == 0) { pocitadlo++; }
                            x--;
                        }
                        if (pocitadlo <= 2 && min != 0 && min != 1 && min != 1) { listBoxVystup.Items.Add(min.ToString()); }
                        min++;
                    }

                }
            }
            catch { MessageBox.Show("CHYBA"); }
        }

        public static int NSD(int a, int b)
        {
            if (b == 0) return a;
            return NSD(b, a % b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonVypocet_Click(object sender, EventArgs e)
        {
            listBoxVystup.Items.Clear();
            int min, max, pocitadlo, x;
            try
            {

                min = int.Parse(textBoxMIN.Text);
                max = int.Parse(textBoxMAX.Text);
                if (min >= max) { MessageBox.Show("CHYBA"); }
                else
                {
                    x = min;
                    while (min <= max)
                    {
                        pocitadlo = 0;
                        x = min;
                        while (x > 0)
                        {
                            if (min % x == 0) { pocitadlo++; }
                            x--;
                        }
                        if (pocitadlo <= 2 && min != 0 && min != 1 && min != 1)
                        {
                            listBoxVystup.Items.Add(min.ToString());
                        }
                        min++;
                    }

                }
            }
            catch { MessageBox.Show("CHYBA"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxVystup.Items.Clear();
            int min, max;
            bool poc7 = true;
            try
            {
                min = int.Parse(textBoxMIN.Text);
                max = int.Parse(textBoxMAX.Text);
                if (min >= max) { MessageBox.Show("CHYBA"); }
                else
                {
                    while (min <= max)
                    {
                        if ((min % 7 == 0) && poc7 && min != 0) { 
                            listBoxVystup.Items.Add(min.ToString()); poc7 = false; 
                        }
                        min++;
                    }
                }
            }
            catch { MessageBox.Show("CHYBA"); }

        }
    }
}
