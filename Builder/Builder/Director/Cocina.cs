using Builder.Builder;
using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Director
{
    class Cocina
    {
        private HamburguesaBuilder _hamburguesaBuilder;

        public void RecepcionarProximaHamburguesa(HamburguesaBuilder hamburguesaBuilder)
        {
            _hamburguesaBuilder = hamburguesaBuilder;
        }

        public void CocinarHamburguesaPasoaPaso()
        {
            _hamburguesaBuilder.PasoPrepararRelleno();
        }

        public Hamburguesa HamburguesaPreparada => _hamburguesaBuilder.ObtenerHamburguesa();

        public Hamburguesa CocinarHamburguesa(HamburguesaBuilder hamburguesaBuilder)
        {
            hamburguesaBuilder.PasoPrepararRelleno();
            return hamburguesaBuilder.ObtenerHamburguesa();
        }
    }
}
