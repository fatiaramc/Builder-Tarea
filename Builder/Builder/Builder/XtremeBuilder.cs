using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class XtremeBuilder:HamburguesaBuilder
    {
        public XtremeBuilder(PanEnum pan, CarneEnum carne)
        {
            _hamburguesa = new Hamburguesa
            {
                Pan = pan,
                Carne = carne,
                Nombre = "X-treme",
                Relleno = new List<string>()
            };
        }
        public override void PasoPrepararRelleno()
        {
            _hamburguesa.Relleno.Add("tomate");
            _hamburguesa.Relleno.Add("mayonesa");
            _hamburguesa.Relleno.Add("pepinillos");
            _hamburguesa.Relleno.Add("cebolla");
            _hamburguesa.Relleno.Add("queso amarillo");
            _hamburguesa.Relleno.Add("queso americano");
        }
    }
}
