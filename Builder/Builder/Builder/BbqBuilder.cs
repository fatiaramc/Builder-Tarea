using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class BbqBuilder : HamburguesaBuilder
    {
        public BbqBuilder(PanEnum pan, CarneEnum carne)
        {
            _hamburguesa = new Hamburguesa
            {
                Pan = pan,
                Carne = carne,
                Nombre = "Bbq",
                Precio = 56.6,
                Relleno = new List<string>()
            };
        }
        public override void PasoPrepararRelleno()
        {
            _hamburguesa.Relleno.Add("salsa bbq");
            _hamburguesa.Relleno.Add("mayonesa");
            _hamburguesa.Relleno.Add("pepinillos");
            _hamburguesa.Relleno.Add("queso");
            _hamburguesa.Relleno.Add("tocino");
        }
    }
}
