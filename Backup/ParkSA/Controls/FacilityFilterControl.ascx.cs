using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ParkSACore;

namespace ParkSA.Controls
{
    public partial class FacilityFilterControl : System.Web.UI.UserControl
    {
        public List<FacilityType> DataSource;
        public FacilityFilterControl()
        {
            DataSource = null;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DataSource != null)
            {
                foreach (FacilityType item in DataSource)
                {
                    LiteralControl lc = new LiteralControl();
                    lc.Text = "<div class=\"filterIcon\">" + item.Name + "</div>";
                    FilterPanel.Controls.Add(lc);
                }
                LiteralControl lc3 = new LiteralControl();
                lc3.Text = "<div class=\"clear\"></div>";
                FilterPanel.Controls.Add(lc3);
            }
        }
    }
}