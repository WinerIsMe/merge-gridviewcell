using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nmtree.Demo
{
    public class SalaryRepository
    {
        private static IList<Salary> salaryList;


        static SalaryRepository()
        {
            #region 模拟数据
            salaryList = new List<Salary>
            {
                new Salary
                {
                    Name = "张三",
                    Item = "应发工资",
                    SubItem = "基本工资",
                    Month = "1月",
                    Money = "3000"
                },
                new Salary
                {
                    Name = "张三",
                    Item = "应发工资",
                    SubItem = "奖金",
                    Month = "1月",
                    Money = "500"
                },
                new Salary
                {
                    Name = "张三",
                    Item = "应发工资",
                    SubItem = "奖金",
                    Month = "1月",
                    Money = "130"
                },
                new Salary
                {
                    Name = "张三",
                    Item = "应发工资",
                    SubItem = "奖金",
                    Month = "1月",
                    Money = "150"
                },
                new Salary
                {
                    Name = "张三",
                    Item = "应发工资",
                    SubItem = "加班",
                    Month = "1月",
                    Money = "100"
                },
                new Salary
                {
                    Name = "张三",
                    Item = "应发工资",
                    SubItem = "加班",
                    Month = "1月",
                    Money = "100"
                },
                new Salary
                {
                    Name = "张三",
                    Item = "五险一金",
                    SubItem = "医疗保险",
                    Month = "1月",
                    Money = "500"
                },
                new Salary
                {
                    Name = "张三",
                    Item = "五险一金",
                    SubItem = "住房公积金",
                    Month = "1月",
                    Money = "370"
                },
                new Salary
                {
                    Name = "",
                    Item = "",
                    SubItem = "",
                    Month = "合计",
                    Money = "3500"
                },
                new Salary
                {
                    Name = "张三",
                    Item = "应发工资",
                    SubItem = "基本工资",
                    Month = "2月",
                    Money = "3000"
                },
                new Salary
                {
                    Name = "张三",
                    Item = "应发工资",
                    SubItem = "奖金",
                    Month = "2月",
                    Money = "400"
                },
                new Salary
                {
                    Name = "张三",
                    Item = "应发工资",
                    SubItem = "奖金",
                    Month = "2月",
                    Money = "100"
                },
                new Salary
                {
                    Name = "张三",
                    Item = "应发工资",
                    SubItem = "加班",
                    Month = "2月",
                    Money = "100"
                },
                new Salary
                {
                    Name = "张三",
                    Item = "应发工资",
                    SubItem = "加班",
                    Month = "2月",
                    Money = "100"
                },
                new Salary
                {
                    Name = "张三",
                    Item = "应发工资",
                    SubItem = "加班",
                    Month = "2月",
                    Money = "100"
                },
                new Salary
                {
                    Name = "张三",
                    Item = "五险一金",
                    SubItem = "医疗保险",
                    Month = "2月",
                    Money = "500"
                },
                new Salary
                {
                    Name = "张三",
                    Item = "五险一金",
                    SubItem = "住房公积金",
                    Month = "2月",
                    Money = "370"
                },
                new Salary
                {
                    Name = "",
                    Item = "",
                    SubItem = "",
                    Month = "合计",
                    Money = "3900"
                },
                new Salary
                {
                    Name = "李四",
                    Item = "应发工资",
                    SubItem = "基本工资",
                    Month = "1月",
                    Money = "3000"
                },
                new Salary
                {
                    Name = "李四",
                    Item = "应发工资",
                    SubItem = "奖金",
                    Month = "1月",
                    Money = "500"
                },
                new Salary
                {
                    Name = "李四",
                    Item = "应发工资",
                    SubItem = "奖金",
                    Month = "1月",
                    Money = "130"
                },
                new Salary
                {
                    Name = "李四",
                    Item = "应发工资",
                    SubItem = "奖金",
                    Month = "1月",
                    Money = "150"
                },
                new Salary
                {
                    Name = "李四",
                    Item = "应发工资",
                    SubItem = "加班",
                    Month = "1月",
                    Money = "100"
                },
                new Salary
                {
                    Name = "李四",
                    Item = "应发工资",
                    SubItem = "加班",
                    Month = "1月",
                    Money = "100"
                },
                new Salary
                {
                    Name = "李四",
                    Item = "五险一金",
                    SubItem = "医疗保险",
                    Month = "1月",
                    Money = "500"
                },
                new Salary
                {
                    Name = "李四",
                    Item = "五险一金",
                    SubItem = "住房公积金",
                    Month = "1月",
                    Money = "370"
                },
                new Salary
                {
                    Name = "",
                    Item = "",
                    SubItem = "",
                    Month = "合计",
                    Money = "3500"
                },
                new Salary
                {
                    Name = "李四",
                    Item = "应发工资",
                    SubItem = "基本工资",
                    Month = "2月",
                    Money = "3000"
                },
                new Salary
                {
                    Name = "李四",
                    Item = "应发工资",
                    SubItem = "奖金",
                    Month = "2月",
                    Money = "400"
                },
                new Salary
                {
                    Name = "李四",
                    Item = "应发工资",
                    SubItem = "奖金",
                    Month = "2月",
                    Money = "100"
                },
                new Salary
                {
                    Name = "李四",
                    Item = "应发工资",
                    SubItem = "加班",
                    Month = "2月",
                    Money = "100"
                },
                new Salary
                {
                    Name = "李四",
                    Item = "应发工资",
                    SubItem = "加班",
                    Month = "2月",
                    Money = "100"
                },
                new Salary
                {
                    Name = "李四",
                    Item = "应发工资",
                    SubItem = "加班",
                    Month = "2月",
                    Money = "100"
                },
                new Salary
                {
                    Name = "李四",
                    Item = "五险一金",
                    SubItem = "医疗保险",
                    Month = "2月",
                    Money = "500"
                },
                new Salary
                {
                    Name = "李四",
                    Item = "五险一金",
                    SubItem = "住房公积金",
                    Month = "2月",
                    Money = "370"
                },
                new Salary
                {
                    Name = "",
                    Item = "",
                    SubItem = "",
                    Month = "合计",
                    Money = "3900"
                }
            };

            #endregion
        }


        public IEnumerable<Salary> GetSalaries()
        {
            return salaryList;
        }


    }
}