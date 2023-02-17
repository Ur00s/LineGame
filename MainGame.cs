using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Linije_73_2019.Helpers;

namespace Linije_73_2019
{
    public partial class MainGame : Form
    {
        Random random1 = new Random();
        Random randomBoja1 = new Random();

        private ILinija db;
        bool kliknuto;
        int bojaBroj1;
        int bojaBroj2;
        int bojaBroj3;
        int poeni, poeniMax;
        int timeCs, timeSec, timeMin;
        
        Dugme Klikkuglica;
        Rezultati rezForm = new Rezultati();
        
        public MainGame()
        {
            InitializeComponent();
            this.Height = 750;
            dugmeIzbor1.Width = 60;
            dugmeIzbor1.Height = 60;
            dugmeIzbor2.Width = 60;
            dugmeIzbor2.Height = 60;
            dugmeIzbor3.Width = 60;
            dugmeIzbor3.Height = 60;
            poeni = 0;
            timeCs = 0;
            timeSec = 0; 
            timeMin = 0;
            timer1.Enabled = true;
            initIzbor();
            drawTableLayoutPanels();
            db = GameFactory.Game();
        }

        private void drawTableLayoutPanels()
        {
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.Height = 550;
            tableLayoutPanel1.Width = 550;


            tableLayoutPanel1.ColumnCount = 9;
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            for (int i = 0; i < 9; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            }
            
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Dugme dugme = new Dugme(i, j);
                    dugme.BackgroundImage = Properties.Resources.Prazno;
                    dugme.Width = 60;
                    dugme.Height = 60;
                    dugme.Margin = Padding.Empty;
                    tableLayoutPanel1.Controls.Add(dugme);
                }
            }

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                control.MouseClick += new MouseEventHandler(control_MouseClick);
            }

            RandomKugle();
        }

        public void RandomKugle()
        {
            kliknuto = false;
            for(int i = 0; i < 9; i++)
                for(int j = 0; j < 9; j++)
                {
                    tableLayoutPanel1.GetControlFromPosition(i, j).BackgroundImage = Properties.Resources.Prazno;
                    tableLayoutPanel1.GetControlFromPosition(i, j).Tag = BOJA.Prazno;
                }
            int randomBrojI1 = random1.Next(9);
            int randomBrojJ1 = random1.Next(9);
            int randomBrojI2 = random1.Next(9);
            int randomBrojJ2 = random1.Next(9);
            int randomBrojI3 = random1.Next(9);
            int randomBrojJ3 = random1.Next(9);

            while (randomBrojI1 == randomBrojI2 && randomBrojJ1 == randomBrojJ2)
            {
                randomBrojI2 = random1.Next(9);
                randomBrojJ2 = random1.Next(9);
            }
            while ((randomBrojI1 == randomBrojI3 && randomBrojJ1 == randomBrojJ3) || (randomBrojI2 == randomBrojI3 && randomBrojJ2 == randomBrojJ3))
            {
                randomBrojI3 = random1.Next(9);
                randomBrojJ3 = random1.Next(9);
            }
            bojaBroj1 = random1.Next(6);
            if (bojaBroj1 == 0)
            {
                tableLayoutPanel1.GetControlFromPosition(randomBrojI1, randomBrojJ1).BackgroundImage = Properties.Resources.Braon;
                tableLayoutPanel1.GetControlFromPosition(randomBrojI1, randomBrojJ1).Tag = BOJA.Braon;
            }
            else if (bojaBroj1 == 1)
            {
                tableLayoutPanel1.GetControlFromPosition(randomBrojI1, randomBrojJ1).BackgroundImage = Properties.Resources.Crvena;
                tableLayoutPanel1.GetControlFromPosition(randomBrojI1, randomBrojJ1).Tag = BOJA.Crvena;
            }
            else if (bojaBroj1 == 2)
            {
                tableLayoutPanel1.GetControlFromPosition(randomBrojI1, randomBrojJ1).BackgroundImage = Properties.Resources.Ljubicasta;
                tableLayoutPanel1.GetControlFromPosition(randomBrojI1, randomBrojJ1).Tag = BOJA.Ljubicasta;
            }
            else if (bojaBroj1 == 3)
            {
                tableLayoutPanel1.GetControlFromPosition(randomBrojI1, randomBrojJ1).BackgroundImage = Properties.Resources.Plava;
                tableLayoutPanel1.GetControlFromPosition(randomBrojI1, randomBrojJ1).Tag = BOJA.Plava;
            }
            else if (bojaBroj1 == 4)
            {
                tableLayoutPanel1.GetControlFromPosition(randomBrojI1, randomBrojJ1).BackgroundImage = Properties.Resources.SvetloPlava;
                tableLayoutPanel1.GetControlFromPosition(randomBrojI1, randomBrojJ1).Tag = BOJA.SvetloPlava;
            }
            else
            {
                tableLayoutPanel1.GetControlFromPosition(randomBrojI1, randomBrojJ1).BackgroundImage = Properties.Resources.Zelena;
                tableLayoutPanel1.GetControlFromPosition(randomBrojI1, randomBrojJ1).Tag = BOJA.Zelena;
            }
            bojaBroj3 = random1.Next(6);
            if (bojaBroj2 == 0)
            {
                tableLayoutPanel1.GetControlFromPosition(randomBrojI2, randomBrojJ2).BackgroundImage = Properties.Resources.Braon;
                tableLayoutPanel1.GetControlFromPosition(randomBrojI2, randomBrojJ2).Tag = BOJA.Braon;
            }
            else if (bojaBroj2 == 1)
            {
                tableLayoutPanel1.GetControlFromPosition(randomBrojI2, randomBrojJ2).BackgroundImage = Properties.Resources.Crvena;
                tableLayoutPanel1.GetControlFromPosition(randomBrojI2, randomBrojJ2).Tag = BOJA.Crvena;
            }
            else if (bojaBroj2 == 2)
            {
                tableLayoutPanel1.GetControlFromPosition(randomBrojI2, randomBrojJ2).BackgroundImage = Properties.Resources.Ljubicasta;
                tableLayoutPanel1.GetControlFromPosition(randomBrojI2, randomBrojJ2).Tag = BOJA.Ljubicasta;
            }
            else if (bojaBroj2 == 3)
            {
                tableLayoutPanel1.GetControlFromPosition(randomBrojI2, randomBrojJ2).BackgroundImage = Properties.Resources.Plava;
                tableLayoutPanel1.GetControlFromPosition(randomBrojI2, randomBrojJ2).Tag = BOJA.Plava;
            }
            else if (bojaBroj2 == 4)
            {
                tableLayoutPanel1.GetControlFromPosition(randomBrojI2, randomBrojJ2).BackgroundImage = Properties.Resources.SvetloPlava;
                tableLayoutPanel1.GetControlFromPosition(randomBrojI2, randomBrojJ2).Tag = BOJA.SvetloPlava;
            }
            else
            {
                tableLayoutPanel1.GetControlFromPosition(randomBrojI2, randomBrojJ2).BackgroundImage = Properties.Resources.Zelena;
                tableLayoutPanel1.GetControlFromPosition(randomBrojI2, randomBrojJ2).Tag = BOJA.Zelena;
            }
            if (bojaBroj3 == 0)
            {
                tableLayoutPanel1.GetControlFromPosition(randomBrojI3, randomBrojJ3).BackgroundImage = Properties.Resources.Braon;
                tableLayoutPanel1.GetControlFromPosition(randomBrojI3, randomBrojJ3).Tag = BOJA.Braon;
            }
            else if (bojaBroj3 == 1)
            {
                tableLayoutPanel1.GetControlFromPosition(randomBrojI3, randomBrojJ3).BackgroundImage = Properties.Resources.Crvena;
                tableLayoutPanel1.GetControlFromPosition(randomBrojI3, randomBrojJ3).Tag = BOJA.Crvena;
            }
            else if (bojaBroj3 == 2)
            {
                tableLayoutPanel1.GetControlFromPosition(randomBrojI3, randomBrojJ3).BackgroundImage = Properties.Resources.Ljubicasta;
                tableLayoutPanel1.GetControlFromPosition(randomBrojI3, randomBrojJ3).Tag = BOJA.Ljubicasta;
            }
            else if (bojaBroj3 == 3)
            {
                tableLayoutPanel1.GetControlFromPosition(randomBrojI3, randomBrojJ3).BackgroundImage = Properties.Resources.Plava;
                tableLayoutPanel1.GetControlFromPosition(randomBrojI3, randomBrojJ3).Tag = BOJA.Plava;
            }
            else if (bojaBroj3 == 4)
            {
                tableLayoutPanel1.GetControlFromPosition(randomBrojI3, randomBrojJ3).BackgroundImage = Properties.Resources.SvetloPlava;
                tableLayoutPanel1.GetControlFromPosition(randomBrojI3, randomBrojJ3).Tag = BOJA.SvetloPlava;
            }
            else
            {
                tableLayoutPanel1.GetControlFromPosition(randomBrojI3, randomBrojJ3).BackgroundImage = Properties.Resources.Zelena;
                tableLayoutPanel1.GetControlFromPosition(randomBrojI3, randomBrojJ3).Tag = BOJA.Zelena;
            }
        }

        private void postaviNoveKugle()
        {
            kliknuto = false;

            int randomBrojI1 = random1.Next(9);
            int randomBrojJ1 = random1.Next(9);
            int randomBrojI2 = random1.Next(9);
            int randomBrojJ2 = random1.Next(9);
            int randomBrojI3 = random1.Next(9);
            int randomBrojJ3 = random1.Next(9);

            while(!tableLayoutPanel1.GetControlFromPosition(randomBrojI1, randomBrojJ1).Tag.Equals(BOJA.Prazno))
            {
                randomBrojI1 = random1.Next(9);
                randomBrojJ1 = random1.Next(9);
            }
            while (!tableLayoutPanel1.GetControlFromPosition(randomBrojI2, randomBrojJ2).Tag.Equals(BOJA.Prazno))
            {
                randomBrojI2 = random1.Next(9);
                randomBrojJ2 = random1.Next(9);
            }
            while (!tableLayoutPanel1.GetControlFromPosition(randomBrojI3, randomBrojJ3).Tag.Equals(BOJA.Prazno))
            {
                randomBrojI3 = random1.Next(9);
                randomBrojJ3 = random1.Next(9);
            }
            tableLayoutPanel1.GetControlFromPosition(randomBrojI1, randomBrojJ1).BackgroundImage = dugmeIzbor1.BackgroundImage;
            tableLayoutPanel1.GetControlFromPosition(randomBrojI1, randomBrojJ1).Tag = dugmeIzbor1.Tag;
            tableLayoutPanel1.GetControlFromPosition(randomBrojI2, randomBrojJ2).BackgroundImage = dugmeIzbor2.BackgroundImage;
            tableLayoutPanel1.GetControlFromPosition(randomBrojI2, randomBrojJ2).Tag = dugmeIzbor2.Tag;
            tableLayoutPanel1.GetControlFromPosition(randomBrojI3, randomBrojJ3).BackgroundImage = dugmeIzbor3.BackgroundImage;
            tableLayoutPanel1.GetControlFromPosition(randomBrojI3, randomBrojJ3).Tag = dugmeIzbor3.Tag;
            proveraRedova();
            proveraKolona();
            proveraGlavneDijagonale();
            //proveraSporedneDijagonale();
        }

        private void initIzbor()
        {
            randomBoja1 = new Random();
            int bojaBroj1 = randomBoja1.Next(6);
            int bojaBroj2 = randomBoja1.Next(6);
            int bojaBroj3 = randomBoja1.Next(6);

            if (bojaBroj1 == 0)
            {
                dugmeIzbor1.BackgroundImage = Properties.Resources.Braon;
                dugmeIzbor1.Tag = BOJA.Braon;
            }
            else if (bojaBroj1 == 1)
            {
                dugmeIzbor1.BackgroundImage = Properties.Resources.Crvena;
                dugmeIzbor1.Tag = BOJA.Crvena;
            }
            else if (bojaBroj1 == 2)
            {
                dugmeIzbor1.BackgroundImage = Properties.Resources.Ljubicasta;
                dugmeIzbor1.Tag = BOJA.Ljubicasta;
            } 
            else if (bojaBroj1 == 3)
            {
                dugmeIzbor1.BackgroundImage = Properties.Resources.Plava;
                dugmeIzbor1.Tag = BOJA.Plava;
            }
            else if (bojaBroj1 == 4)
            {
                dugmeIzbor1.BackgroundImage = Properties.Resources.SvetloPlava;
                dugmeIzbor1.Tag = BOJA.SvetloPlava;
            }
            else
            {
                dugmeIzbor1.BackgroundImage = Properties.Resources.Zelena;
                dugmeIzbor1.Tag = BOJA.Zelena;
            }

            if (bojaBroj2 == 0)
            {
                dugmeIzbor2.BackgroundImage = Properties.Resources.Braon;
                dugmeIzbor2.Tag = BOJA.Braon;
            }
            else if (bojaBroj2 == 1)
            {
                dugmeIzbor2.BackgroundImage = Properties.Resources.Crvena;
                dugmeIzbor2.Tag = BOJA.Crvena;
            }
            else if (bojaBroj2 == 2)
            {
                dugmeIzbor2.BackgroundImage = Properties.Resources.Ljubicasta;
                dugmeIzbor2.Tag = BOJA.Ljubicasta;
            }
            else if (bojaBroj2 == 3)
            {
                dugmeIzbor2.BackgroundImage = Properties.Resources.Plava;
                dugmeIzbor2.Tag = BOJA.Plava;
            }
            else if (bojaBroj2 == 4)
            {
                dugmeIzbor2.BackgroundImage = Properties.Resources.SvetloPlava;
                dugmeIzbor2.Tag = BOJA.SvetloPlava;
            }
            else
            {
                dugmeIzbor2.BackgroundImage = Properties.Resources.Zelena;
                dugmeIzbor2.Tag = BOJA.Zelena;
            }

            if (bojaBroj3 == 0)
            {
                dugmeIzbor3.BackgroundImage = Properties.Resources.Braon;
                dugmeIzbor3.Tag = BOJA.Braon;
            }
            else if (bojaBroj3 == 1)
            {
                dugmeIzbor3.BackgroundImage = Properties.Resources.Crvena;
                dugmeIzbor3.Tag = BOJA.Crvena;
            }
            else if (bojaBroj3 == 2)
            {
                dugmeIzbor3.BackgroundImage = Properties.Resources.Ljubicasta;
                dugmeIzbor3.Tag = BOJA.Ljubicasta;
            }
            else if (bojaBroj3 == 3)
            {
                dugmeIzbor3.BackgroundImage = Properties.Resources.Plava;
                dugmeIzbor3.Tag = BOJA.Plava;
            }
            else if (bojaBroj3 == 4)
            {
                dugmeIzbor3.BackgroundImage = Properties.Resources.SvetloPlava;
                dugmeIzbor3.Tag = BOJA.SvetloPlava;
            }
            else
            {
                dugmeIzbor3.BackgroundImage = Properties.Resources.Zelena;
                dugmeIzbor3.Tag = BOJA.Zelena;
            }
        }

        private void ubaciUBazu()
        {
            rezForm.dataGridView1.Rows.Clear();

            int bodovi = poeni;
            String vreme = minuti.Text + " : " + sekunde.Text;
            DateTime datum = DateTime.Now;
            LinijaDb.IdStatic++;
            db.ubaciRezulatate(LinijaDb.IdStatic, bodovi, vreme, datum);
        }


        private void kraj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void novaIgra_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Да ли желиш нову игру?", "Нова игра", buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign, true);
            if(result == DialogResult.Yes)
            {
                DialogResult result2 = MessageBox.Show("Да ли желиш да сачуваш игру?", "Нова игра", buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign, true);
                if (result2 == DialogResult.Yes)
                {
                    ubaciUBazu();
                }
                timeCs = 0;
                timeSec = 0;
                poeni = int.Parse(brojPoena.Text);
                poeniMax = int.Parse(brojPoenaNajbolji.Text);
                if (poeniMax < poeni)
                    brojPoenaNajbolji.Text = brojPoena.Text;
                brojPoena.Text = "0";
                poeni = 0;
                RandomKugle();
                initIzbor();
            }
        }

        private bool proveraRedova()
        {
            int limit = 10;
            while (limit >= 5)
            {
                for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
                {
                    BOJA lastBoja = BOJA.Prazno;
                    int count = 0;
                    for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                    {
                        Control control = tableLayoutPanel1.GetControlFromPosition(j, i);
                        if (control is Dugme)
                        {
                            BOJA trenBoja = (BOJA)control.Tag;
                            if (!trenBoja.Equals(BOJA.Prazno))
                            {
                                if (trenBoja.Equals(lastBoja))
                                {
                                    count++;
                                }
                                else
                                {
                                    lastBoja = trenBoja;
                                    count = 1;
                                }
                            }
                            else
                            {
                                count = 0;
                            }

                            if (count >= limit)
                            {
                                poeni += count;
                                brojPoena.Text = String.Format("{0:d}", poeni);
                                while (count > 0)
                                {
                                    tableLayoutPanel1.GetControlFromPosition(j - count + 1, i).BackgroundImage = Properties.Resources.Prazno;
                                    tableLayoutPanel1.GetControlFromPosition(j - count + 1, i).Tag = BOJA.Prazno;
                                    count--;
                                }
                                return true;
                            }
                        }
                    }
                }
                limit--;
            }
            return false;
        }

        private bool proveraKolona()
        {
            int limit = 10;
            while (limit >= 5)
            {
                for (int j = 0; j < tableLayoutPanel1.RowCount; j++)
                {
                    BOJA lastBoja = BOJA.Prazno;
                    int count = 0;
                    for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
                    {
                        Control control = tableLayoutPanel1.GetControlFromPosition(j, i);
                        if (control is Dugme)
                        {
                            BOJA trenBoja = (BOJA)control.Tag;
                            if (!trenBoja.Equals(BOJA.Prazno))
                            {
                                if (trenBoja.Equals(lastBoja))
                                {
                                    count++;
                                }
                                else
                                {
                                    lastBoja = trenBoja;
                                    count = 1;
                                }
                            }
                            else
                            {
                                count = 0;
                            }

                            if (count >= limit)
                            {
                                poeni += count;
                                brojPoena.Text = String.Format("{0:d}", poeni);
                                while (count > 0)
                                {
                                    tableLayoutPanel1.GetControlFromPosition(j, i - count + 1).BackgroundImage = Properties.Resources.Prazno;
                                    tableLayoutPanel1.GetControlFromPosition(j, i - count + 1).Tag = BOJA.Prazno;
                                    count--;
                                }
                                return true;
                            }
                        }
                    }
                }
                limit--;
            }
            return false;
        }

        private bool proveraGlavneDijagonale()
        {
            int limit = 10;
            while (limit >= 5)
            {
                for (int i = 0; i <= tableLayoutPanel1.RowCount - limit; i++)
                {
                    BOJA lastBoja = BOJA.Prazno;
                    int count = 1;
                    for (int j = 0; j <= tableLayoutPanel1.ColumnCount - limit; j++)
                    {
                        Control control = tableLayoutPanel1.GetControlFromPosition(i, j);
                        if (control is Dugme)
                        {
                            BOJA trenBoja = (BOJA)control.Tag;
                            if (!trenBoja.Equals(BOJA.Prazno))
                            {
                                while (count < limit && trenBoja.Equals(tableLayoutPanel1.GetControlFromPosition(i + 1, j + 1).Tag))
                                {
                                    i++;
                                    j++;
                                    count++;
                                    control = tableLayoutPanel1.GetControlFromPosition(i, j);
                                    trenBoja = (BOJA)control.Tag;
                                }
                            }

                            if (count >= limit)
                            {
                                poeni += count;
                                brojPoena.Text = String.Format("{0:d}", poeni);
                                while (count >= 0)
                                {
                                    tableLayoutPanel1.GetControlFromPosition(i - count + 1, j - count + 1).BackgroundImage = Properties.Resources.Prazno;
                                    tableLayoutPanel1.GetControlFromPosition(i - count + 1, j - count + 1).Tag = BOJA.Prazno;
                                    count--;
                                }
                                return true;
                            }
                        }
                    }
                }
                limit--;
            }
            return false;
        }

        private bool proveraSporedneDijagonale()
        {
            for (int i = 0; i < tableLayoutPanel1.RowCount - 5; i++)
            {
                BOJA lastBoja = BOJA.Prazno;
                int count = 1;
                for (int j = 0; j < tableLayoutPanel1.ColumnCount - 5; j++)
                {
                    Control control = tableLayoutPanel1.GetControlFromPosition(j, i);
                    if (control is Dugme)
                    {
                        BOJA trenBoja = (BOJA)control.Tag;
                        if (!trenBoja.Equals(BOJA.Prazno))
                        {
                            while (count < 5 && trenBoja.Equals(tableLayoutPanel1.GetControlFromPosition(j - 1, i + 1).Tag))
                            {
                                i--;
                                i++;
                                count++;
                                control = tableLayoutPanel1.GetControlFromPosition(i, j);
                                trenBoja = (BOJA)control.Tag;
                            }
                        }

                        if (count >= 5)
                        {
                            poeni += count;
                            brojPoena.Text = String.Format("{0:d}", poeni);
                            while (count >= 0)
                            {
                                tableLayoutPanel1.GetControlFromPosition(j + count - 1, i - count + 1).BackgroundImage = Properties.Resources.Prazno;
                                tableLayoutPanel1.GetControlFromPosition(j + count - 1, i - count + 1).Tag = BOJA.Prazno;
                                count--;
                            }
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void prikazRezultata(object sender, EventArgs e)
        {

            Rezultati form2 = new Rezultati();

            // show the new form
            form2.Show();

            // hide the current form (optional)
            this.Hide();
        }

        private void dugmeIzbor2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void control_MouseClick(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            
            if (!control.Tag.Equals(BOJA.Prazno))
            {
                if(kliknuto == false)
                {
                    Klikkuglica = (Dugme)control;
                    if (control.Tag.Equals(BOJA.Zelena))
                    {
                        control.BackgroundImage = Properties.Resources.ZelenaIks;
                        control.Tag = BOJA.ZelenaIks;
                    }
                    else if (control.Tag.Equals(BOJA.Braon))
                    {
                        control.BackgroundImage = Properties.Resources.BraonIks_;
                        control.Tag = BOJA.BraonIks;
                    }
                    else if (control.Tag.Equals(BOJA.Crvena))
                    {
                        control.BackgroundImage = Properties.Resources.CrvenaIks;
                        control.Tag = BOJA.CrvenaIks;
                    }
                    else if (control.Tag.Equals(BOJA.Ljubicasta))
                    {
                        control.BackgroundImage = Properties.Resources.LjubicastaIks;
                        control.Tag = BOJA.LjubicastaIks;
                    }
                    else if (control.Tag.Equals(BOJA.Plava))
                    {
                        control.BackgroundImage = Properties.Resources.PlavaIks;
                        control.Tag = BOJA.PlavaIks;
                    }
                    else if (control.Tag.Equals(BOJA.SvetloPlava))
                    {
                        control.BackgroundImage = Properties.Resources.SvetloPlavaIks;
                        control.Tag = BOJA.SvetloPlavaIks;
                    }
                    kliknuto = true;
                }
                else
                {
                    foreach(Control contr in tableLayoutPanel1.Controls)
                    {
                        if (contr.Tag.Equals(BOJA.BraonIks))
                        {
                            contr.BackgroundImage = Properties.Resources.Braon;
                            contr.Tag = BOJA.Braon;
                        }
                        else if (contr.Tag.Equals(BOJA.CrvenaIks))
                        {
                            contr.BackgroundImage = Properties.Resources.Crvena;
                            contr.Tag = BOJA.Crvena;
                        }
                        else if (contr.Tag.Equals(BOJA.LjubicastaIks))
                        {
                            contr.BackgroundImage = Properties.Resources.Ljubicasta;
                            contr.Tag = BOJA.Ljubicasta;
                        }
                        else if (contr.Tag.Equals(BOJA.PlavaIks))
                        {
                            contr.BackgroundImage = Properties.Resources.Plava;
                            contr.Tag = BOJA.Plava;
                        }
                        else if (contr.Tag.Equals(BOJA.SvetloPlavaIks))
                        {
                            contr.BackgroundImage = Properties.Resources.SvetloPlava;
                            contr.Tag = BOJA.SvetloPlava;
                        }
                        else if (contr.Tag.Equals(BOJA.ZelenaIks))
                        {
                            contr.BackgroundImage = Properties.Resources.Zelena;
                            contr.Tag = BOJA.Zelena;
                        }
                    }

                    Klikkuglica = (Dugme)control;

                    if (control.Tag.Equals(BOJA.Zelena))
                    {
                        control.BackgroundImage = Properties.Resources.ZelenaIks;
                        control.Tag = BOJA.ZelenaIks;
                    }
                    else if (control.Tag.Equals(BOJA.Braon))
                    {
                        control.BackgroundImage = Properties.Resources.BraonIks_;
                        control.Tag = BOJA.BraonIks;
                    }
                    else if (control.Tag.Equals(BOJA.Crvena))
                    {
                        control.BackgroundImage = Properties.Resources.CrvenaIks;
                        control.Tag = BOJA.CrvenaIks;
                    }
                    else if (control.Tag.Equals(BOJA.Ljubicasta))
                    {
                        control.BackgroundImage = Properties.Resources.LjubicastaIks;
                        control.Tag = BOJA.LjubicastaIks;
                    }
                    else if (control.Tag.Equals(BOJA.Plava))
                    {
                        control.BackgroundImage = Properties.Resources.PlavaIks;
                        control.Tag = BOJA.PlavaIks;
                    }
                    else if (control.Tag.Equals(BOJA.SvetloPlava))
                    {
                        control.BackgroundImage = Properties.Resources.SvetloPlavaIks;
                        control.Tag = BOJA.SvetloPlavaIks;
                    }
                }
            }
            else
            {
                if(kliknuto == true)
                {
                    control.BackgroundImage = Klikkuglica.BackgroundImage;
                    control.Tag = Klikkuglica.Tag;

                    if (control.Tag.Equals(BOJA.BraonIks))
                    {
                        control.BackgroundImage = Properties.Resources.Braon;
                        control.Tag = BOJA.Braon;
                    }
                    else if (control.Tag.Equals(BOJA.CrvenaIks))
                    {
                        control.BackgroundImage = Properties.Resources.Crvena;
                        control.Tag = BOJA.Crvena;
                    }
                    else if (control.Tag.Equals(BOJA.LjubicastaIks))
                    {
                        control.BackgroundImage = Properties.Resources.Ljubicasta;
                        control.Tag = BOJA.Ljubicasta;
                    }
                    else if (control.Tag.Equals(BOJA.PlavaIks))
                    {
                        control.BackgroundImage = Properties.Resources.Plava;
                        control.Tag = BOJA.Plava;
                    }
                    else if (control.Tag.Equals(BOJA.SvetloPlavaIks))
                    {
                        control.BackgroundImage = Properties.Resources.SvetloPlava;
                        control.Tag = BOJA.SvetloPlava;
                    }
                    else if (control.Tag.Equals(BOJA.ZelenaIks))
                    {
                        control.BackgroundImage = Properties.Resources.Zelena;
                        control.Tag = BOJA.Zelena;
                    }

                    Klikkuglica.BackgroundImage = Properties.Resources.Prazno;
                    Klikkuglica.Tag = BOJA.Prazno;
                    postaviNoveKugle();
                    initIzbor();
                }
            }
        }

        private void dugmeIzbor1_Click(object sender, EventArgs e)
        {

        }

        private bool daLiJeKraj()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control.Tag.Equals(BOJA.Prazno))
                    return false;
            }
            return true;
        }

        private void tickTimer(object sender, EventArgs e)
        {
            timer1.Start();
            timeCs++;

            if(timeCs >= 100)
            {
                timeSec++;
                timeCs = 0;

                if(timeSec >= 60)
                {
                    timeMin++;
                    timeSec = 0;
                }
            }
            DrawTime();
        }
        private void DrawTime()
        {
            sekunde.Text = String.Format("{0:d}", timeSec);
            minuti.Text = String.Format("{0:d}", timeMin);
        }
    }
}
