using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nmtree.Demo
{
    public class IndicatorRepository
    {
        private static IList<Indicator> indicators;

        static IndicatorRepository()
        {

            #region 模拟数据
            indicators = new List<Indicator> {
                 new Indicator
                {
                    First = "培训设计",
                    Second = "目标规划",
                    Third = "目标规划",
                },
                new Indicator
                {
                    First = "培训设计",
                    Second = "方案策划",
                    Third = "方案策划",
                },
                new Indicator
                {
                    First = "培训设计",
                    Second = "师资选择",
                    Third = "师资选择",
                },
                new Indicator
                {
                    First = "培训设计",
                    Second = "制度规范",
                    Third = "制度规范",
                },

                new Indicator
                {
                    First = "培训实施",
                    Second = "实施前",
                    Third = "培训目标",
                },

                new Indicator
                {
                    First = "培训实施",
                    Second = "实施前",
                    Third = "预期效果",
                },
                new Indicator
                {
                    First = "培训实施",
                    Second = "实施前",
                    Third = "学员特征",
                },
                new Indicator
                {
                    First = "培训实施",
                    Second = "实施中",
                    Third = "培训方式",
                },
                new Indicator
                {
                    First = "培训实施",
                    Second = "实施中",
                    Third = "课程安排",
                },
                new Indicator
                {
                    First = "培训实施",
                    Second = "实施中",
                    Third = "培训方法",
                },
                new Indicator
                {
                    First = "培训实施",
                    Second = "实施后",
                    Third = "书面考核",
                },
                new Indicator
                {
                    First = "培训实施",
                    Second = "实施后",
                    Third = "绩效评测",
                }
            };

            #endregion
        }


        public IEnumerable<Indicator> GetIndicators()
        {
            return indicators;
        }
    }
}