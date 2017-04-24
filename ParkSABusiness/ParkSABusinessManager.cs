using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParkSAData;
using ParkSACore;

namespace ParkSABusiness
{
    public class ParkSABusinessManager
    {
        private ParkSADataManager data;
        public ParkSABusinessManager()
        {
            data = new ParkSADataManager();
        }

        public List<FacilityType> GetFacilityTypes()
        {
            List<FacilityType> list = data.Get<FacilityType>("GetFacilityTypes");
            return list;
        }

        public List<Park> GetParks()
        {
            List<Park> list = data.Get<Park>("GetParks");
            return list;
        }
    }
}
