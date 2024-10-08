using System;
using MainProject.Application.Interfaces.FacadPatterns;
using MainProject.Application.Interfaces.Users;
using MainProject.Application.Services.Customers.Commands.AddCustomer;
using MainProject.Application.Services.Customers.Commands.DeleteCustomer;
using MainProject.Application.Services.Customers.Commands.EditCustomer;
using MainProject.Application.Services.Customers.Queries.GetCustomersForAdmin;
using MainProject.Mvc.Areas.Admin.Models.ViewModels.Cue;
using MainProject.Mvc.Areas.Admin.Models.ViewModels.Customer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MainProject.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize("AdminOrOperator")]
    public class CustomersController : Controller
    {
        private readonly ICustomerFacad _customerFacad;
        private readonly IUserFacad _userFacad;

        public CustomersController(ICustomerFacad customerFacad, IUserFacad userFacad)
        {
            _customerFacad = customerFacad;
            _userFacad = userFacad;
        }

        public IActionResult Index(int Page)
        {
            var customersList = _customerFacad.GetCustomersForAdminService.Execute(Page);

            return View(customersList);
        }


        [HttpGet]
        public IActionResult Add(Ordering ordering, string SearchKey, int Page = 1, int pageSize = 20)
        {
            ViewBag.Users = new SelectList(_userFacad.GetUsersForAdminService.Execute(ordering, SearchKey, Page, pageSize).Users,
                "UserId", "UserName");

            return View();
        }

        [HttpPost]
        [Route("/admin/customers/Add")]
        public IActionResult Add(AddCustomerViewModel request)
        {
            var cueAddResult = _customerFacad.AddCustomerService.Execute(new RequestAddCustomerDto()
            {
                UserId = request.UserId,
                Address = request.Address,
                ProvinceId = request.ProvinceId,
                CityId = request.CityId,
                Phone = request.Phone
            });

            return Json(cueAddResult);
        }



        [HttpPost]
        [Route("/admin/customers/Delete")]
        public IActionResult Delete(long CustomerId)
        {
            var customerDeleteResult = _customerFacad.DeleteCustomerService.Execute(CustomerId);
           

            return Json(customerDeleteResult);
        }


        [HttpPost]
        [Route("/admin/customers/Edit")]
        public IActionResult Edit(EditCustomerViewModel request)
        {
            var customerEditResult = _customerFacad.EditCustomerService.Execute(new RequestEditCustomerDto()
            {
                CustomerId = request.CustomerId,
                Address = request.Address,
                ProvinceId = request.ProvinceId,
                CityId = request.CityId,
                Phone = request.Phone

            });


            return Json(customerEditResult);
        }
    }
}
