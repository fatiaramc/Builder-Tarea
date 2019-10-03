using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class ChipotleBuilder : HamburguesaBuilder
    {
        public ChipotleBuilder(PanEnum pan, CarneEnum carne)
        {
            _hamburguesa = new Hamburguesa
            {
                Pan = pan,
                Carne = carne,
                Nombre = "Chipotle burguer",
                Precio = 78.2,
                Relleno = new List<string>()
            };
        }
        public override void PasoPrepararRelleno()
        {
            _hamburguesa.Relleno.Add("salsa chipotle");
            _hamburguesa.Relleno.Add("aros de cebolla");
            _hamburguesa.Relleno.Add("lechuga");
            _hamburguesa.Relleno.Add("tocino");
        }
    }
}
