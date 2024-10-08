using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Common.Dto;

namespace MainProject.Application.Interfaces.Cues
{
    public interface IDeleteCueService
    {
        ResultDto Execute(long CueId);
    }
}
