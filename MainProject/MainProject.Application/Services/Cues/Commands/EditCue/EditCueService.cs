using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Contexts;
using MainProject.Application.Interfaces.Cues;
using MainProject.Common.Dto;
using MD.PersianDateTime;

namespace MainProject.Application.Services.Cues.Commands.EditCue
{
    public class EditCueService:IEditCueService
    {

        private readonly IDataBaseContext _context;

        public EditCueService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(RequestEditCueDto request)
        {

            var cue = _context.Cues.Find(request.CueId);

            if (cue == null)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "سرنخ یافت نشد"
                };
            }

            cue.Description = request.Description;
            cue.Customer = request.Customer;

            var persianDateTime = PersianDateTime.Now;

            cue.ShowDate = persianDateTime.ToString("yyyy/MM/dd");
            cue.UpdateTime = DateTime.Now;

            _context.SaveChanges();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "سرنخ ویرایش شد"
            };
        }
    }
}
