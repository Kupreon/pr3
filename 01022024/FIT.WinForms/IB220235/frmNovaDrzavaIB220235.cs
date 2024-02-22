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
    public partial class frmNovaDrzavaIB220235 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();

        DrzavaIB220235 drzava = new DrzavaIB220235();

        public frmNovaDrzavaIB220235(DrzavaIB220235 drzava)
        {
            InitializeComponent();

            if(drzava != null)
            {
                pbZastava.Image = Ekstenzije.ToImage(drzava.Zastava);
                tbNaziv.Text = drzava.Naziv;
                cbAktivna.Checked = drzava.Status;
            }
        }

        public void frmNovaDrzavaIB220235_Load(object sender, EventArgs e)
        {

        }

        public void pbZastava_DoubleClick(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbZastava.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        public void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                drzava.Zastava = Ekstenzije.ToByteArray(pbZastava.Image);
                drzava.Status = cbAktivna.Checked;
                drzava.Naziv = tbNaziv.Text;

                db.DrzaveIB220235.Update(drzava);
                db.SaveChanges();

                this.Close();
            }
        }

        public bool validacija()
        {
            return Validator.ProvjeriUnos(pbZastava, errorProvider1, Kljucevi.ReqiredValue) && Validator.ProvjeriUnos(tbNaziv, errorProvider1, Kljucevi.ReqiredValue);
        }
    }
}
