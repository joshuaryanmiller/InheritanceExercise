using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public Reptile() { }
        public double Length { get; set; }
        public bool IsConstrictor { get; set; }
        public bool IsVenomous { get; set; }
        public bool IsColdblooded { get; set; }
    }
}
