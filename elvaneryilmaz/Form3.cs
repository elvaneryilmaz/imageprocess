using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elvaneryilmaz
{
    public partial class Form3 : Form
    {
        Bitmap kaynak, işlem;
        public Form3()
        {
            InitializeComponent();
        }

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;

            int yuk = kaynak.Height;



            işlem = new Bitmap(gen, yuk);



            for (int y = 0; y < yuk; y++)

            {

                for (int x = 0; x < gen; x++)

                {

                    Color renkliRenk = kaynak.GetPixel(x, y);

                    int gri = (renkliRenk.R + renkliRenk.G + renkliRenk.B) / 3;
                    
                    Color griRenk = Color.FromArgb(gri, gri, gri);

                    işlem.SetPixel(x, y, griRenk);

                }

            }



            işlembox.Image = işlem;
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";

            DialogResult sonuc = saveFileDialog1.ShowDialog();

            ImageFormat format = ImageFormat.Png;

            if (sonuc == DialogResult.OK)

            {

                işlem.Save(saveFileDialog1.FileName, format);

            }
        }

      

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
        DialogResult sonuc = openFileDialog1.ShowDialog();

        if (sonuc == DialogResult.OK)

        {

            kaynak = new Bitmap(openFileDialog1.FileName);

            kaynakbox.Image = kaynak;

        }
    }
    }
}
