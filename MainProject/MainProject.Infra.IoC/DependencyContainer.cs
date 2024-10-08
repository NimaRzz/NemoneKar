using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Contexts;
using MainProject.Application.Interfaces.Cues;
using MainProject.Application.Interfaces.FacadPatterns;
using MainProject.Application.Interfaces.UserServices;
using MainProject.Application.Services.Cues.FacadPattern;
using MainProject.Application.Services.Cues.Queries;
using MainProject.Application.Services.Customers.FacadPattern;
using MainProject.Application.Services.Users.FacadPattern;
using MainProject.Domain.Interfaces.Cues;
using MainProject.Infra.Data.Contexts;
using MainProject.Infra.Data.Repository.Cues;


namespace MainProject.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
         
            //Application Layer
            service.AddScoped<IUserFacad, UserFacad>();
            service.AddScoped<ICustomerFacad, CustomerFacad>();
            service.AddScoped<ICueFacad, CueFacad>();


            //Infra Data Layer
            service.AddScoped<IDataBaseContext, DataBaseContext>();
            service.AddScoped<ICuesRepository, CuesRepository>();


        } 
    }
}
