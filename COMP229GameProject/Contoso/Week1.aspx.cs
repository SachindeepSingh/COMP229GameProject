using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COMP229GameProject;
using COMP229GameProject.Models;
using System.Web.ModelBinding;
namespace COMP229GameProject.Contoso
{
    public partial class Week1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.getCricket();
            }
        }

        /// <summary>
        /// This method gets battlefield data from the database
        /// </summary>

        protected void getCricket()
        {
            using (TeamContext db = new TeamContext())
            {
                var TeamData = (from allTeams in db.Teams
                                select allTeams);

                CricketsGridView.DataSource = TeamData.ToList();
                CricketsGridView.DataBind();
            }
        }
    }
}