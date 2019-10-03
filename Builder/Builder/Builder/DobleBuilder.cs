using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class DobleBuilder:HamburguesaBuilder
    {
        public DobleBuilder(PanEnum pan, CarneEnum carne)
        {
            _hamburguesa = new Hamburguesa
            {
                Pan = pan,
                Carne = carne,
                Nombre = "Doble con queso",
                Precio = 90.0,
                Relleno = new List<string>()
            };
        }
        public override void PasoPrepararRelleno()
        {
            _hamburguesa.Relleno.Add("tomate");
            _hamburguesa.Relleno.Add("cebolla");
            _hamburguesa.Relleno.Add("lechuga");
            _hamburguesa.Relleno.Add("mayonesa");
            _hamburguesa.Relleno.Add("queso");
        }
    }
}
