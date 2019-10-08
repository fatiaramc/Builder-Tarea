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
        public Dictionary<string, int> _listPlatillos = new Dictionary<string, int>();
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

            //Baguette
            //albondigas
            pictureBox9.ImageLocation = "https://www.subway.com/ns/images/menu/MEX/SPA/RPLC-all-sandwiches-meatball-594x334_PR.jpg";
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            //italiano
            pictureBox10.ImageLocation = "https://www.subway.com/ns/images/menu/MEX/SPA/RPLC-all-sandwiches-italian-bmt-MX-594x334_PR.jpg";
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            //atun
            pictureBox13.ImageLocation = "https://www.subway.com/ns/images/menu/MEX/SPA/RPLC-all-sandwiches-tuna-MX-594x334_PR.jpg";
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            //vegetariano
            pictureBox14.ImageLocation = "https://www.subway.com/ns/images/menu/MEX/SPA/RPLC-all-sandwiches-veggie-delite-MX-594x334_PR.jpg";
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            //teriyaki
            pictureBox15.ImageLocation = "https://www.subway.com/ns/images/menu/MEX/SPA/RPLC-all-sandwiches-soct-MX-594x334_PR.jpg";
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;


            //Sandwiches
            //verde
            pictureBox16.ImageLocation = "http://comemesandwicheria.cl/wp-content/uploads/2017/03/pechuga-frita2-1.png";
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
            //jamon
            pictureBox17.ImageLocation = "https://elhornopanaderia.com.ec/wp-content/uploads/2017/11/sandwich.png";
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
            //mantequilla de many y jalea
            pictureBox18.ImageLocation = "https://missouriwrestlingrevival.files.wordpress.com/2009/08/898-peanut-butter-jelly.png";
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
            //huevo
            pictureBox19.ImageLocation = "https://www.wendys.cl/wp-content/uploads/2017/08/643x378-huevo-jamon-1.png";
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
            //salchicha
            pictureBox20.ImageLocation = "https://www.wienerschnitzel.com/wp-content/uploads/2014/10/sandwich_polish-sandwich.png";
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void cargarPlatillo(IComida comida)
        {
            try
            {
                if(comida != null)
                {
                    if (!_listPlatillos.ContainsKey(comida.ToString()))
                        _listPlatillos.Add(comida.ToString(), 0);
                    _listPlatillos[comida.ToString()] += 1;
                    total += comida.Precio;
                    var k = "";
                    foreach (var h in _listPlatillos)
                    {
                        k += h.Value + " " + h.Key + Environment.NewLine;
                    }
                    textBox1.Text = k;
                    labelPagar.Text = "" + total;
                    MessageBox.Show("Se ha agregado un " + comida.Nombre + " a tu pedido");
                }
                
            }
            catch { }

        }

        private void deletePlatillo(IComida p)
        {
            try
            {
                string p_string = p.ToString();
                if (!_listPlatillos.ContainsKey(p_string))
                {
                    MessageBox.Show("No puedes eliminar platillos que no has pedido");
                }
                else if (_listPlatillos[p_string] == 0)
                {
                    MessageBox.Show("No puedes eliminar platillos que no has pedido");
                }
                else
                {
                    _listPlatillos[p_string]--;
                    total -= p.Precio;

                    var h_int = _listPlatillos[p_string];
                    if (h_int <= 0)
                        _listPlatillos.Remove(p_string);
                    var k = "";
                    foreach (var h in _listPlatillos)
                    {
                        k += h.Value + " " + h.Key + Environment.NewLine;
                    }
                    textBox1.Text = k;

                    labelPagar.Text = "" + total;
                    MessageBox.Show("El platillo ha sido eliminada del pedido");
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show("Error, reinicie su operacion por favor");
                MessageBox.Show("Error " + e);
            }
        }

        private void clickPlatillo(Platillo p)
        {
            var comida = p.PrepararComida();
            if (!checkBoxDelete.Checked)
            {
                cargarPlatillo(comida);
            }
            else
              deletePlatillo(comida);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Platillo p = new BbqBuilder();
            clickPlatillo(p);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Platillo p = new AngryBuilder();
            clickPlatillo(p);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Platillo p = new HabaneroBuilder();
            clickPlatillo(p);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Platillo p = new DobleBuilder();
            clickPlatillo(p);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Platillo p = new ChipotleBuilder();
            clickPlatillo(p);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Platillo p = new LongJalapeñoBuilder();
            clickPlatillo(p);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Platillo p = new RodeoBuilder();
            clickPlatillo(p);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Platillo p = new XtremeBuilder();
            clickPlatillo(p);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Platillo p = new BaconBuilder();
            clickPlatillo(p);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            /*Hamburguesa h = cocina.CocinarHamburguesa(new BbqBuilder(PanEnum.Integral, CarneEnum.Doble));
            ClickHamburguer(h);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            _listPlatillos = new Dictionary<string, int>();
            total = 0;
            labelPagar.Text = "0";
            MessageBox.Show("Gracias, vuelve pronto");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //sandwich albondigas
            Platillo p = new AlbondigasBuilder();
            clickPlatillo(p);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Platillo p = new ItalianoBuilder();
            clickPlatillo(p);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Platillo p = new AtunBuilder();
            clickPlatillo(p);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Platillo p = new VegetarianoBuilder();
            clickPlatillo(p);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Platillo p = new TeriyakiBuilder();
            clickPlatillo(p);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Platillo p = new VerdeBuilder();
            clickPlatillo(p);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Platillo p = new JamonBuilder();
            clickPlatillo(p);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Platillo p = new MantequillaBuilder();
            clickPlatillo(p);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Platillo p = new HuevoBuilder();
            clickPlatillo(p);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            Platillo p = new SalchichaBuilder();
            clickPlatillo(p);
        }
    }
}
