using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ParkSACore;

namespace ParkSA.Controls
{
    public partial class ParksControl : System.Web.UI.UserControl
    {
        public List<Park> DataSource;
        public ParksControl()
        {
            DataSource = null;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DataSource != null)
            {
                Total.Text = DataSource.Count + " parks";
                int x = 0;
                for (int i = 0; i < DataSource.Count; i++)
                {
                    Park item = DataSource[i];
                    LiteralControl lc = new LiteralControl();

                    if (i == 0)
                    {
                        lc.Text = "<div class=\"row\">";
                        lc.Text += GetParkHTML(item);
                    }
                    else if (i + 1 == DataSource.Count)
                    {
                        lc.Text += GetParkHTML(item);
                        lc.Text += "</div>";
                    }
                    else
                    {
                        lc.Text += GetParkHTML(item);
                    }

                    ParksList.Controls.Add(lc);
                    x++;
                }
            }
        }

        private string GetParkHTML(Park item)
        {
            string text = "";
            text = "<div class=\"col-sm-12\">";
            text += "<div class=\"Park\">";
            text += "<div class=\"ParkImage\"><img class=\"img-responsive\" src=\"Images\\waterhole.jpg\" /></div>";
            text += "<div class=\"Info\">";
            text += "<div class=\"ParkTitle\" >" + item.Name + "</div>";
            text += "<div class=\"Description\">address</div>";
            text += "<div class=\"ViewPark\"><button type=\"button\" class=\"btn btn-info\">View Park</button></div>";
            text += "</div>";
            text += "</div><div style=\"clear:borh;\"></div></div>";
            return text;
        }
    }
}