using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Application.ViewModels.Cue
{
    public class CueViewModel
    {
        public IEnumerable<Domain.Model.Cues.Cue> Cues { get; set; }
    }
}
