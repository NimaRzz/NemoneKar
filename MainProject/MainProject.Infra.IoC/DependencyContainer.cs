using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Contexts;
using MainProject.Application.Interfaces.FacadPatterns;
using MainProject.Application.Interfaces.UserServices;
using MainProject.Application.Services.Customers.FacadPattern;
using MainProject.Application.Services.Users.FacadPattern;
using MainProject.Infra.Data.Contexts;


namespace MainProject.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
         
            //Application Layer
            service.AddScoped<IUserFacad, UserFacad>();
            service.AddScoped<ICustomerFacad, CustomerFacad>();


            //Infra Data Layer
            service.AddScoped<IDataBaseContext, DataBaseContext>();

        } 
    }
}
