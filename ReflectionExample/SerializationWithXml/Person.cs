﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationWithXml
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public List<Department> MyDepartmentList { get; set; }
        public List<int> Marks { get; set; }
        public string[] MyArray { get; set; }
    }
    public class Department
    {
        public int DeptId { get; set; }
        public string DepartmentName { get; set; }
    }
}
