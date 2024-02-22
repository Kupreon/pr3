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
    public partial class frmGradoviIB220235 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();

        DrzavaIB220235 drzava = new DrzavaIB220235();

        List<GradIB220235> gradoviPodaci;
        public frmGradoviIB220235(DrzavaIB220235 izabranaDrzava)
        {
            InitializeComponent();

            drzava = izabranaDrzava;
            pbZastava.Image = Ekstenzije.ToImage(drzava.Zastava);
            lbImeDrzave.Text = drzava.Naziv;


            gradoviPodaci = db.GradoviIB220235.Where(x => x.DrzavaId == drzava.Id).ToList();
        }

        public void frmGradoviIB220235_Load(object sender, EventArgs e)
        {
            ucitajDgvPodaci();
            tbInfo.ScrollBars = ScrollBars.Vertical;
        }

        public void ucitajDgvPodaci()
        {
            var gradovi = db.GradoviIB220235.Where(x => x.DrzavaId == drzava.Id).ToList();

            if (gradovi != null)
            {
                var tabela = new DataTable();

                tabela.Columns.Add("NazivGrada");
                tabela.Columns.Add("Aktivan");
                tabela.Columns.Add("PromjeniStatus");

                for (int i = 0; i < gradovi.Count; i++)
                {
                    var red = tabela.NewRow();
                    red["NazivGrada"] = gradovi[i].Naziv;
                    red["Aktivan"] = gradovi[i].Status;
                    red["PromjeniStatus"] = "Promjeni status";

                    tabela.Rows.Add(red);
                }

                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = tabela;
            }
        }

        public void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                var grad = gradoviPodaci[e.RowIndex];
                grad.Status = !grad.Status;
                db.GradoviIB220235.Update(grad);
                db.SaveChanges();

                ucitajDgvPodaci();
            }
        }

        public void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNazivNovogGrada.Text) && !vecPostojeciGrad(tbNazivNovogGrada.Text))
            {
                GradIB220235 noviGrad = new GradIB220235();
                noviGrad.Naziv = tbNazivNovogGrada.Text;
                noviGrad.Status = true;
                noviGrad.DrzavaId = drzava.Id;

                db.GradoviIB220235.Update(noviGrad);
                db.SaveChanges();

                gradoviPodaci = db.GradoviIB220235.Where(x => x.DrzavaId == drzava.Id).ToList();

                ucitajDgvPodaci();
            }
        }

        public bool vecPostojeciGrad(string noviGrad)
        {
            for(int i = 0; i < gradoviPodaci.Count; i++)
            {
                if (gradoviPodaci[i].Naziv == noviGrad)
                {
                    MessageBox.Show("Grad koji pokusavate dodati je vec unesen!");
                    return true;
                }
            }

            return false;
        }

        public void btnGenerisi_Click(object sender, EventArgs e)
        {
            int brojGradova;

            try
            {
                brojGradova = int.Parse(tbBrojGradova.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Niste unjeli broj gradova!");
                return;
            }

            var thread = new Thread(() => dodaj(brojGradova, cbAktivni.Checked));
            thread.Start();
        }

        public void dodaj(int brojGradova, bool aktivan)
        {
            for(int i = 0; i < brojGradova; i++)
            {
                var g = new GradIB220235();
                g.Naziv = $"Grad {i}";
                g.Status = aktivan;
                g.DrzavaId = drzava.Id;

                db.GradoviIB220235.Add(g);
                db.SaveChanges();

                tbInfo.Text += $"{DateTime.Now.ToString()} -> dodat {g.Naziv} za drzavu {drzava.Naziv}" + Environment.NewLine;

                Thread.Sleep(300);
            }

            BeginInvoke(ucitajDgvPodaci);
            BeginInvoke(generisanjeJeZavrseno);
        }

        public void generisanjeJeZavrseno()
        {
            MessageBox.Show("Generisanje gradova je zavrseno!");
        }
    }
}
