using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkSACore
{
    [GetStoredProcedureName("GetParks")]
    public class Park
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
