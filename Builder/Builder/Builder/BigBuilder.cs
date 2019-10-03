using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class BigBuilder:HamburguesaBuilder
    {
        public BigBuilder(PanEnum pan, CarneEnum carne)
        {
            _hamburguesa = new Hamburguesa
            {
                Pan = pan,
                Carne = carne,
                Nombre = "Big King",
                Precio = 68.5,
                Relleno = new List<string>()
            };
        }
        public override void PasoPrepararRelleno()
        {
            _hamburguesa.Relleno.Add("salsa agridulce");
            _hamburguesa.Relleno.Add("pepinillos");
            _hamburguesa.Relleno.Add("queso amarillo");
            _hamburguesa.Relleno.Add("lechuga");
        }
    }
}
