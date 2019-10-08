using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class RodeoBuilder:Platillo
    {
        public override IComida PrepararComida()
        {
            _comida = new Hamburguesa
            {
                Pan = PanEnum.Blanco,
                Carne = CarneEnum.Doble,
                Nombre = "Rodeo Burguer",
                Precio = 50.4,
                Relleno = new List<string>()
            };
            PasoPrepararRelleno();
            return _comida;
        }
        private void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("salsa bbq ahumado");
            _comida.Relleno.Add("aros de cebolla");
        }
    }
}
