using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Contexts;
using MainProject.Application.Interfaces.Cues;
using MainProject.Common.Dto;
using MD.PersianDateTime;

namespace MainProject.Application.Services.Cues.Commands.DeleteCue
{
    public class DeleteCueService:IDeleteCueService
    {

        private readonly IDataBaseContext _context;

        public DeleteCueService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(long CueId)
        {

            var cue = _context.Cues.Find(CueId);

            if (cue == null)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "سرنخ یافت نشد"
                };
            }

            cue.IsRemoved = true;

            cue.RemoveTime = DateTime.Now;
            _context.SaveChanges();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "سرنخ حذف شد"
            };
        }
    }
}
