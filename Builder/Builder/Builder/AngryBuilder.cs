using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class AngryBuilder : Platillo
    {
        public override IComida PrepararComida()
        {
            _comida = new Hamburguesa
            {
                Pan = PanEnum.Blanco,
                Carne = CarneEnum.Res,
                Nombre = "Angry",
                Precio = 127.3,
                Relleno = new List<string>()
            };
            PasoPrepararRelleno();
            return _comida;
        }
        private void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("tomate");
            _comida.Relleno.Add("mayonesa");
            _comida.Relleno.Add("cebollitas angry");
            _comida.Relleno.Add("tocino");
        }
    }
}
