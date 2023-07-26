using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityAdministration.Professor
{
    public partial class ProfessorList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBL_ProfessorTableAdapter pro = new DataSet1TableAdapters.TBL_ProfessorTableAdapter();
                Repeater1.DataSource = pro.GetDataProfessorList();
                Repeater1.DataBind();
            }
        }
        public string GetDepName(int id)
        {
            DataSet1TableAdapters.TBL_DepartmentTableAdapter dep = new DataSet1TableAdapters.TBL_DepartmentTableAdapter();
            string DepName = " ";
            try
            {
                DepName = dep.GetDataByDepartment(id)[0].department_name;
            }
            catch
            {
                DepName = "No Data Found";
            }
            return DepName;
        }
        public string GetFacName(int id)
        {
            DataSet1TableAdapters.TBL_FacultyTableAdapter fac = new DataSet1TableAdapters.TBL_FacultyTableAdapter();
            string FacName = " ";
            try
            {
                FacName = fac.GetDataByFaculty(id)[0].faculty_name;
            }
            catch (Exception)
            {
                FacName = "No Data Found";
            }
            return FacName;
        }
        public string GetUniName(int id)
        {
            DataSet1TableAdapters.TBL_UniversityTableAdapter uni = new DataSet1TableAdapters.TBL_UniversityTableAdapter();
            string UniName = " ";
            try
            {
                UniName = uni.GetDataByUniversityList(id)[0].university_name;
            }
            catch 
            {
                UniName = "No Data Found";
            }
            return UniName;
        }
    }
}