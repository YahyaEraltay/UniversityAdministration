using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityAdministration
{
    public partial class UpdateFaculty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);

                DataSet1TableAdapters.TBL_UniversityTableAdapter uni = new DataSet1TableAdapters.TBL_UniversityTableAdapter();
                DataSet1TableAdapters.TBL_FacultyTableAdapter fac = new DataSet1TableAdapters.TBL_FacultyTableAdapter();

                int UniID = fac.GetDataByFaculty(id)[0].university_id;
                string UniName = uni.GetDataByUniversityList(UniID)[0].university_name;
                string FacName = fac.GetDataByFaculty(id)[0].faculty_name;

                TextBox1.Text = FacName;
                DropDownList1.Items.Clear();
                DropDownList1.DataSource = uni.GetUniversityList();
                DropDownList1.DataTextField = "university_name";
                DropDownList1.DataValueField = "university_id";
                DropDownList1.DataBind();

                DropDownList1.SelectedIndex = DropDownList1.Items.IndexOf(DropDownList1.Items.FindByText(UniName));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_FacultyTableAdapter fac = new DataSet1TableAdapters.TBL_FacultyTableAdapter();
            int id = Convert.ToInt32(Request.QueryString["id"]);
            int UnivID = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            fac.UpdateFaculty(TextBox1.Text, UnivID, id);
            Response.Redirect("/Faculty/FacultyList.aspx");
        }
    }
}