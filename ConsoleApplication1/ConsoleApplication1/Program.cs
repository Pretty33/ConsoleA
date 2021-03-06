﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用数据上下文进行数据操作，using表示上下文代码的范围，执行完后内存会自动释放
            using (var context = new CourseContext())
            {
                //.where .orderby .tolist() 注意调用的顺序
                var departments = context.Departments.Where(n => n.Name.Contains("工程")).OrderBy(n => n.SortCode).ToList();
                foreach (var d in departments)
                    Console.WriteLine("编号{0},部门名称{1},说明{2}", d.SortCode, d.Name, d.Dsen);
                Console.ReadKey();
            }
        }
    }
}
