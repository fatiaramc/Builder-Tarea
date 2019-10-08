﻿using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class BigBuilder:Platillo
    {
        public override IComida PrepararComida()
        {
            _comida = new Hamburguesa
            {
                Pan = PanEnum.Bimbollo,
                Carne = CarneEnum.Pollo,
                Nombre = "Big King",
                Precio = 68.5,
                Relleno = new List<string>()
            };
            return _comida;
        }
        private void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("salsa agridulce");
            _comida.Relleno.Add("pepinillos");
            _comida.Relleno.Add("queso amarillo");
            _comida.Relleno.Add("lechuga");
        }
    }
}
