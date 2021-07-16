using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class StopLog
    {
        public long IDStopLog { get; set; }
        public int IDMachine { get; set; }
        public int IDStopCode{ get; set; }
        public int IDUsers { get; set; }
        public int IDTurn { get; set; }
        public DateTime StopLogBegin { get; set; }
        public DateTime StopLogFinish { get; set; }
        public string StopLogObservation { get; set; }
        public bool StopLogStatus { get; set; }

    }
}

