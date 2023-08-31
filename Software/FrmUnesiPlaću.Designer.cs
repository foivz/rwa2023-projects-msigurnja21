namespace Alat_za_praćenje_osobnih_financija
{
    partial class FrmUnesiPlaću
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
            this.lblIznosPlace = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.btnUneciPlacu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIznosPlace
            // 
            this.lblIznosPlace.AutoSize = true;
            this.lblIznosPlace.Location = new System.Drawing.Point(43, 87);
            this.lblIznosPlace.Name = "lblIznosPlace";
            this.lblIznosPlace.Size = new System.Drawing.Size(38, 16);
            this.lblIznosPlace.TabIndex = 0;
            this.lblIznosPlace.Text = "Iznos";
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(46, 106);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(246, 22);
            this.txtIznos.TabIndex = 1;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(46, 172);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(246, 22);
            this.dtpDatum.TabIndex = 10;
            this.dtpDatum.Value = new System.DateTime(2023, 5, 6, 0, 0, 0, 0);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(43, 153);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(46, 16);
            this.lblDatum.TabIndex = 9;
            this.lblDatum.Text = "Datum";
            // 
            // btnUneciPlacu
            // 
            this.btnUneciPlacu.Location = new System.Drawing.Point(215, 250);
            this.btnUneciPlacu.Name = "btnUneciPlacu";
            this.btnUneciPlacu.Size = new System.Drawing.Size(77, 28);
            this.btnUneciPlacu.TabIndex = 11;
            this.btnUneciPlacu.Text = "Unesi";
            this.btnUneciPlacu.UseVisualStyleBackColor = true;
            this.btnUneciPlacu.Click += new System.EventHandler(this.btnUneciPlacu_Click);
            // 
            // FrmUnesiPlaću
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 347);
            this.Controls.Add(this.btnUneciPlacu);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.lblIznosPlace);
            this.Name = "FrmUnesiPlaću";
            this.Text = "Unesi plaću";
            this.Load += new System.EventHandler(this.FrmUnesiPlaću_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIznosPlace;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnUneciPlacu;
    }
}