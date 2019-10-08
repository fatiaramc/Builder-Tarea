using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class ChipotleBuilder : Platillo
    {
        public override IComida PrepararComida()
        {
            _comida = new Hamburguesa
            {
                Pan = PanEnum.Bimbollo,
                Carne = CarneEnum.Pollo,
                Nombre = "Chipotle burguer",
                Precio = 78.2,
                Relleno = new List<string>()
            };
            PasoPrepararRelleno();
            return _comida;
        }
        private void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("salsa chipotle");
            _comida.Relleno.Add("aros de cebolla");
            _comida.Relleno.Add("lechuga");
            _comida.Relleno.Add("tocino");
        }
    }
}
