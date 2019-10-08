﻿using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    //class BbqBuilder : HamburguesaBuilder
    class BbqBuilder : Platillo
    {
        //public BbqBuilder(PanEnum pan, CarneEnum carne)
        public override IComida PrepararComida()
        {
            //_hamburguesa = new Hamburguesa
            //return new Hamburguesa
            _comida = new Hamburguesa
            {
                Pan = PanEnum.Ajonjoli,
                Carne = CarneEnum.Res,
                Nombre = "Bbq",
                Precio = 56.6,
                Relleno = new List<string>()
            };
            PasoPrepararRelleno();
            return _comida;
        }
        private void PasoPrepararRelleno()
        {
            _comida.Relleno.Add("salsa bbq");
            _comida.Relleno.Add("mayonesa");
            _comida.Relleno.Add("pepinillos");
            _comida.Relleno.Add("queso");
            _comida.Relleno.Add("tocino");
        }
    }
}
