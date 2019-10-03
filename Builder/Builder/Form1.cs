using Builder.Builder;
using Builder.Director;
using Builder.Models;
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
        public Dictionary<string, int> _listHamburguesas = new Dictionary<string, int>();
        Cocina cocina = new Cocina();
        double total = 0;
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

        private void chargeHamburguer(Hamburguesa hamburguesa)
        {
            try
            {
                if (!_listHamburguesas.ContainsKey(hamburguesa.ToString()))
                    _listHamburguesas.Add(hamburguesa.ToString(), 0);
                _listHamburguesas[hamburguesa.ToString()] += 1;
                total += hamburguesa.Precio;
                var k = "";
                foreach (var h in _listHamburguesas)
                {
                    k += h.Value + " " + h.Key + Environment.NewLine;
                }
                textBox1.Text = k;
                labelPagar.Text = "" + total;
                MessageBox.Show("Se ha agregado una " + hamburguesa.Nombre + " a tu pedido");
            }
            catch { }
            
        }

        private void deleteHamburguer(Hamburguesa hamburguesa)
        {
            try
            {
                if (!_listHamburguesas.ContainsKey(hamburguesa.ToString()))
                {
                    MessageBox.Show("No puedes eliminar hamburguesas que no has pedido");
                }
                else if (_listHamburguesas[hamburguesa.ToString()] == 0)
                {
                    MessageBox.Show("No puedes eliminar hamburguesas que no has pedido");
                }
                else
                {
                    _listHamburguesas[hamburguesa.ToString()]--;
                    total -= hamburguesa.Precio;
                    
                    var h_int = _listHamburguesas[hamburguesa.ToString()];
                    if (h_int <= 0)
                        _listHamburguesas.Remove(hamburguesa.ToString());
                    var k = "";
                    foreach (var h in _listHamburguesas)
                    {
                        k += h.Value + " " + h.Key + Environment.NewLine;
                    }
                    textBox1.Text = k;

                    labelPagar.Text = "" + total;
                    MessageBox.Show("La hamburguesa ha sido eliminada del pedido");
                }
            }
            catch(Exception e) {
                //MessageBox.Show("Error, reinicie su operacion por favor");
                MessageBox.Show("Error " + e);
            }
        }

        private void ClickHamburguer(Hamburguesa h)
        {
            if (!checkBoxDelete.Checked)
                chargeHamburguer(h);
            else
                deleteHamburguer(h);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hamburguesa h = cocina.CocinarHamburguesa(new BbqBuilder(PanEnum.Ajonjoli, CarneEnum.Res));
            ClickHamburguer(h);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hamburguesa h = cocina.CocinarHamburguesa(new AngryBuilder(PanEnum.Blanco, CarneEnum.Res));
            ClickHamburguer(h);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Hamburguesa h = cocina.CocinarHamburguesa(new HabaneroBuilder(PanEnum.Integral, CarneEnum.Res));
            ClickHamburguer(h);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Hamburguesa h = cocina.CocinarHamburguesa(new DobleBuilder(PanEnum.Doble, CarneEnum.Doble));
            ClickHamburguer(h);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hamburguesa h = cocina.CocinarHamburguesa(new ChipotleBuilder(PanEnum.Bimbollo, CarneEnum.Pollo));
            ClickHamburguer(h);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Hamburguesa h = cocina.CocinarHamburguesa(new LongJalapeñoBuilder(PanEnum.Doble, CarneEnum.Pollo));
            ClickHamburguer(h);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Hamburguesa h = cocina.CocinarHamburguesa(new RodeoBuilder(PanEnum.Blanco, CarneEnum.Doble));
            ClickHamburguer(h);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Hamburguesa h = cocina.CocinarHamburguesa(new XtremeBuilder(PanEnum.Bimbollo, CarneEnum.Doble));
            ClickHamburguer(h);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hamburguesa h = cocina.CocinarHamburguesa(new BaconBuilder(PanEnum.Blanco, CarneEnum.Res));
            ClickHamburguer(h);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Hamburguesa h = cocina.CocinarHamburguesa(new BbqBuilder(PanEnum.Integral, CarneEnum.Doble));
            ClickHamburguer(h);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            _listHamburguesas = new Dictionary<string, int>();
            total = 0;
            labelPagar.Text = "0";
            MessageBox.Show("Gracias, vuelve pronto");
        }
    }
}
