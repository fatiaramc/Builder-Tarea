using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class SalchichaBuilder:Platillo
    {
        public override IComida PrepararComida()
        {
            _comida = new Sandwich
            {
                Pan = PanEnum.Integral,
                Carne = CarneEnum.Jamón,
                Nombre = "Salchicha",
                Precio = 86.6,
                Relleno = new List<string>()
            };
            PasoPrepararRelleno();
            return _comida;
        }
        private void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("salchicha");
            _comida.Relleno.Add("pepino");
            _comida.Relleno.Add("pimiento");
            _comida.Relleno.Add("espinaca");
        }
    }
}
