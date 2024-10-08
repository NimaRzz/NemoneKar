using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Contexts;
using MainProject.Application.Interfaces.Cues;
using MainProject.Common.Dto;
using MainProject.Domain.Model.Cues;
using MainProject.Domain.Model.Users;
using MD.PersianDateTime;

namespace MainProject.Application.Services.Cues.Commands.AddCue
{
    public class AddCueService:IAddCueService
    {
        private readonly IDataBaseContext _context;

        public AddCueService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(RequestAddCueDto request)
        {
            var customer = _context.Users.Find(request.CustomerId);
           
            
            if (customer == null)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "مشتری را وارد کنید"
                };
            }

            PersianDateTime persianDateTime = new PersianDateTime(request.Date);
            var persianDateTimeString = persianDateTime.ToString("yyyy/MM/dd");

            if (persianDateTimeString == "1/01/01") 
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "تاریخ را وارد کنید"
                };
            }


            if (string.IsNullOrWhiteSpace(request.Description))
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "توضیحات را وارد کنید"
                };
            }




          
            Cue cue = new Cue()
            {
                Description = request.Description,
                Date = request.Date,
                Customer = customer,
                ShowDate = persianDateTimeString
            };

            
            cue.InsertTime = DateTime.Now;

            _context.Cues.Add(cue);
            _context.SaveChanges();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "سرنخ با موفقیت افزوده شد"
            };

        }
    }
}
