using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityAdministration.Professor
{
    public partial class DeleteProfessor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_ProfessorTableAdapter pro = new DataSet1TableAdapters.TBL_ProfessorTableAdapter();
            int id = Convert.ToInt32(Request.QueryString["id"]);
            pro.DeleteProfessor(id);
            Response.Redirect("/Professor/ProfessorList.aspx");
            
        }
    }
}