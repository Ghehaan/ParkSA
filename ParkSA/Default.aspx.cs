using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ParkSABusiness;
using ParkSACore;

namespace ParkSA
{
    public partial class _Default : System.Web.UI.Page
    {
        private ParkSABusinessManager business;

        public _Default(){
            business = new ParkSABusinessManager();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            List<FacilityType> facilityList = business.GetFacilityTypes();
            FacilityFilter.DataSource = facilityList;

            List<Park> parkList = business.GetParks();
            Parks.DataSource = parkList;
            
        }
    }
}
