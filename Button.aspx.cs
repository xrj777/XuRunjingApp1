using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XuRunjing0221WebApplication
{
    public partial class Button : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ButtonEX_Click(object sender, EventArgs e)
        {
            LableClick.Text=sender.GetType().Name;
        }

        protected void ButtonEX_Command(object sender, CommandEventArgs e)
        {
            LabelMessage.Text = e.CommandName;
        }

        protected void ButtonEx_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonEx_Command(object sender, CommandEventArgs e)
        {

        }

        protected void ButtonEx_(object sender, CommandEventArgs e)
        {

        }

        protected void ButtonEx_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}