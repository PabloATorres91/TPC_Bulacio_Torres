using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Part
    {
        public int IDPart { get; set; }
        public int IDMachine { get; set; }
        public string PartName { get; set; }
        public string PartDescription { get; set; }
        public bool PartStatus { get; set; }
    }
}
