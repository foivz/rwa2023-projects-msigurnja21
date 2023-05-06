namespace Alat_za_praćenje_osobnih_financija
{
    partial class FrmNovaŠifra
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
            this.lblNazivŠifre = new System.Windows.Forms.Label();
            this.txtNazivŠifre = new System.Windows.Forms.TextBox();
            this.btnDodajŠifru = new System.Windows.Forms.Button();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNazivŠifre
            // 
            this.lblNazivŠifre.AutoSize = true;
            this.lblNazivŠifre.Location = new System.Drawing.Point(50, 100);
            this.lblNazivŠifre.Name = "lblNazivŠifre";
            this.lblNazivŠifre.Size = new System.Drawing.Size(41, 16);
            this.lblNazivŠifre.TabIndex = 1;
            this.lblNazivŠifre.Text = "Naziv";
            // 
            // txtNazivŠifre
            // 
            this.txtNazivŠifre.Location = new System.Drawing.Point(53, 119);
            this.txtNazivŠifre.Name = "txtNazivŠifre";
            this.txtNazivŠifre.Size = new System.Drawing.Size(184, 22);
            this.txtNazivŠifre.TabIndex = 3;
            // 
            // btnDodajŠifru
            // 
            this.btnDodajŠifru.Location = new System.Drawing.Point(162, 177);
            this.btnDodajŠifru.Name = "btnDodajŠifru";
            this.btnDodajŠifru.Size = new System.Drawing.Size(75, 29);
            this.btnDodajŠifru.TabIndex = 4;
            this.btnDodajŠifru.Text = "Dodaj";
            this.btnDodajŠifru.UseVisualStyleBackColor = true;
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Items.AddRange(new object[] {
            "1 Hrana i piće",
            "2 Kupovine",
            "3 Dugovanja i potraživanja",
            "4 Mjesečna članstva",
            "5 Nezgode"});
            this.cmbKategorija.Location = new System.Drawing.Point(53, 49);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(184, 24);
            this.cmbKategorija.TabIndex = 5;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(50, 30);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(68, 16);
            this.lblKategorija.TabIndex = 6;
            this.lblKategorija.Text = "Kategorija";
            // 
            // FrmNovaŠifra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 273);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.btnDodajŠifru);
            this.Controls.Add(this.txtNazivŠifre);
            this.Controls.Add(this.lblNazivŠifre);
            this.Name = "FrmNovaŠifra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dodavanje nove šifre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNazivŠifre;
        private System.Windows.Forms.TextBox txtNazivŠifre;
        private System.Windows.Forms.Button btnDodajŠifru;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Label lblKategorija;
    }
}