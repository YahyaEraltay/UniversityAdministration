using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityAdministration.Professor
{
    public partial class UpdateProfessor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);

                DataSet1TableAdapters.TBL_UniversityTableAdapter uni = new DataSet1TableAdapters.TBL_UniversityTableAdapter();
                DataSet1TableAdapters.TBL_FacultyTableAdapter fac = new DataSet1TableAdapters.TBL_FacultyTableAdapter();
                DataSet1TableAdapters.TBL_DepartmentTableAdapter dep = new DataSet1TableAdapters.TBL_DepartmentTableAdapter();
                DataSet1TableAdapters.TBL_ProfessorTableAdapter pro = new DataSet1TableAdapters.TBL_ProfessorTableAdapter();

                int UniID = pro.GetDataByProfessorList(id)[0].university_id;
                string UniName = uni.GetDataByUniversityList(UniID)[0].university_name;
                int FacID = pro.GetDataByProfessorList(id)[0].faculty_id;
                string FacName = fac.GetDataByFaculty(FacID)[0].faculty_name;
                int DepID = pro.GetDataByProfessorList(id)[0].department_id;
                string DepName = dep.GetDataByDepartment(DepID)[0].department_name;
                string ProName = pro.GetDataByProfessorList(id)[0].professor_name;


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

                DropDownList3.Items.Clear();
                DropDownList3.DataSource = dep.GetDepartmentList();
                DropDownList3.DataTextField = "department_name";
                DropDownList3.DataValueField = "department_id";
                DropDownList3.DataBind();

                DropDownList3.SelectedIndex = DropDownList3.Items.IndexOf(DropDownList3.Items.FindByText(DepName));

                TextBox1.Text = ProName;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_ProfessorTableAdapter pro = new DataSet1TableAdapters.TBL_ProfessorTableAdapter();
            int id = Convert.ToInt32(Request.QueryString["id"]);
            int UnivID = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            int FacID = Convert.ToInt32(DropDownList2.SelectedItem.Value);
            int DepID = Convert.ToInt32(DropDownList3.SelectedItem.Value);
            pro.UpdateProfessor(TextBox1.Text, DepID, FacID, UnivID, id);
            Response.Redirect("/Professor/ProfessorList.aspx");
        }
    }
}