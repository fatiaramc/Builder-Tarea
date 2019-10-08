﻿using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class HabaneroBuilder:Platillo
    {
        public override IComida PrepararComida()
        {
            _comida = new Hamburguesa
            {
                Pan = PanEnum.Integral,
                Carne = CarneEnum.Res,
                Nombre = "Mango Habanero",
                Precio = 98.5,
                Relleno = new List<string>()
            };
            PasoPrepararRelleno();
            return _comida;
        }
        private void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("salsa Mango Habanero");
            _comida.Relleno.Add("cebollitas");
            _comida.Relleno.Add("lechuga");
            _comida.Relleno.Add("tocino");
        }
    }
}
