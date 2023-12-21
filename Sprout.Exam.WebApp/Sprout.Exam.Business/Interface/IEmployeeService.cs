using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.Exam.Business.Interface
{
    public interface IEmployeeService
    {
        Task<decimal> CalculateSalary();
    }
}
