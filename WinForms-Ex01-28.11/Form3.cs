using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Ex01_28._11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strImgPath = new string[3];
            strImgPath[0] = @"C:\Users\97252\source\repos\WinForms-Ex01-28.11\WinForms-Ex01-28.11\dog1.jpg";
            strImgPath[1] = @"C:\Users\97252\source\repos\WinForms-Ex01-28.11\WinForms-Ex01-28.11\dog2.jpg";
            strImgPath[2] = @"C:\Users\97252\source\repos\WinForms-Ex01-28.11\WinForms-Ex01-28.11\dog3.jpg";

            Random random = new Random(DateTime.Now.Millisecond);
            int randomNum = random.Next(0, 3);
            pictureBox1.Image = Image.FromFile(strImgPath[randomNum]);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
