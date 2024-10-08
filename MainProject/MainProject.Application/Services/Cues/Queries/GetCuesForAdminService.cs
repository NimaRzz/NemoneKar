using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Cues;
using MainProject.Application.ViewModels.Cue;
using MainProject.Domain.Interfaces.Cues;
using MainProject.Domain.Model.Cues;

namespace MainProject.Application.Services.Cues.Queries
{
    public class GetCuesForAdminService:IGetCuesForAdminService
    {
        
        private readonly ICuesRepository _cuesRepository;

        public GetCuesForAdminService(ICuesRepository cuesRepository)
        {
            _cuesRepository = cuesRepository;
        }

        public CueViewModel GetCues()
        {
            return new CueViewModel
            {
                Cues = _cuesRepository.GetCues()
            };
        }
    }
}
