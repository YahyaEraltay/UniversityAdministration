using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace UniversityAdministration.Department
{
    public partial class UpdateDepartment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);

                DataSet1TableAdapters.TBL_UniversityTableAdapter uni = new DataSet1TableAdapters.TBL_UniversityTableAdapter();
                DataSet1TableAdapters.TBL_FacultyTableAdapter fac = new DataSet1TableAdapters.TBL_FacultyTableAdapter();
                DataSet1TableAdapters.TBL_DepartmentTableAdapter dep = new DataSet1TableAdapters.TBL_DepartmentTableAdapter();

                int UniID = dep.GetDataByDepartment(id)[0].university_id;
                string UniName = uni.GetDataByUniversityList(UniID)[0].university_name;
                int FacID = dep.GetDataByDepartment(id)[0].faculty_id;
                string FacName = fac.GetDataByFaculty(FacID)[0].faculty_name;
                string DepName = dep.GetDataByDepartment(id)[0].department_name;

                
                DropDownList1.Items.Clear();
                DropDownList1.DataSource = uni.GetUniversityList();
                DropDownList1.DataTextField = "university_name";
                DropDownList1.DataValueField = "university_id";
                DropDownList1.DataBind();

                DropDownList1.SelectedIndex = DropDownList1.Items.IndexOf(DropDownList1.Items.FindByText(UniName));

                DropDownList2.Items.Clear();
                DropDownList2.DataSource = fac.GetDataFacultyList();
                DropDownList2.DataTextField = "faculty_name";
                DropDownList2.DataValueField = "faculty_id";
                DropDownList2.DataBind();

                DropDownList2.SelectedIndex = DropDownList2.Items.IndexOf(DropDownList2.Items.FindByText(FacName));

                TextBox1.Text = DepName;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_DepartmentTableAdapter dep = new DataSet1TableAdapters.TBL_DepartmentTableAdapter();
            int id = Convert.ToInt32(Request.QueryString["id"]);
            int UnivID = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            int FacID = Convert.ToInt32(DropDownList2.SelectedItem.Value);
            dep.UpdateDepartment(TextBox1.Text, FacID, UnivID, id);
            Response.Redirect("/Department/DepartmentList.aspx");
        }
    }

}