using System;

namespace MainProject.Mvc.Areas.Admin.Models.ViewModels.Cue
{
    public class AddCueViewModel
    {
        public long CustomerId { get; set; }
        
        public DateTime Date { get; set; }

        public string Description { get; set; }
    }
}
