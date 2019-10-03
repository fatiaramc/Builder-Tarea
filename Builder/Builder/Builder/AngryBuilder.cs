using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class AngryBuilder : HamburguesaBuilder
    {
        public AngryBuilder(PanEnum pan, CarneEnum carne)
        {
            _hamburguesa = new Hamburguesa
            {
                Pan = pan,
                Carne = carne,
                Nombre = "Angry",
                Precio = 127.3,
                Relleno = new List<string>()
            };
        }
        public override void PasoPrepararRelleno()
        {
            _hamburguesa.Relleno.Add("tomate");
            _hamburguesa.Relleno.Add("mayonesa");
            _hamburguesa.Relleno.Add("cebollitas angry");
            _hamburguesa.Relleno.Add("tocino");
        }
    }
}
