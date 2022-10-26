using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC6
{
    public partial class Test : System.Web.UI.Page
    {
        string[] s_school = new string [3] {"台科", "北科", "亞東"};
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i_Ct = 0; i_Ct < s_school.Length; i_Ct++)
            {
                ListItem c_L = new ListItem();
                c_L.Text = c_L.Value = s_school[i_Ct];
                ddl_Test.Items.Add(c_L);
            }
        }
    }
}