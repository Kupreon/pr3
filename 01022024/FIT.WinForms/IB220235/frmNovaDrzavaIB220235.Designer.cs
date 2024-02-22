namespace FIT.WinForms.IB220235
{
    partial class frmNovaDrzavaIB220235
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pbZastava = new PictureBox();
            tbNaziv = new TextBox();
            cbAktivna = new CheckBox();
            btnSacuvaj = new Button();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 232);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 0;
            label1.Text = "Naziv:";
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(12, 33);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(348, 183);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 1;
            pbZastava.TabStop = false;
            pbZastava.DoubleClick += pbZastava_DoubleClick;
            // 
            // tbNaziv
            // 
            tbNaziv.Font = new Font("Segoe UI", 12F);
            tbNaziv.Location = new Point(12, 256);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(348, 29);
            tbNaziv.TabIndex = 2;
            // 
            // cbAktivna
            // 
            cbAktivna.AutoSize = true;
            cbAktivna.Font = new Font("Segoe UI", 12F);
            cbAktivna.Location = new Point(12, 301);
            cbAktivna.Name = "cbAktivna";
            cbAktivna.Size = new Size(81, 25);
            cbAktivna.TabIndex = 3;
            cbAktivna.Text = "Aktivna";
            cbAktivna.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Font = new Font("Segoe UI", 12F);
            btnSacuvaj.Location = new Point(266, 301);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 4;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 0;
            label2.Text = "Zastava:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmNovaDrzavaIB220235
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 346);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbAktivna);
            Controls.Add(tbNaziv);
            Controls.Add(pbZastava);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovaDrzavaIB220235";
            Text = "Podaci o drzavi";
            Load += frmNovaDrzavaIB220235_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbZastava;
        private TextBox tbNaziv;
        private CheckBox cbAktivna;
        private Button btnSacuvaj;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
    }
}