using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Domain.Model.Users;

namespace MainProject.Application.Services.Cues.Commands.EditCue
{
    public class RequestEditCueDto
    {
        public string Description { get; set; }

        public long CueId { get; set; }

        public User Customer { get; set; } 

        public string Date { get; set; }
    }
}
