using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nmtree.Demo
{
    public partial class MergeRow : System.Web.UI.Page
    {
        SalaryRepository salaryRepository = new SalaryRepository();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var salaries = salaryRepository.GetSalaries();
                gvOrigin.DataSource = salaries;
                gvOrigin.DataBind();

                gvMerge.DataSource = salaries;
                gvMerge.DataBind();
                Nmtree.MergeGridViewCell.MergeRow(gvMerge, 0, 3);

                gvMerge1.DataSource = salaries;
                gvMerge1.DataBind();
                Nmtree.MergeGridViewCell.MergeRow(gvMerge1, 0, 1, 3, 2);

                gvMerge2.DataSource = salaries;
                gvMerge2.DataBind();
                Nmtree.MergeGridViewCell.MergeRow(gvMerge2, 0, 3, 1, 2);
            }
        }

        protected void gvOrigin_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.Cells[3].Text == "合计")
                {
                    e.Row.Attributes.Add("class", "hj");
                    e.Row.Cells[0].ColumnSpan = 4;
                    e.Row.Cells[0].Text = "合计";
                    e.Row.Cells[1].Visible = e.Row.Cells[2].Visible = e.Row.Cells[3].Visible = false;
                }
            }
        }
    }
}