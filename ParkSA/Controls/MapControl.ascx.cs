using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ParkSACore;

namespace ParkSA.Controls
{
    public partial class MapControl : System.Web.UI.UserControl
    {
        public List<IMap> DataSource;
        public MapControl()
        {
            DataSource = null;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DataSource != null)
            {
                MapMessage.Text = DataSource[0].Long + " " + DataSource[0].Lat;
            }
        }
    }
}