using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Sprout.Exam.DataAccess.Interface;
using Sprout.Exam.DataAccess.Repository;

namespace Sprout.Exam.DataAccess.Extension
{
    public static class DependencyResolver
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
