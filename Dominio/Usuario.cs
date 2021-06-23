using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int      UserID        { get; set; }
        public int      UserIDProfile { get; set; }
        public int      UserIDEmployee{ get; set; }
        public string   UserName      { get; set; }
        public string   UserEmail     { get; set; }
        public string   UserPass      { get; set; }
        public string   UserDate      { get; set; }
    }
}
