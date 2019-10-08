using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class LongJalapeñoBuilder:Platillo
    {
        public override IComida PrepararComida()
        {
            _comida = new Hamburguesa
            {
                Pan = PanEnum.Doble,
                Carne = CarneEnum.Pollo,
                Nombre = "Long Jalapeño",
                Precio = 110.2,
                Relleno = new List<string>()
            };
            PasoPrepararRelleno();
            return _comida;
        }
        private void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("queso americano");
            _comida.Relleno.Add("aros de cebolla");
            _comida.Relleno.Add("lechuga");
            _comida.Relleno.Add("jalapeño");
        }
    }
}
