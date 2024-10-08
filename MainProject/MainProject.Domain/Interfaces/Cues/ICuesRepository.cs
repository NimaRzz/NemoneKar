using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Domain.Model.Cues;

namespace MainProject.Domain.Interfaces.Cues
{
    public interface ICuesRepository
    {
        IEnumerable<Cue> GetCues();
            
    }
}
