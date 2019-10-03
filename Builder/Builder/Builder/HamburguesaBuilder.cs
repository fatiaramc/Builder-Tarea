using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    public abstract class HamburguesaBuilder
    {
        protected Hamburguesa _hamburguesa;

        public Hamburguesa ObtenerHamburguesa() { return _hamburguesa; }

        public virtual void PasoPrepararRelleno() { }
    }
}
