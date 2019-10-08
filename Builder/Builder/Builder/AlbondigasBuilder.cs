using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class AlbondigasBuilder : Platillo
    {
        public override IComida PrepararComida()
        {
            _comida = new Sandwich
            {
                Pan = PanEnum.Ajonjoli,
                Carne = CarneEnum.Res,
                Nombre = "Albondigas",
                Precio = 56.6,
                Relleno = new List<string>()
            };
            PasoPrepararRelleno();
            return _comida;
        }
        private void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("salsa albondigas");
            _comida.Relleno.Add("mayonesa");
            _comida.Relleno.Add("queso");            
        }
    }
}
