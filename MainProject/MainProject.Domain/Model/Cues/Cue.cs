using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainProject.Domain.Model.Commons;
using MainProject.Domain.Model.Users;

namespace MainProject.Domain.Model.Cues
{
    public class Cue:BaseModel
    {
        public virtual User Customer { get; set; }
        public virtual long UserId { get; set; }

        public string Description { get; set; }

        public string ShowDate { get; set; }

        public DateTime Date { get; set; }
    }
}
