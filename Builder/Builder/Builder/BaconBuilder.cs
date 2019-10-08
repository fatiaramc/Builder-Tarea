using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class BaconBuilder:Platillo
    {
        public override IComida PrepararComida()
        {
            _comida = new Hamburguesa
            {
                Pan = PanEnum.Blanco,
                Carne = CarneEnum.Res,
                Nombre = "Bacon Burguer",
                Precio = 57.6,
                Relleno = new List<string>()
            };
            PasoPrepararRelleno();
            return _comida;
        }
        private void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("tocino");
            _comida.Relleno.Add("salsa catsup");
            _comida.Relleno.Add("mayonesa");
            _comida.Relleno.Add("queso americano");
            
        }
    }
}
