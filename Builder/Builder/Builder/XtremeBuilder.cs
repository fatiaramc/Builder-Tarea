using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class XtremeBuilder:Platillo
    {
        public override IComida PrepararComida()
        {
            _comida = new Hamburguesa
            {
                Pan = PanEnum.Bimbollo,
                Carne = CarneEnum.Doble,
                Nombre = "X-treme",
                Precio = 63.9,
                Relleno = new List<string>()
            };
            PasoPrepararRelleno();
            return _comida;
        }
        private void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("tomate");
            _comida.Relleno.Add("mayonesa");
            _comida.Relleno.Add("pepinillos");
            _comida.Relleno.Add("cebolla");
            _comida.Relleno.Add("queso amarillo");
            _comida.Relleno.Add("queso americano");
        }
    }
}
