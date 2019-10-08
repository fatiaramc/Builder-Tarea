using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models
{
    public interface IComida
    {
        PanEnum Pan { get; set; }
        CarneEnum Carne { get; set; }
        List<string> Relleno { get; set; }
        string Nombre { get; set; }
        double Precio { get; set; }

        string ToString();
    }
}
