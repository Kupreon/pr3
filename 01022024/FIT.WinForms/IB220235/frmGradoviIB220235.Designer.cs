namespace FIT.WinForms.IB220235
{
    partial class frmGradoviIB220235
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
            pbZastava = new PictureBox();
            lbImeDrzave = new Label();
            lbNoviGrad = new Label();
            tbNazivNovogGrada = new TextBox();
            btnDodaj = new Button();
            dgvPodaci = new DataGridView();
            NazivGrada = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            PromjeniStatus = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            tbInfo = new TextBox();
            cbAktivni = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            btnGenerisi = new Button();
            tbBrojGradova = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(12, 12);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(186, 100);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 0;
            pbZastava.TabStop = false;
            // 
            // lbImeDrzave
            // 
            lbImeDrzave.AutoSize = true;
            lbImeDrzave.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbImeDrzave.Location = new Point(204, 82);
            lbImeDrzave.Name = "lbImeDrzave";
            lbImeDrzave.Size = new Size(116, 30);
            lbImeDrzave.TabIndex = 1;
            lbImeDrzave.Text = "ImeDrzave";
            // 
            // lbNoviGrad
            // 
            lbNoviGrad.AutoSize = true;
            lbNoviGrad.Font = new Font("Segoe UI", 12F);
            lbNoviGrad.Location = new Point(12, 115);
            lbNoviGrad.Name = "lbNoviGrad";
            lbNoviGrad.Size = new Size(201, 21);
            lbNoviGrad.TabIndex = 2;
            lbNoviGrad.Text = "Unesite naziv novog grada: ";
            // 
            // tbNazivNovogGrada
            // 
            tbNazivNovogGrada.Font = new Font("Segoe UI", 12F);
            tbNazivNovogGrada.Location = new Point(204, 112);
            tbNazivNovogGrada.Name = "tbNazivNovogGrada";
            tbNazivNovogGrada.Size = new Size(231, 29);
            tbNazivNovogGrada.TabIndex = 3;
            // 
            // btnDodaj
            // 
            btnDodaj.Font = new Font("Segoe UI", 12F);
            btnDodaj.Location = new Point(441, 112);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 29);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { NazivGrada, Aktivan, PromjeniStatus });
            dgvPodaci.Location = new Point(12, 147);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.RowTemplate.Height = 25;
            dgvPodaci.Size = new Size(504, 167);
            dgvPodaci.TabIndex = 5;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            // 
            // NazivGrada
            // 
            NazivGrada.DataPropertyName = "NazivGrada";
            NazivGrada.HeaderText = "Naziv grada";
            NazivGrada.Name = "NazivGrada";
            NazivGrada.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // PromjeniStatus
            // 
            PromjeniStatus.DataPropertyName = "PromjeniStatus";
            PromjeniStatus.HeaderText = "";
            PromjeniStatus.Name = "PromjeniStatus";
            PromjeniStatus.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbInfo);
            groupBox1.Controls.Add(cbAktivni);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(tbBrojGradova);
            groupBox1.Location = new Point(13, 320);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 252);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(6, 76);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(491, 170);
            tbInfo.TabIndex = 5;
            // 
            // cbAktivni
            // 
            cbAktivni.AutoSize = true;
            cbAktivni.Font = new Font("Segoe UI", 10F);
            cbAktivni.Location = new Point(154, 17);
            cbAktivni.Name = "cbAktivni";
            cbAktivni.Size = new Size(70, 23);
            cbAktivni.TabIndex = 4;
            cbAktivni.Text = "Aktivni";
            cbAktivni.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(36, 19);
            label2.TabIndex = 2;
            label2.Text = "Info:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 2;
            label1.Text = "Broj gradova:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Font = new Font("Segoe UI", 10F);
            btnGenerisi.Location = new Point(422, 16);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(75, 29);
            btnGenerisi.TabIndex = 4;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // tbBrojGradova
            // 
            tbBrojGradova.Font = new Font("Segoe UI", 10F);
            tbBrojGradova.Location = new Point(93, 16);
            tbBrojGradova.Name = "tbBrojGradova";
            tbBrojGradova.Size = new Size(43, 25);
            tbBrojGradova.TabIndex = 3;
            // 
            // frmGradoviIB220235
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 584);
            Controls.Add(groupBox1);
            Controls.Add(dgvPodaci);
            Controls.Add(btnDodaj);
            Controls.Add(tbNazivNovogGrada);
            Controls.Add(lbNoviGrad);
            Controls.Add(lbImeDrzave);
            Controls.Add(pbZastava);
            Name = "frmGradoviIB220235";
            Text = "Podaci o gradu";
            Load += frmGradoviIB220235_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label lbImeDrzave;
        private Label lbNoviGrad;
        private TextBox tbNazivNovogGrada;
        private Button btnDodaj;
        private DataGridView dgvPodaci;
        private DataGridViewTextBoxColumn NazivGrada;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn PromjeniStatus;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbBrojGradova;
        private TextBox tbInfo;
        private CheckBox cbAktivni;
        private Label label2;
        private Button btnGenerisi;
    }
}