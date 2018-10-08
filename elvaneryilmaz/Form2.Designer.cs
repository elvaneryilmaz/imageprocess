namespace elvaneryilmaz
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaynakbox = new System.Windows.Forms.PictureBox();
            this.işlembox = new System.Windows.Forms.PictureBox();
            this.xkor = new System.Windows.Forms.TextBox();
            this.ykor = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.işlembox)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1498, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.dosyaToolStripMenuItem.Text = "dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.açToolStripMenuItem.Text = "aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kapatToolStripMenuItem.Text = "kapat";
            // 
            // renkalToolStripMenuItem
            // 
            this.renkalToolStripMenuItem.Name = "renkalToolStripMenuItem";
            this.renkalToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.renkalToolStripMenuItem.Text = "renkal";
            this.renkalToolStripMenuItem.Click += new System.EventHandler(this.renkalToolStripMenuItem_Click);
            // 
            // kaynakbox
            // 
            this.kaynakbox.Location = new System.Drawing.Point(12, 44);
            this.kaynakbox.Name = "kaynakbox";
            this.kaynakbox.Size = new System.Drawing.Size(700, 534);
            this.kaynakbox.TabIndex = 1;
            this.kaynakbox.TabStop = false;
            // 
            // işlembox
            // 
            this.işlembox.Location = new System.Drawing.Point(837, 44);
            this.işlembox.Name = "işlembox";
            this.işlembox.Size = new System.Drawing.Size(700, 534);
            this.işlembox.TabIndex = 2;
            this.işlembox.TabStop = false;
            // 
            // xkor
            // 
            this.xkor.Location = new System.Drawing.Point(77, 597);
            this.xkor.Name = "xkor";
            this.xkor.Size = new System.Drawing.Size(100, 22);
            this.xkor.TabIndex = 3;
            // 
            // ykor
            // 
            this.ykor.Location = new System.Drawing.Point(77, 638);
            this.ykor.Name = "ykor";
            this.ykor.Size = new System.Drawing.Size(100, 22);
            this.ykor.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 672);
            this.Controls.Add(this.ykor);
            this.Controls.Add(this.xkor);
            this.Controls.Add(this.işlembox);
            this.Controls.Add(this.kaynakbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.işlembox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkalToolStripMenuItem;
        private System.Windows.Forms.PictureBox kaynakbox;
        private System.Windows.Forms.PictureBox işlembox;
        private System.Windows.Forms.TextBox xkor;
        private System.Windows.Forms.TextBox ykor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}