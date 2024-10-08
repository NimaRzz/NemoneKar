using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.ViewModels.Cue;

namespace MainProject.Application.Interfaces.Cues
{
    public interface IGetCuesForAdminService
    {
        CueViewModel GetCuesl();
    }
}
