using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class MantequillaBuilder : Platillo
    {
        public override IComida PrepararComida()
        {
            _comida = new Sandwich
            {
                Pan = PanEnum.Blanco,
                Carne = CarneEnum.SinCarne,
                Nombre = "Mantequilla de mani",
                Precio = 56.6,
                Relleno = new List<string>()
            };
            PasoPrepararRelleno();
            return _comida;
        }
        private void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("mantequilla de mani");
            _comida.Relleno.Add("jalea");
        }
    }
}
