using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class DobleBuilder:Platillo
    {
        public override IComida PrepararComida()
        {
            _comida = new Hamburguesa
            {
                Pan = PanEnum.Doble,
                Carne = CarneEnum.Doble,
                Nombre = "Doble con queso",
                Precio = 90.0,
                Relleno = new List<string>()
            };
            PasoPrepararRelleno();
            return _comida;
        }
        private void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("tomate");
            _comida.Relleno.Add("cebolla");
            _comida.Relleno.Add("lechuga");
            _comida.Relleno.Add("mayonesa");
            _comida.Relleno.Add("queso");
        }
    }
}
