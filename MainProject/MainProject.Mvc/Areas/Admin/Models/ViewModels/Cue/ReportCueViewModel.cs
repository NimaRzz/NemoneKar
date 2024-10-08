using System;

namespace MainProject.Mvc.Areas.Admin.Models.ViewModels.Cue
{
    public class ReportCueViewModel
    {

        public DateTime From { get; set; }

        public Domain.Model.Users.User Customer { get; set; }
        public DateTime To { get; set; }
        public int Page { get; set; }

    }
}
