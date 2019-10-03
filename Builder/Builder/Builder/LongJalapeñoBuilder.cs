using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class LongJalapeñoBuilder:HamburguesaBuilder
    {
        public LongJalapeñoBuilder(PanEnum pan, CarneEnum carne)
        {
            _hamburguesa = new Hamburguesa
            {
                Pan = pan,
                Carne = carne,
                Nombre = "Long Jalapeño",
                Precio = 110.2,
                Relleno = new List<string>()
            };
        }
        public override void PasoPrepararRelleno()
        {
            _hamburguesa.Relleno.Add("queso americano");
            _hamburguesa.Relleno.Add("aros de cebolla");
            _hamburguesa.Relleno.Add("lechuga");
            _hamburguesa.Relleno.Add("jalapeño");
        }
    }
}
