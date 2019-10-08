using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class HuevoBuilder:Platillo
    {
        public override IComida PrepararComida()
        {
            _comida = new Sandwich
            {
                Pan = PanEnum.Bimbollo,
                Carne = CarneEnum.Jamón,
                Nombre = "Huevo",
                Precio = 31.0,
                Relleno = new List<string>()
            };
            PasoPrepararRelleno();
            return _comida;
        }
        private void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("huevo");
            _comida.Relleno.Add("tocino");
        }
    }
}
