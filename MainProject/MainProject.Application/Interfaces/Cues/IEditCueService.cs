using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Services.Cues.Commands.EditCue;
using MainProject.Common.Dto;

namespace MainProject.Application.Interfaces.Cues
{
    public interface IEditCueService
    {
        ResultDto Execute(RequestEditCueDto request);
    }
}
