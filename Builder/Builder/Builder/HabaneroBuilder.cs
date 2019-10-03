using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class HabaneroBuilder:HamburguesaBuilder
    {
        public HabaneroBuilder(PanEnum pan, CarneEnum carne)
        {
            _hamburguesa = new Hamburguesa
            {
                Pan = pan,
                Carne = carne,
                Nombre = "Mango Habanero",
                Relleno = new List<string>()
            };
        }
        public override void PasoPrepararRelleno()
        {
            _hamburguesa.Relleno.Add("salsa Mango Habanero");
            _hamburguesa.Relleno.Add("cebollitas");
            _hamburguesa.Relleno.Add("lechuga");
            _hamburguesa.Relleno.Add("tocino");
        }
    }
}
