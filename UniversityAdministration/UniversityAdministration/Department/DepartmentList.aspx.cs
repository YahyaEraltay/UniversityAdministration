using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityAdministration.Department
{
    public partial class DepartmentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBL_DepartmentTableAdapter dep = new DataSet1TableAdapters.TBL_DepartmentTableAdapter();

                Repeater1.DataSource = dep.GetDepartmentList();
                Repeater1.DataBind();
            }
        }
        public string GetFacName(int id)
        {
            DataSet1TableAdapters.TBL_FacultyTableAdapter fac = new DataSet1TableAdapters.TBL_FacultyTableAdapter();
            string FacName = " ";
            try
            {
                FacName = fac.GetDataByFaculty(id)[0].faculty_name;
            }
            catch
            {
                FacName = "Faculty Data Not Found";
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
                UniName = "University Data Not Found";  
            }
            return UniName;
        }
    }
}