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
    public partial class AddDepartment : System.Web.UI.Page
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

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Page.IsPostBack == true)
            {
                DropDownList2.Items.Clear();

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7V7GQ23; User Id=sa; Password=yahyabey308; Initial Catalog=UniversityAdministration_DB; Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from tbl_faculty where university_id=" + DropDownList1.SelectedItem.Value, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DropDownList2.DataSource = dt;
                DropDownList2.DataTextField = "faculty_name";
                DropDownList2.DataValueField = "faculty_id";
                DropDownList2.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_DepartmentTableAdapter dep = new DataSet1TableAdapters.TBL_DepartmentTableAdapter();
            int id = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            int id2 = Convert.ToInt32(DropDownList2.SelectedItem.Value);
            dep.InsertDepartment(TextBox1.Text, id2, id);
            Response.Redirect("/Department/DepartmentList.aspx");
        }
    }
}