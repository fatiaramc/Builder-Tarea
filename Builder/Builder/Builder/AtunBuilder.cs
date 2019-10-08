using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class AtunBuilder: Platillo
    {
        public override IComida PrepararComida()
        {
            _comida = new Baguette
            {
                Pan = PanEnum.Blanco,
                Carne = CarneEnum.Atún,
                Nombre = "Atun",
                Precio = 35.0,
                Relleno = new List<string>()
            };
            PasoPrepararRelleno();
            return _comida;
        }
        private void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("mayonesa");
            _comida.Relleno.Add("jitomate");
            _comida.Relleno.Add("lechuga");
        }
    }
}
