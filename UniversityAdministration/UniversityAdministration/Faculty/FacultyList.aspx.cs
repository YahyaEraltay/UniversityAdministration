using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace UniversityAdministration
{
    public partial class FacultyList : System.Web.UI.Page
    {

        public void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet1TableAdapters.TBL_FacultyTableAdapter fac = new DataSet1TableAdapters.TBL_FacultyTableAdapter();

                Repeater1.DataSource = fac.GetDataFacultyList();
                Repeater1.DataBind();
            }
        }
        public string GetUniName(int id)
        {
            DataSet1TableAdapters.TBL_UniversityTableAdapter uni = new DataSet1TableAdapters.TBL_UniversityTableAdapter();

            string uniName = " ";
            try
            {
                uniName = uni.GetDataByUniversityList(id)[0].university_name;
            }
            catch
            {
                uniName = "University Data Not Found";
            }
            return uniName;
        }
    }
}