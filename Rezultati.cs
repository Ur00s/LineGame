using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linije_73_2019
{
    public partial class Rezultati : Form
    {
        LinijaDb db = new LinijaDb();
        List<Result> rezultatiList = new List<Result>();

        public Rezultati()
        {
            InitializeComponent();
        }

        private void Rezultati_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainGame form2 = new MainGame();

            form2.Show();

            Hide();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rezultatiList = db.dajSveRezultate();

            int Id, bodovi;
            string vreme;
            DateTime datum;

            foreach (Result res in rezultatiList)
            {
                int rowIndex = dataGridView1.Rows.Add();

                Id = res.Id;
                bodovi = res.Points;
                vreme = res.Timer;
                datum = res.Datum;
                
                dataGridView1.Rows[rowIndex].Cells[0].Value = bodovi;
                dataGridView1.Rows[rowIndex].Cells[1].Value = vreme;
                dataGridView1.Rows[rowIndex].Cells[2].Value = datum;
            }

            if (rezultatiList.Count == 0)
                MessageBox.Show("Нема резултата у табели");
        }
    }
}
