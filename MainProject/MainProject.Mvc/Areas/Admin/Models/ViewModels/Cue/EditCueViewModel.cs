using System;

namespace MainProject.Mvc.Areas.Admin.Models.ViewModels.Cue
{
    public class EditCueViewModel
    {
        public Domain.Model.Users.User Customer { get; set; }

        public long CueId { get; set; }

        public string Date { get; set; }

        public string Description { get; set; }
    }
}
