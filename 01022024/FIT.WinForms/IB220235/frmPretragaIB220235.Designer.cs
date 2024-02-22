namespace FIT.WinForms.IB220235
{
    partial class frmPretragaIB220235
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
            label1 = new Label();
            label2 = new Label();
            cmbDrzava = new ComboBox();
            cmbGrad = new ComboBox();
            dgvPodaci = new DataGridView();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            Grad = new DataGridViewTextBoxColumn();
            Drzava = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Drzava:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(262, 9);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 0;
            label2.Text = "Grad:";
            // 
            // cmbDrzava
            // 
            cmbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzava.Font = new Font("Segoe UI", 11F);
            cmbDrzava.FormattingEnabled = true;
            cmbDrzava.Location = new Point(12, 32);
            cmbDrzava.Name = "cmbDrzava";
            cmbDrzava.Size = new Size(230, 28);
            cmbDrzava.TabIndex = 1;
            cmbDrzava.SelectedIndexChanged += cmbDrzava_SelectedIndexChanged;
            // 
            // cmbGrad
            // 
            cmbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrad.Font = new Font("Segoe UI", 11F);
            cmbGrad.FormattingEnabled = true;
            cmbGrad.Location = new Point(262, 32);
            cmbGrad.Name = "cmbGrad";
            cmbGrad.Size = new Size(230, 28);
            cmbGrad.TabIndex = 1;
            cmbGrad.SelectedIndexChanged += cmbGrad_SelectedIndexChanged;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Ime, Prezime, Grad, Drzava, Prosjek });
            dgvPodaci.Location = new Point(12, 66);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.RowTemplate.Height = 25;
            dgvPodaci.Size = new Size(776, 197);
            dgvPodaci.TabIndex = 2;
            // 
            // Ime
            // 
            Ime.DataPropertyName = "Ime";
            Ime.HeaderText = "Ime";
            Ime.Name = "Ime";
            Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            Prezime.DataPropertyName = "Prezime";
            Prezime.HeaderText = "Prezime";
            Prezime.Name = "Prezime";
            Prezime.ReadOnly = true;
            // 
            // Grad
            // 
            Grad.DataPropertyName = "Grad";
            Grad.HeaderText = "Grad";
            Grad.Name = "Grad";
            Grad.ReadOnly = true;
            // 
            // Drzava
            // 
            Drzava.DataPropertyName = "Drzava";
            Drzava.HeaderText = "Drzava";
            Drzava.Name = "Drzava";
            Drzava.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            // 
            // frmPretragaIB220235
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 275);
            Controls.Add(dgvPodaci);
            Controls.Add(cmbGrad);
            Controls.Add(cmbDrzava);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB220235";
            Text = "Podaci o studentima";
            Load += frmPretragaIB220235_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbDrzava;
        private ComboBox cmbGrad;
        private DataGridView dgvPodaci;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn Drzava;
        private DataGridViewTextBoxColumn Prosjek;
    }
}