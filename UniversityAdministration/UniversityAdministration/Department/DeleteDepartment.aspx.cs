using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityAdministration.Department
{
    public partial class DeleteDepartment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_DepartmentTableAdapter dep = new DataSet1TableAdapters.TBL_DepartmentTableAdapter();
            int id = Convert.ToInt32(Request.QueryString["id"]);
            dep.DeleteDepartment(id);
            Response.Redirect("/Department/DepartmentList.aspx");
        }
    }
}