using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace UniversityAdministration.Professor
{
    public partial class AddProfessor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7V7GQ23; User Id=sa; Password=yahyabey308; Initial Catalog=UniversityAdministration_DB; Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from tbl_university", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();

            }

        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("Select Faculty");

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7V7GQ23; User Id=sa; Password=yahyabey308; Initial Catalog=UniversityAdministration_DB; Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from tbl_faculty where university_id=" + DropDownList1.SelectedItem.Value, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DropDownList2.DataSource = dt;
            DropDownList2.DataBind();
        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList3.Items.Clear();
            DropDownList3.Items.Add("Select Department");

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7V7GQ23; User Id=sa; Password=yahyabey308; Initial Catalog=UniversityAdministration_DB; Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from tbl_department where faculty_id=" + DropDownList2.SelectedItem.Value, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DropDownList3.DataSource = dt;
            DropDownList3.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_ProfessorTableAdapter pro = new DataSet1TableAdapters.TBL_ProfessorTableAdapter();
            int DepID = Convert.ToInt32(DropDownList3.SelectedItem.Value);
            int FacID = Convert.ToInt32(DropDownList2.SelectedItem.Value);
            int UniID = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            pro.InsertProfessor(TextBox1.Text, DepID, FacID, UniID);
            Response.Redirect("/Professor/ProfessorList.aspx");
        }
    }
}