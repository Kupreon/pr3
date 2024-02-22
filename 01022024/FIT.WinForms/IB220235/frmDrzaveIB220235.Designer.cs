namespace FIT.WinForms.IB220235
{
    partial class frmDrzaveIB220235
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPodaci = new DataGridView();
            Zastava = new DataGridViewImageColumn();
            Drzava = new DataGridViewTextBoxColumn();
            BrojGradova = new DataGridViewTextBoxColumn();
            Aktivna = new DataGridViewCheckBoxColumn();
            Gradovi = new DataGridViewButtonColumn();
            btnNovaDrzava = new Button();
            frmPrintaj = new Button();
            statusStrip1 = new StatusStrip();
            tsslTrenutnoVrijeme = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Zastava, Drzava, BrojGradova, Aktivna, Gradovi });
            dgvPodaci.Location = new Point(12, 56);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.RowTemplate.Height = 25;
            dgvPodaci.Size = new Size(776, 248);
            dgvPodaci.TabIndex = 2;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            // 
            // Zastava
            // 
            Zastava.DataPropertyName = "Zastava";
            Zastava.HeaderText = "Zastava";
            Zastava.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Zastava.Name = "Zastava";
            Zastava.ReadOnly = true;
            // 
            // Drzava
            // 
            Drzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Drzava.DataPropertyName = "Drzava";
            Drzava.HeaderText = "Drzava";
            Drzava.Name = "Drzava";
            Drzava.ReadOnly = true;
            // 
            // BrojGradova
            // 
            BrojGradova.DataPropertyName = "BrojGradova";
            BrojGradova.HeaderText = "Broj gradova";
            BrojGradova.Name = "BrojGradova";
            BrojGradova.ReadOnly = true;
            // 
            // Aktivna
            // 
            Aktivna.DataPropertyName = "Aktivna";
            Aktivna.HeaderText = "Aktivna";
            Aktivna.Name = "Aktivna";
            Aktivna.ReadOnly = true;
            // 
            // Gradovi
            // 
            Gradovi.DataPropertyName = "Gradovi";
            Gradovi.HeaderText = "";
            Gradovi.Name = "Gradovi";
            Gradovi.ReadOnly = true;
            Gradovi.Text = "Gradovi";
            Gradovi.ToolTipText = "Gradovi";
            // 
            // btnNovaDrzava
            // 
            btnNovaDrzava.Font = new Font("Segoe UI", 12F);
            btnNovaDrzava.Location = new Point(658, 18);
            btnNovaDrzava.Name = "btnNovaDrzava";
            btnNovaDrzava.Size = new Size(130, 32);
            btnNovaDrzava.TabIndex = 3;
            btnNovaDrzava.Text = "Nova drzava";
            btnNovaDrzava.UseVisualStyleBackColor = true;
            btnNovaDrzava.Click += btnNovaDrzava_Click;
            // 
            // frmPrintaj
            // 
            frmPrintaj.Font = new Font("Segoe UI", 12F);
            frmPrintaj.Location = new Point(658, 310);
            frmPrintaj.Name = "frmPrintaj";
            frmPrintaj.Size = new Size(130, 32);
            frmPrintaj.TabIndex = 3;
            frmPrintaj.Text = "Printaj";
            frmPrintaj.UseVisualStyleBackColor = true;
            frmPrintaj.Click += frmPrintaj_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslTrenutnoVrijeme });
            statusStrip1.Location = new Point(0, 369);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslTrenutnoVrijeme
            // 
            tsslTrenutnoVrijeme.Name = "tsslTrenutnoVrijeme";
            tsslTrenutnoVrijeme.Size = new Size(102, 17);
            tsslTrenutnoVrijeme.Text = "Trenutno vrijeme: ";
            // 
            // frmDrzaveIB220235
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 391);
            Controls.Add(statusStrip1);
            Controls.Add(frmPrintaj);
            Controls.Add(btnNovaDrzava);
            Controls.Add(dgvPodaci);
            Name = "frmDrzaveIB220235";
            Text = "Drzave";
            Load += DrzaveIB220235_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPodaci;
        private Button btnNovaDrzava;
        private Button frmPrintaj;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslTrenutnoVrijeme;
        private DataGridViewImageColumn Zastava;
        private DataGridViewTextBoxColumn Drzava;
        private DataGridViewTextBoxColumn BrojGradova;
        private DataGridViewCheckBoxColumn Aktivna;
        private DataGridViewButtonColumn Gradovi;
    }
}