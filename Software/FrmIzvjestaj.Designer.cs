namespace Alat_za_praćenje_osobnih_financija
{
    partial class FrmIzvjestaj
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.troskoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.troskoviDataSet = new Alat_za_praćenje_osobnih_financija.TroskoviDataSet();
            this.rpvTroskovi = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.troskoviIzvjestajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.troskoviTableAdapter = new Alat_za_praćenje_osobnih_financija.TroskoviDataSetTableAdapters.TroskoviTableAdapter();
            this.troskoviBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.troskoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troskoviDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troskoviIzvjestajBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.troskoviBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // troskoviBindingSource
            // 
            this.troskoviBindingSource.DataMember = "Troskovi";
            this.troskoviBindingSource.DataSource = this.troskoviDataSet;
            // 
            // troskoviDataSet
            // 
            this.troskoviDataSet.DataSetName = "TroskoviDataSet";
            this.troskoviDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvTroskovi
            // 
            this.rpvTroskovi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "TroskoviDataSet";
            reportDataSource1.Value = this.troskoviBindingSource;
            this.rpvTroskovi.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvTroskovi.LocalReport.ReportEmbeddedResource = "Alat_za_praćenje_osobnih_financija.Reports.RptTroskovi.rdlc";
            this.rpvTroskovi.Location = new System.Drawing.Point(20, 18);
            this.rpvTroskovi.Name = "rpvTroskovi";
            this.rpvTroskovi.ServerReport.BearerToken = null;
            this.rpvTroskovi.Size = new System.Drawing.Size(866, 361);
            this.rpvTroskovi.TabIndex = 0;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.Location = new System.Drawing.Point(798, 399);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(88, 28);
            this.btnZatvori.TabIndex = 1;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // troskoviTableAdapter
            // 
            this.troskoviTableAdapter.ClearBeforeFill = true;
            // 
            // troskoviBindingSource1
            // 
            this.troskoviBindingSource1.DataMember = "Troskovi";
            this.troskoviBindingSource1.DataSource = this.troskoviDataSet;
            // 
            // FrmIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.rpvTroskovi);
            this.Name = "FrmIzvjestaj";
            this.Text = "Popis troškova";
            this.Load += new System.EventHandler(this.FrmIzvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.troskoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troskoviDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troskoviIzvjestajBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.troskoviBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvTroskovi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.BindingSource troskoviIzvjestajBindingSource;
        private TroskoviDataSet troskoviDataSet;
        private System.Windows.Forms.BindingSource troskoviBindingSource;
        private TroskoviDataSetTableAdapters.TroskoviTableAdapter troskoviTableAdapter;
        private System.Windows.Forms.BindingSource troskoviBindingSource1;
    }
}