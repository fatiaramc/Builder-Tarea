using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class ItalianoBuilder : Platillo
    {
        public override IComida PrepararComida()
        {
            _comida = new Baguette
            {
                Pan = PanEnum.Integral,
                Carne = CarneEnum.Jamón,
                Nombre = "Italiano",
                Precio = 42.0,
                Relleno = new List<string>()
            };
            PasoPrepararRelleno();
            return _comida;
        }
        private void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("vinagreta");
            _comida.Relleno.Add("jitomate");
            _comida.Relleno.Add("lechuga");
            _comida.Relleno.Add("pimiento");
        }
    }
}
