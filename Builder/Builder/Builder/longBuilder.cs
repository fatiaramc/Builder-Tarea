using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class longBuilder:HamburguesaBuilder
    {
        public longBuilder(PanEnum pan, CarneEnum carne)
        {
            _hamburguesa = new Hamburguesa
            {
                Pan = pan,
                Carne = carne,
                Nombre = "Long Rodeo",
                Relleno = new List<string>()
            };
        }
        public override void PasoPrepararRelleno()
        {
            _hamburguesa.Relleno.Add("salsa bbq");
            _hamburguesa.Relleno.Add("aros de cebolla");
            _hamburguesa.Relleno.Add("queso americano");
        }
    }
}
