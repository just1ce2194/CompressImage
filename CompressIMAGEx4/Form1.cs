using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompressBMPx4
{
    public partial class MainForm : Form
    {
        string path_to_file;
        public MainForm()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image Files (*.bmp, *.img, *.png)|*.bmp;*.jpg;*.png|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Filter = "BMP files (*.bmp)|*.bmp|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

        }

        private void OpenFile_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path_to_file = openFileDialog1.FileName;
                    OpenText_txtbox.Text = path_to_file;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void Compress_btn_Click(object sender, EventArgs e)
        {
            if (path_to_file != null)
            {
                work(path_to_file);
            }
        }
        private void work(string path)
        {
            int R, G, B;
            Bitmap bmp = new Bitmap(@path, true);
            Bitmap bmp2 = new Bitmap(bmp.Width / 2, bmp.Height / 2);
            Color tmp4, tmp1, tmp2, tmp3;
            DateTime begin = DateTime.Now;
            for (int y = 0; y < bmp.Height - 2; y += 2)
                for (int x = 0; x < bmp.Width - 2; x += 2)
                {
                    tmp1 = bmp.GetPixel(x, y);
                    tmp2 = bmp.GetPixel(x + 1, y);
                    tmp3 = bmp.GetPixel(x, y + 1);
                    tmp4 = bmp.GetPixel(x + 1, y + 1);
                    R = (tmp1.R + tmp2.R + tmp3.R + tmp4.R) / 4;
                    G = (tmp1.G + tmp2.G + tmp3.G + tmp4.G) / 4;
                    B = (tmp1.B + tmp2.B + tmp3.B + tmp4.B) / 4;
                    bmp2.SetPixel(x / 2, y / 2, Color.FromArgb(R, G, B));



                }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp2.Save(@saveFileDialog1.FileName);
            }
           
        }
    }
}
