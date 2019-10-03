using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadImages();
        }

        private void LoadImages()
        {
            //bbq
            pictureBox1.ImageLocation = "http://bk-latam-prod.s3.amazonaws.com/sites/burgerking.com.mx/files/WHOPPER-300x270-PARRILLA_1.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //angry
            pictureBox2.ImageLocation = "http://bk-latam-prod.s3.amazonaws.com/sites/burgerking.com.mx/files/ANGRY-WHOPPER-300x270-PARRILLA_0.png";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            //chipotle king
            pictureBox3.ImageLocation = "http://bk-latam-prod.s3.amazonaws.com/sites/burgerking.com.mx/files/CHIPOTLE_KING_th_0.png";
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            //bacon
            pictureBox4.ImageLocation = "http://bk-latam-prod.s3.amazonaws.com/sites/burgerking.com.mx/files/BACON_KING_th.png";
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            //long rodeo
            pictureBox5.ImageLocation = "http://bk-latam-prod.s3.amazonaws.com/sites/burgerking.com.mx/files/long-rodeo-th.png";
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            //X-treme
            pictureBox6.ImageLocation = "http://bk-latam-prod.s3.amazonaws.com/sites/burgerking.com.mx/files/XTREME-300x270-PARRILLA_1.png";
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            //Big King
            pictureBox6.ImageLocation = "http://bk-latam-prod.s3.amazonaws.com/sites/burgerking.com.mx/files/BIG-KING-300x270_1.png";
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            //Rodeo burguer
            pictureBox7.ImageLocation = "http://bk-latam-prod.s3.amazonaws.com/sites/burgerking.com.mx/files/RODEO-300x270-PARRILLA_1.png";
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            //Log jalapeño
            pictureBox8.ImageLocation = "http://bk-latam-prod.s3.amazonaws.com/sites/burgerking.com.mx/files/long_jalapeno-th.png";
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            //Mango habanero
            pictureBox11.ImageLocation = "http://bk-latam-prod.s3.amazonaws.com/sites/burgerking.com.mx/files/App_MENU_MHK_th_0.png";
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            //Doble con queso
            pictureBox12.ImageLocation = "http://bk-latam-prod.s3.amazonaws.com/sites/burgerking.com.mx/files/WHOPPER-DOBLE-300x270-PARRILLA_0.png";
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
