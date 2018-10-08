using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elvaneryilmaz
{
    public partial class Form2 : Form
    {
        Bitmap kaynak;
        public Form2()
        {
            InitializeComponent();
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

        private void renkalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = int.Parse(xkor.Text);

            int y = int.Parse(ykor.Text);



            Color rengim = kaynak.GetPixel(x, y);

            işlembox.BackColor = rengim;

            Console.WriteLine("R: " + rengim.R + " G: " + rengim.G + " B: " + rengim.B);
        }
    }
}
