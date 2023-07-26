using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityAdministration
{
    public partial class UpdateUniversity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                int id = Convert.ToInt32(Request.QueryString["id"].ToString());
                DataSet1TableAdapters.TBL_UniversityTableAdapter uni = new DataSet1TableAdapters.TBL_UniversityTableAdapter();

                string uniName = uni.GetDataByUniversityList(id)[0].university_name;
                TextBox1.Text = uniName;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());
            DataSet1TableAdapters.TBL_UniversityTableAdapter uni = new DataSet1TableAdapters.TBL_UniversityTableAdapter();

            uni.UpdateUniversity(TextBox1.Text, id);
            Response.Redirect("/University/UniversityList.aspx");
        }
    }
}