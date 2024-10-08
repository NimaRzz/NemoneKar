using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.Cues;

namespace MainProject.Application.Interfaces.FacadPatterns
{
    public interface ICueFacad
    {
        IGetCuesForAdminService GetCuesForAdminService { get; }


        IAddCueService AddCueService { get; }

      
        IEditCueService EditCueService { get; }
       
       
        IDeleteCueService DeleteCueService { get; }
       
        //IGetFilterCuesForAdminService GetFilterCuesForAdminService { get; }
        
    }
}
