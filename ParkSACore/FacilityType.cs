using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkSACore
{
    [GetStoredProcedureName("GetFacilityTypes")]
    public class FacilityType
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
