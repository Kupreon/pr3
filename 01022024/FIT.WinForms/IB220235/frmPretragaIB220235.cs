using FIT.Data;
using FIT.Data.IB220235;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
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
    public partial class frmPretragaIB220235 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmPretragaIB220235()
        {
            InitializeComponent();
        }

        private void frmPretragaIB220235_Load(object sender, EventArgs e)
        {
            cmbDrzava.DataSource = db.DrzaveIB220235.ToList();
            ucitajCmbGrad();
        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajCmbGrad();
        }
        private void cmbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajDgvPodaci();
        }

        public void ucitajCmbGrad()
        {
            var drzava = cmbDrzava.Text;

            cmbGrad.DataSource = null;
            cmbGrad.DataSource = db.GradoviIB220235.Where(x => x.Drzava.Naziv == drzava).ToList();

            ucitajDgvPodaci();
        }

        public void ucitajDgvPodaci()
        {
            var studenti = db.Studenti.Where(x => x.Grad.Naziv == cmbGrad.Text).ToList();

            if (studenti != null)
            {
                var tabela = new DataTable();

                tabela.Columns.Add("Ime");
                tabela.Columns.Add("Prezime");
                tabela.Columns.Add("Grad");
                tabela.Columns.Add("Drzava");
                tabela.Columns.Add("Prosjek");

                for (int i = 0; i < studenti.Count; i++)
                {
                    var red = tabela.NewRow();
                    red["Ime"] = studenti[i].Ime;
                    red["Prezime"] = studenti[i].Prezime;
                    red["Grad"] = studenti[i].Grad.Naziv;
                    red["Drzava"] = studenti[i].Grad.Drzava.Naziv;
                    red["Prosjek"] = prosjekOcjena(studenti[i]).ToString();

                    tabela.Rows.Add(red);
                }

                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = tabela;
            }
        }

        public float prosjekOcjena(Student student)
        {
            float prosjek = 0;

            int brojOcjena = db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).Count();
            var ocjene = db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).ToList();

            if (brojOcjena == 0)
                return 5;

            for (int i = 0; i < brojOcjena; i++)
                prosjek += ocjene[i].Ocjena;

            return prosjek / brojOcjena;
        }

    }
}
