using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models
{
    class Baguette : IComida
    {
        public PanEnum Pan { get; set; }
        public CarneEnum Carne { get; set; }
        public List<string> Relleno { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Baguette()
        {

        }

        public Baguette(PanEnum pan, CarneEnum carne, List<string> relleno)
        {

        }

        public override string ToString()
        {
            return $"Baguette {Nombre} " + Environment.NewLine +
                $"\t Pan: {Pan} " + Environment.NewLine +
                $"\t Carne: {Carne}" + Environment.NewLine +
                $"\t Relleno:" + Environment.NewLine + $"\t\t{string.Join(Environment.NewLine + "\t\t", Relleno)}" +
                Environment.NewLine + $"\t Precio unitario: {Precio}";
        }
    }
}
