namespace elvaneryilmaz
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridönüşümleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.renkalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.dosyaToolStripMenuItem.Text = "dosya";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kapatToolStripMenuItem.Text = "kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // renkalToolStripMenuItem
            // 
            this.renkalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkalToolStripMenuItem1,
            this.gridönüşümleriToolStripMenuItem});
            this.renkalToolStripMenuItem.Name = "renkalToolStripMenuItem";
            this.renkalToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.renkalToolStripMenuItem.Text = "işlemler";
            // 
            // renkalToolStripMenuItem1
            // 
            this.renkalToolStripMenuItem1.Name = "renkalToolStripMenuItem1";
            this.renkalToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.renkalToolStripMenuItem1.Text = "renkal";
            this.renkalToolStripMenuItem1.Click += new System.EventHandler(this.renkalToolStripMenuItem1_Click);
            // 
            // gridönüşümleriToolStripMenuItem
            // 
            this.gridönüşümleriToolStripMenuItem.Name = "gridönüşümleriToolStripMenuItem";
            this.gridönüşümleriToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.gridönüşümleriToolStripMenuItem.Text = "gridönüşümleri";
            this.gridönüşümleriToolStripMenuItem.Click += new System.EventHandler(this.gridönüşümleriToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gridönüşümleriToolStripMenuItem;
    }
}

