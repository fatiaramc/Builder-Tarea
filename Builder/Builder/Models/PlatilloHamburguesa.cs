using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models
{
    public class PlatilloHamburguesa : Platillo
    {
        public override IComida PrepararComida()
        {
            return new Hamburguesa();
        }
    }
}
