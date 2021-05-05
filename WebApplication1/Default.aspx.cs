using System;
//using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            datebutton.CommandArgument = ConfigurationManager.AppSettings["Date"]; 
        }

        protected void Hello__Command(object sender, CommandEventArgs e)
        {
            info.InnerText = e.CommandArgument.ToString();

        }

        protected void Datum_Command(object sender, CommandEventArgs e)
        {
            DateTime dt = DateTime.Parse(e.CommandArgument.ToString());
            datum.InnerText = dt.ToString();
        }
    }
}