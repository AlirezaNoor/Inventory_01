using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class GolbalGeneric
    {
        public long Id { get; set; }
        public DateTime Time{ get; set; }

        public GolbalGeneric()
        {
            Time = DateTime.Now;
        }
    }
}
