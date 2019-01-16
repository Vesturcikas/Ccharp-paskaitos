using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_a_uzduotis
{
    public partial class Telelot : Form
    {
        public Telelot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] Melini = { M1, M2, M3, M4, M5 };
            TextBox[] Juodi = { J1, J2, J3, J4, J5 };
            TextBox[] Geltoni = { G1, G2, G3, G4, G5 };
            TextBox[] Raudoni = { R1, R2, R3, R4, R5 };
            TextBox[] Zali = { Z1, Z2, Z3, Z4, Z5 };
                                                
            
            Random ats = new Random();

            int i = 0;
            while (i <Melini.Length)
            {
                string skaicius = ats.Next(1, 15).ToString();
                bool vienodi = false;

                foreach (var item in Melini)
                {
                    if (item.Text==skaicius)
                    {
                        vienodi = true;
                        break;
                    }
                                       
                }

                if (!vienodi)
                {
                    Melini[i].Text = skaicius;
                    i++;
                }

            }
            



        }

        private void Play_Click(object sender, EventArgs e)
        {
            Random ats1 = new Random();
            List<int> skaiciai = new List<int>();
            
            int i = 0;
            while (i < 49)
            {

                int temp = ats1.Next(1, 76);
                bool vienodas = false;

                foreach (var item in skaiciai)
                {
                    if (item == temp)
                    {
                        vienodas = true;
                        break;
                    }

                }

                if (!vienodas)
                {
                    Zaidimas.Text = temp + " ";
                    skaiciai.Add(temp);
                    i++;
                }

            }

        }
    }
           
 }
