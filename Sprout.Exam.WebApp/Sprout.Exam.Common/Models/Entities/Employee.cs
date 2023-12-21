﻿using System;

namespace Sprout.Exam.Common.Models.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public DateTime Birthdate { get; set; }

        public string TIN { get; set; }

        public int EmployeeTypeId { get; set; }

        public EmployeeType EmployeeType { get; set; }
    }
}
