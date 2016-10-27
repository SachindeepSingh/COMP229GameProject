using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// using statements that are required to connect to EF DB
using COMP229GameProject.Models;
using System.Web.ModelBinding;
using System.Linq.Dynamic;
namespace COMP229GameProject
{
    public partial class Week4 : System.Web.UI.Page
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
                var TeamData = (from allTeams in db.FourthTeam
                                select allTeams);

                CricketsGridView.DataSource = TeamData.ToList();
                CricketsGridView.DataBind();
            }
        
         }
    }
}