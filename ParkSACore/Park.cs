using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkSACore
{
    [GetStoredProcedureName("GetParks")]
    public class Park : IMap
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Long { get; set; }
        public string Lat { get; set; }
    }
}
