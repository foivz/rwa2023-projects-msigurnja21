namespace Alat_za_praćenje_osobnih_financija
{
    partial class FrmUnesiTrošak
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
            this.lblŠifra = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.txtŠifra = new System.Windows.Forms.TextBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnUnesiTrošak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblŠifra
            // 
            this.lblŠifra.AutoSize = true;
            this.lblŠifra.Location = new System.Drawing.Point(49, 40);
            this.lblŠifra.Name = "lblŠifra";
            this.lblŠifra.Size = new System.Drawing.Size(34, 16);
            this.lblŠifra.TabIndex = 0;
            this.lblŠifra.Text = "Šifra";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(49, 107);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(46, 16);
            this.lblDatum.TabIndex = 1;
            this.lblDatum.Text = "Datum";
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(49, 174);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(38, 16);
            this.lblIznos.TabIndex = 2;
            this.lblIznos.Text = "Iznos";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(49, 248);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(64, 16);
            this.lblKomentar.TabIndex = 3;
            this.lblKomentar.Text = "Komentar";
            // 
            // txtŠifra
            // 
            this.txtŠifra.Location = new System.Drawing.Point(52, 59);
            this.txtŠifra.Name = "txtŠifra";
            this.txtŠifra.Size = new System.Drawing.Size(246, 22);
            this.txtŠifra.TabIndex = 4;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(52, 193);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(246, 22);
            this.txtIznos.TabIndex = 6;
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(52, 267);
            this.txtKomentar.Multiline = true;
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(246, 64);
            this.txtKomentar.TabIndex = 7;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(52, 126);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(246, 22);
            this.dtpDatum.TabIndex = 8;
            this.dtpDatum.Value = new System.DateTime(2023, 5, 6, 0, 0, 0, 0);
            // 
            // btnUnesiTrošak
            // 
            this.btnUnesiTrošak.Location = new System.Drawing.Point(223, 351);
            this.btnUnesiTrošak.Name = "btnUnesiTrošak";
            this.btnUnesiTrošak.Size = new System.Drawing.Size(75, 28);
            this.btnUnesiTrošak.TabIndex = 10;
            this.btnUnesiTrošak.Text = "Unesi";
            this.btnUnesiTrošak.UseVisualStyleBackColor = true;
            this.btnUnesiTrošak.Click += new System.EventHandler(this.btnUnesiTrošak_Click);
            // 
            // FrmUnesiTrošak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 429);
            this.Controls.Add(this.btnUnesiTrošak);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.txtŠifra);
            this.Controls.Add(this.lblKomentar);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblŠifra);
            this.Name = "FrmUnesiTrošak";
            this.Text = "Unesi trošak";
            this.Load += new System.EventHandler(this.FrmUnesiTrošak_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblŠifra;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.TextBox txtŠifra;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button btnUnesiTrošak;
    }
}