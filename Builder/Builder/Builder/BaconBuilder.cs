using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class BaconBuilder:HamburguesaBuilder
    {
        public BaconBuilder(PanEnum pan, CarneEnum carne)
        {
            _hamburguesa = new Hamburguesa
            {
                Pan = pan,
                Carne = carne,
                Nombre = "Bacon Burguer",
                Precio = 57.6,
                Relleno = new List<string>()
            };
        }
        public override void PasoPrepararRelleno()
        {
            _hamburguesa.Relleno.Add("tocino");
            _hamburguesa.Relleno.Add("salsa catsup");
            _hamburguesa.Relleno.Add("mayonesa");
            _hamburguesa.Relleno.Add("queso americano");
            
        }
    }
}
