﻿/**********************************************/
// 名称：MergeGridViewCell
// 作者：田念明
// 博客：http://nianming.cnblogs.com/    http://www.chengxulvtu.com/
// 时间：2012-10-10 17:40
// 描述：用来合并GridView单元格。
/*********************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;

namespace Nmtree
{
    /// <summary>
    /// 合并GridView单元格
    /// </summary>
    public class MergeGridViewCell
    {

        #region Public

        /// <summary>
        /// GridView合并行
        /// </summary>
        /// <param name="gv">GridView</param>
        /// <param name="startCol">开始列（索引从0开始）</param>
        /// <param name="endCol">结束列</param>
        public static void MergeRow(GridView gv, int startCol, int endCol)
        {
            if (startCol < 0)
                throw new ArgumentOutOfRangeException("startCol", "开始列不能小于0");
            if (endCol < 0)
                throw new ArgumentOutOfRangeException("endCol", "结束列不能小于0");
            if (startCol > endCol)
                throw new ArgumentException("开始列不能小于结束列");

            var init = new RowArg()
            {
                StartRowIndex = 0,
                EndRowIndex = gv.Rows.Count - 2
            };
            for (int i = startCol; i < endCol + 1; i++)
            {
                if (i > 0)
                {
                    var list = new List<RowArg>();
                    //从第二列开始就要遍历前一列
                    IteratePrevCol(gv, i - 1, list);
                    foreach (var item in list)
                    {
                        MergeRow(gv, i, item.StartRowIndex, item.EndRowIndex);
                    }
                }
                //合并开始列的行
                else
                {
                    MergeRow(gv, i, init.StartRowIndex, init.EndRowIndex);
                }
            }
        }

        /// <summary>
        /// 合并GridView单元格
        /// </summary>
        /// <param name="gv">要合并的GridView</param>
        /// <param name="cols">制定的列</param>
        public static void MergeRow(GridView gv, params int[] cols)
        {
            if (cols.Any(t => t < 0))
            {
                throw new ArgumentOutOfRangeException("参数中不能包含小于0列");
            }
            var init = new RowArg()
            {
                StartRowIndex = 0,
                EndRowIndex = gv.Rows.Count - 2
            };

            for (int i = 0; i < cols.Length; i++)
            {
                if (i > 0)
                {
                    var list = new List<RowArg>();
                    //从第二列开始就要遍历前一列
                    IteratePrevCol(gv, cols[i - 1], list);
                    foreach (var item in list)
                    {
                        MergeRow(gv, cols[i], item.StartRowIndex, item.EndRowIndex);
                    }
                }
                //合并开始列的行
                else
                {
                    MergeRow(gv, i, init.StartRowIndex, init.EndRowIndex);
                }
            }
        }

        /// <summary>
        /// 和并列
        /// </summary>
        /// <param name="gv">要合并的GridView</param>
        /// <param name="startCol">开始列的索引</param>
        /// <param name="endCol">结束列的索引</param>
        /// <param name="containHeader">是否合并表头，默认不合并</param>
        public static void MergeColumn(GridView gv, int startCol, int endCol, bool containHeader = false)
        {
            if (containHeader)
            {
                IterateRowCells(gv.HeaderRow, startCol, endCol);
            }
            foreach (GridViewRow row in gv.Rows)
            {
                IterateRowCells(row, startCol, endCol);
            }
        }

        #endregion


        #region Private

        /// <summary>
        /// 合并单列的行
        /// </summary>
        /// <param name="gv">GridView</param>
        /// <param name="currentCol">当前列</param>
        /// <param name="startRow">开始合并的行索引</param>
        /// <param name="endRow">结束合并的行索引</param>
        private static void MergeRow(GridView gv, int currentCol, int startRow, int endRow)
        {
            for (int rowIndex = endRow; rowIndex >= startRow; rowIndex--)
            {
                GridViewRow currentRow = gv.Rows[rowIndex];
                GridViewRow prevRow = gv.Rows[rowIndex + 1];
                if (currentRow.Cells[currentCol].Text != "" && currentRow.Cells[currentCol].Text != " ")
                {
                    if (currentRow.Cells[currentCol].Text == prevRow.Cells[currentCol].Text)
                    {
                        currentRow.Cells[currentCol].RowSpan = prevRow.Cells[currentCol].RowSpan < 1 ? 2 : prevRow.Cells[currentCol].RowSpan + 1;
                        prevRow.Cells[currentCol].Visible = false;
                    }
                }
            }
        }

        /// <summary>
        /// 遍历GridViewRow中的单元格
        /// </summary>
        /// <param name="row">要遍历的行</param>
        /// <param name="start">开始索引</param>
        /// <param name="end">结束索引</param>
        private static void IterateRowCells(GridViewRow row, int start, int end)
        {
            //从开始索引的下一列开始
            for (int i = start + 1; i <= end; i++)
            {
                //当前单元格
                TableCell currCell = row.Cells[i];
                //前一个单元格
                TableCell prevCell = row.Cells[i - 1];
                if (!string.IsNullOrEmpty(currCell.Text) && !string.IsNullOrEmpty(prevCell.Text))
                {
                    if (currCell.Text == prevCell.Text)
                    {
                        currCell.ColumnSpan = prevCell.ColumnSpan < 1 ? 2 : prevCell.ColumnSpan + 1;
                        prevCell.Visible = false;
                    }
                }
            }
        }

        /// <summary>
        /// 遍历前一列
        /// </summary>
        /// <param name="gv">GridView</param>
        /// <param name="prevCol">当前列的前一列</param>
        /// <param name="list"></param>
        private static void IteratePrevCol(GridView gv, int prevCol, List<RowArg> list)
        {
            if (list == null)
            {
                list = new List<RowArg>();
            }
            foreach (GridViewRow row in gv.Rows)
            {
                if (!row.Cells[prevCol].Visible)
                    continue;
                list.Add(new RowArg
                {
                    StartRowIndex = row.RowIndex,
                    EndRowIndex = row.RowIndex + row.Cells[prevCol].RowSpan - 2
                });
            }
        }

        class RowArg
        {
            public int StartRowIndex { get; set; }
            public int EndRowIndex { get; set; }
        }

        #endregion
    }
}
