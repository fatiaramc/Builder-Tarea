using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models
{
    public abstract class Platillo
    {
        protected IComida _comida;
        public abstract IComida PrepararComida();
    }
}
