using FIT.Data.IB220235;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using FIT.WinForms.Izvjestaji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB220235
{
    public partial class frmDrzaveIB220235 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmDrzaveIB220235()
        {
            InitializeComponent();
        }

        public void DrzaveIB220235_Load(object sender, EventArgs e)
        {
            tsslTrenutnoVrijeme.Text = "Trenutno vrijeme: " + DateTime.Now.ToString("HH.mm.ss");

            dgvPodaci.AutoGenerateColumns = false;

            ucitajDgvPodaci();
        }

        public void frmPrintaj_Click(object sender, EventArgs e)
        {
            var forma = new frmIzvjestaji();
            forma.Show();
        }

        public void btnNovaDrzava_Click(object sender, EventArgs e)
        {
            var forma = new frmNovaDrzavaIB220235(null);
            forma.ShowDialog();
            ucitajDgvPodaci();
        }

        public void ucitajDgvPodaci()
        {
            var drzave = db.DrzaveIB220235.ToList();

            if (drzave != null)
            {
                var tabela = new DataTable();

                tabela.Columns.Add("Zastava", typeof(Image));
                tabela.Columns.Add("Drzava");
                tabela.Columns.Add("BrojGradova");
                tabela.Columns.Add("Aktivna");
                tabela.Columns.Add("Gradovi");

                for (int i = 0; i < drzave.Count; i++)
                {
                    var red = tabela.NewRow();
                    red["Zastava"] = Ekstenzije.ToImage(drzave[i].Zastava);
                    red["Drzava"] = drzave[i].Naziv;
                    red["BrojGradova"] = db.GradoviIB220235.Where(x => x.DrzavaId == drzave[i].Id).Count();
                    red["Aktivna"] = drzave[i].Status;
                    red["Gradovi"] = "Gradovi";

                    tabela.Rows.Add(red);
                }

                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = tabela;
            }
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                DrzavaIB220235 drzava = db.DrzaveIB220235.Where(x => x.Id == e.RowIndex + 1).First();

                var forma = new frmGradoviIB220235(drzava);
                forma.ShowDialog();

                ucitajDgvPodaci();
            }
            else
            {
                DrzavaIB220235 drzava = db.DrzaveIB220235.Where(x => x.Id == e.RowIndex + 1).First();

                var forma = new frmNovaDrzavaIB220235(drzava);
                forma.ShowDialog();

                ucitajDgvPodaci();
            }
        }
    }
}
