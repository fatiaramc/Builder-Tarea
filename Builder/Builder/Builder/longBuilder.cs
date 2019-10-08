﻿using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class longBuilder:Platillo
    {
        public override IComida PrepararComida()
        {
            _comida = new Hamburguesa
            {
                Pan = PanEnum.Integral,
                Carne = CarneEnum.Pollo,
                Nombre = "Long Rodeo",
                Precio = 110.2,
                Relleno = new List<string>()
            };
            PasoPrepararRelleno();
            return _comida;
        }
        private void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("salsa bbq");
            _comida.Relleno.Add("aros de cebolla");
            _comida.Relleno.Add("queso americano");
        }
    }
}
