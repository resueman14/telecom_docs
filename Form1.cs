using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace telecom_docs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            Bitmap myBitmap = new Bitmap(@"A:\desktop\blank.bmp");
            Graphics g = Graphics.FromImage(myBitmap);

            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.DrawString(textBoxAdres.Text,
                         new Font("Times New Roman", 20, FontStyle.Italic),
                         Brushes.Black,
                         new PointF(0, 0));
            myBitmap.Save(@"A:\desktop\blank1.bmp");

            g.DrawString(comboBox1.Text,
             new Font("Times New Roman", 20, FontStyle.Italic),
             Brushes.Black,
             new PointF(0, 100));
            myBitmap.Save(@"A:\desktop\blank1.bmp");
            System.Diagnostics.Process.Start("CMD.exe", "/k mspaint.exe /pt A:\\desktop\\blank.bmp");
            System.Diagnostics.Process.Start("CMD.exe", "/k mspaint.exe /pt A:\\desktop\\blank1.bmp");
        }

    }
}
