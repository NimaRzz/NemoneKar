using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Services.Cues.Commands.AddCue;
using MainProject.Common.Dto;

namespace MainProject.Application.Interfaces.Cues
{
    public interface IAddCueService
    {
        ResultDto Execute(RequestAddCueDto request);
    }
}
