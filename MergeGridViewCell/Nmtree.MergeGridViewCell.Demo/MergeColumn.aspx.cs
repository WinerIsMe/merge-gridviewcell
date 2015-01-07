using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nmtree.Demo
{
    public partial class MergeColumn : System.Web.UI.Page
    {
        IndicatorRepository indicatorRepository = new IndicatorRepository();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var indicators = indicatorRepository.GetIndicators();

                gvBefore.DataSource = indicators;
                gvBefore.DataBind();

                gvAfter.DataSource = indicators;
                gvAfter.DataBind();
                Nmtree.MergeGridViewCell.MergeColumn(gvAfter, 1, 2, true);
                Nmtree.MergeGridViewCell.MergeRow(gvAfter, 0, 2);
            }
        }
    }
}