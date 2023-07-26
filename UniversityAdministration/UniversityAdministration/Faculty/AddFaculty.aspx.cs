using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityAdministration
{
    public partial class AddFaculty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBL_UniversityTableAdapter uni = new DataSet1TableAdapters.TBL_UniversityTableAdapter();

                DropDownList1.Items.Clear();
                DropDownList1.AppendDataBoundItems = true;
                DropDownList1.Items.Add(new ListItem("Select University", " "));
                DropDownList1.DataSource = uni.GetUniversityList();
                DropDownList1.DataTextField = "university_name";
                DropDownList1.DataValueField = "university_id";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_FacultyTableAdapter fac = new DataSet1TableAdapters.TBL_FacultyTableAdapter();
            int id = Convert.ToInt32(DropDownList1.SelectedItem.Value);

            fac.InsertFaculty(TextBox1.Text, id);
            Response.Redirect("/Faculty/FacultyList.aspx");
        }
    }
}