using MainProject.Application.Interfaces.FacadPatterns;
using MainProject.Application.Services.Cues.Commands.AddCue;
using MainProject.Application.Services.Cues.Commands.EditCue;
using MainProject.Application.Services.Customers.Queries.GetCustomersForAdmin;
using MainProject.Application.ViewModels.Cue;
using MainProject.Mvc.Areas.Admin.Models.ViewModels.Cue;
using MainProject.Mvc.Areas.Admin.Models.ViewModels.Customer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Query;

namespace MainProject.Mvc.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class CuesController : Controller
    {
        private readonly ICueFacad _cueFacad;

        private readonly ICustomerFacad _customerFacad;

        public CuesController(ICueFacad cueFacad, ICustomerFacad customerFacad)
        {
            _cueFacad = cueFacad;
            _customerFacad = customerFacad;
        }

        [HttpGet]
        public IActionResult Index(int Page=1)
        {
            //var cuesList = _cueFacad.GetCuesForAdminService.Execute(Page);


            ViewBag.Customers = new SelectList(_customerFacad.GetCustomersForAdminService.Execute(Page).Customers, "CustomerId", "UserName");

            CueViewModel model = _cueFacad.GetCuesForAdminService.GetCues();


            return View(model);
        }

        [HttpGet]
        public IActionResult Add(int Page)
        {
            ViewBag.Customers = new SelectList(_customerFacad.GetCustomersForAdminService.Execute(Page).Customers,
                "CustomerId", "UserName");
            return View();
        }

        [HttpPost]
        [Route("/admin/cues/Add")]
        public IActionResult Add(AddCueViewModel request)
        {
            var cueAddResult = _cueFacad.AddCueService.Execute(new RequestAddCueDto()
            {
                CustomerId = request.CustomerId,
                Date = request.Date,
                Description = request.Description
            });

            return Json(cueAddResult);
        }

        [HttpPost]
        [Route("/admin/cues/Edit")]
        public IActionResult Edit(EditCueViewModel request)
        {

            var cueEditResult = _cueFacad.EditCueService.Execute(new RequestEditCueDto()
            {
                Date = request.Date,
                Description = request.Description,
                CueId = request.CueId,
                Customer = request.Customer
            });

            return Json(cueEditResult);
        }

        [HttpPost]
        [Route("/admin/cues/Delete")]
        public IActionResult Delete(long CueId)
        {

            var cueDeleteResult = _cueFacad.DeleteCueService.Execute(CueId);

            return Json(cueDeleteResult);
        }

        //public IActionResult FilterCues(int Page)
        //{
        //    var cuesList = _cueFacad.GetCuesForAdminService.Execute(Page);
        //    ViewBag.Customers = new SelectList(_customerFacad.GetCustomersForAdminService.Execute(Page).Customers, "CustomerId", "UserName");
        //    return View(cuesList);
        //}

        //[HttpPost]
        //[Route("/admin/cues/FilterCues")]
        //public IActionResult FilterCues(ReportCueViewModel request)
        //{

        //    var cuesFilterList = _cueFacad.GetFilterCuesForAdminService.Execute(new RequestGetFilterCuesDto()
        //    {
        //        From = request.From,
        //        To = request.To,
        //        Customer = request.Customer,
        //        Page = request.Page
        //    });

        //    return Json(cuesFilterList);
        //}

    }
}