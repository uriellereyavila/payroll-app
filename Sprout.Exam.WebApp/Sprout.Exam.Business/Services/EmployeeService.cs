using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprout.Exam.Business.Interface;

namespace Sprout.Exam.Business.Services
{
    public abstract class EmployeeService : IEmployeeService
    {
        public abstract Task<decimal> CalculateSalary();
    }
}
