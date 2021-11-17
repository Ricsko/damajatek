using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace damajatek_KKG_SZR_LA
{
    public partial class Form1 : Form
    {
        static string nev1 = "";
        static string nev2 = "";
        static int startIndex = 0;
        static string[] szin = new string[] { "fekete", "feher" };
        static PictureBox aktBabu;

        static PictureBox[,] jatekter = new PictureBox[8, 8];

        public Form1()
        {
            InitializeComponent();
        }

        private void start_BTN_Click(object sender, EventArgs e)
        {
            nevellenorzes();
            pictureBox1.Visible = false;
        }

        private void nevellenorzes()
        {
            /*nev1 = jatekos1_TBOX.Text;
            nev2 = jatekos2_TBOX.Text;
            if(nev1 == "" || nev2 == "")
            {
                MessageBox.Show($"Hiányzó adat");
            }
            else
            {
                
            }*/
            palyageneralas();
        }

        private void palyageneralas()
        {

            int x = 150;
            int y = 30;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    PictureBox palya = new PictureBox();
                    palya.Size = new Size(50, 50);
                    palya.Location = new Point(x + 6, y);
                    palya.Name = $"{i}_{j}";
                    palya.MouseClick += new MouseEventHandler(mozgatasClick);
                    if ((i + j) % 2 == 0)
                    {
                        palya.BackColor = Color.FromArgb(255, 216, 176);
                    }
                    else
                    {
                        palya.BackColor = Color.FromArgb(69, 40, 36);
                        palya.Enabled = false;
                    }
                    this.Controls.Add(palya);
                    jatekter[i, j] = palya;

                    x += 50;
                }

                x = 150;
                y += 50;
            }
            aktBabu = new PictureBox();

            gombeltuntetes();
            babuk();
        }

        private void mozgatasClick(object sender, MouseEventArgs e)
        {
            PictureBox klikkelt = sender as PictureBox;
            string aktszin = szin[startIndex];
            int col = Convert.ToInt32(klikkelt.Name.Split('_')[0]);
            int row = Convert.ToInt32(klikkelt.Name.Split('_')[1]);

            //SORON LÉVŐ JÁTÉKOS ELLENÖRZÉS SZÍN!!

            if (klikkelt.Image != null)
            {
                if (klikkelt.Name == aktBabu.Name)
                {
                    aktBabu.Image = null;
                    aktBabu.Name = "";
                    jatekter[col, row].BackColor = Color.FromArgb(255, 216, 176);
                }
                else
                {
                    aktBabu.Name = klikkelt.Name;
                    aktBabu.Image = klikkelt.Image;
                    jatekter[col, row].BackColor = Color.Green;
                }
                
            }
            else if (aktBabu.Image == null)
            {
                MessageBox.Show("Nincs kiválasztott bábú!");
            }
            else if (klikkelt.Image == null && aktBabu.Image != null)
            {
                klikkelt.Image = aktBabu.Image;
                klikkelt.Name += $"_{aktBabu.Name.Split('_')[2]}";
                
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (jatekter[i, j].Name == aktBabu.Name)
                        {
                            jatekter[i, j].Name = $"{i}_{j}";
                            jatekter[i, j].Image = null;
                            jatekter[i, j].BackColor = Color.FromArgb(255, 216, 176);
                        }
                    }
                }
                
                aktBabu.Image = null;
                aktBabu.Name = "";
                startIndex++;
            }
            //AKTUÁLIS SZÍN
            startIndex = startIndex % 2;
            MessageBox.Show(aktszin);
        }

        private void gombeltuntetes()
        {
            label1.Visible = false;
            label2.Visible = false;
            jatekos1_TBOX.Visible = false;
            jatekos2_TBOX.Visible = false;
            start_BTN.Visible = false;
            szabalyok_BTN.Visible = false;
        }

        private void babuk()
        {
            //FEKETE BÁBÚ ELHELYEZÉS
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        jatekter[i, j].Image = imagelist.Images[0];
                        jatekter[i, j].Name += "_fekete";
                    }
                }
            }

            //FEHÉR BÁBÚ ELHELYEZÉS
            for (int i = 5; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        jatekter[i, j].Image = imagelist.Images[1];
                        jatekter[i, j].Name += "_feher";
                    }
                }
            }
        }

        private void szabalyok_BTN_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }
    }
}
