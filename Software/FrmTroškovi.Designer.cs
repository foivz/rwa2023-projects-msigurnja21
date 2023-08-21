namespace Alat_za_praćenje_osobnih_financija
{
    partial class FrmTroškovi
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
            this.dgvPrikazTroškova = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsPrikazTroškova = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiSveTroškoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hranaIPićeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kupovineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiTroškovePoVremenskomPerioduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odNajstarijegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odNajnovijegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bntUnesiTrošak = new System.Windows.Forms.Button();
            this.dugovanjaIPotraživanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mjesečnaČlanstvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nezgodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazTroškova)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrikazTroškova
            // 
            this.dgvPrikazTroškova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazTroškova.Location = new System.Drawing.Point(12, 31);
            this.dgvPrikazTroškova.Name = "dgvPrikazTroškova";
            this.dgvPrikazTroškova.RowHeadersVisible = false;
            this.dgvPrikazTroškova.RowHeadersWidth = 51;
            this.dgvPrikazTroškova.RowTemplate.Height = 24;
            this.dgvPrikazTroškova.Size = new System.Drawing.Size(895, 399);
            this.dgvPrikazTroškova.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsPrikazTroškova});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsPrikazTroškova
            // 
            this.mnsPrikazTroškova.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiSveTroškoveToolStripMenuItem,
            this.prikažiTroškovePoVremenskomPerioduToolStripMenuItem});
            this.mnsPrikazTroškova.Name = "mnsPrikazTroškova";
            this.mnsPrikazTroškova.Size = new System.Drawing.Size(77, 24);
            this.mnsPrikazTroškova.Text = "Troškovi";
            // 
            // prikažiSveTroškoveToolStripMenuItem
            // 
            this.prikažiSveTroškoveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hranaIPićeToolStripMenuItem,
            this.kupovineToolStripMenuItem,
            this.dugovanjaIPotraživanjaToolStripMenuItem,
            this.mjesečnaČlanstvaToolStripMenuItem,
            this.nezgodeToolStripMenuItem});
            this.prikažiSveTroškoveToolStripMenuItem.Name = "prikažiSveTroškoveToolStripMenuItem";
            this.prikažiSveTroškoveToolStripMenuItem.Size = new System.Drawing.Size(361, 26);
            this.prikažiSveTroškoveToolStripMenuItem.Text = "Prikaži troškove po vrsti troška";
            // 
            // hranaIPićeToolStripMenuItem
            // 
            this.hranaIPićeToolStripMenuItem.Name = "hranaIPićeToolStripMenuItem";
            this.hranaIPićeToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.hranaIPićeToolStripMenuItem.Text = "1 - Hrana i piće";
            this.hranaIPićeToolStripMenuItem.Click += new System.EventHandler(this.hranaIPićeToolStripMenuItem_Click);
            // 
            // kupovineToolStripMenuItem
            // 
            this.kupovineToolStripMenuItem.Name = "kupovineToolStripMenuItem";
            this.kupovineToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.kupovineToolStripMenuItem.Text = "2 - Kupovine";
            this.kupovineToolStripMenuItem.Click += new System.EventHandler(this.kupovineToolStripMenuItem_Click);
            // 
            // prikažiTroškovePoVremenskomPerioduToolStripMenuItem
            // 
            this.prikažiTroškovePoVremenskomPerioduToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odNajstarijegToolStripMenuItem,
            this.odNajnovijegToolStripMenuItem});
            this.prikažiTroškovePoVremenskomPerioduToolStripMenuItem.Name = "prikažiTroškovePoVremenskomPerioduToolStripMenuItem";
            this.prikažiTroškovePoVremenskomPerioduToolStripMenuItem.Size = new System.Drawing.Size(361, 26);
            this.prikažiTroškovePoVremenskomPerioduToolStripMenuItem.Text = "Prikaži troškove po vremenskom periodu";
            // 
            // odNajstarijegToolStripMenuItem
            // 
            this.odNajstarijegToolStripMenuItem.Name = "odNajstarijegToolStripMenuItem";
            this.odNajstarijegToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.odNajstarijegToolStripMenuItem.Text = "Od najstarijeg";
            this.odNajstarijegToolStripMenuItem.Click += new System.EventHandler(this.odNajstarijegToolStripMenuItem_Click);
            // 
            // odNajnovijegToolStripMenuItem
            // 
            this.odNajnovijegToolStripMenuItem.Name = "odNajnovijegToolStripMenuItem";
            this.odNajnovijegToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.odNajnovijegToolStripMenuItem.Text = "Od najnovijeg";
            this.odNajnovijegToolStripMenuItem.Click += new System.EventHandler(this.odNajnovijegToolStripMenuItem_Click);
            // 
            // bntUnesiTrošak
            // 
            this.bntUnesiTrošak.Location = new System.Drawing.Point(765, 451);
            this.bntUnesiTrošak.Name = "bntUnesiTrošak";
            this.bntUnesiTrošak.Size = new System.Drawing.Size(142, 33);
            this.bntUnesiTrošak.TabIndex = 2;
            this.bntUnesiTrošak.Text = "Unesi trošak";
            this.bntUnesiTrošak.UseVisualStyleBackColor = true;
            this.bntUnesiTrošak.Click += new System.EventHandler(this.bntUnesiTrošak_Click);
            // 
            // dugovanjaIPotraživanjaToolStripMenuItem
            // 
            this.dugovanjaIPotraživanjaToolStripMenuItem.Name = "dugovanjaIPotraživanjaToolStripMenuItem";
            this.dugovanjaIPotraživanjaToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.dugovanjaIPotraživanjaToolStripMenuItem.Text = "3 - Dugovanja i potraživanja";
            this.dugovanjaIPotraživanjaToolStripMenuItem.Click += new System.EventHandler(this.dugovanjaIPotraživanjaToolStripMenuItem_Click);
            // 
            // mjesečnaČlanstvaToolStripMenuItem
            // 
            this.mjesečnaČlanstvaToolStripMenuItem.Name = "mjesečnaČlanstvaToolStripMenuItem";
            this.mjesečnaČlanstvaToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.mjesečnaČlanstvaToolStripMenuItem.Text = "4 - Mjesečna članstva";
            this.mjesečnaČlanstvaToolStripMenuItem.Click += new System.EventHandler(this.mjesečnaČlanstvaToolStripMenuItem_Click);
            // 
            // nezgodeToolStripMenuItem
            // 
            this.nezgodeToolStripMenuItem.Name = "nezgodeToolStripMenuItem";
            this.nezgodeToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.nezgodeToolStripMenuItem.Text = "5 - Nezgode";
            this.nezgodeToolStripMenuItem.Click += new System.EventHandler(this.nezgodeToolStripMenuItem_Click);
            // 
            // FrmTroškovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 552);
            this.Controls.Add(this.bntUnesiTrošak);
            this.Controls.Add(this.dgvPrikazTroškova);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTroškovi";
            this.Text = "Troškovi";
            this.Load += new System.EventHandler(this.FrmTroškovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazTroškova)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrikazTroškova;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsPrikazTroškova;
        private System.Windows.Forms.ToolStripMenuItem prikažiSveTroškoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiTroškovePoVremenskomPerioduToolStripMenuItem;
        private System.Windows.Forms.Button bntUnesiTrošak;
        private System.Windows.Forms.ToolStripMenuItem odNajstarijegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odNajnovijegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hranaIPićeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kupovineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dugovanjaIPotraživanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mjesečnaČlanstvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nezgodeToolStripMenuItem;
    }
}