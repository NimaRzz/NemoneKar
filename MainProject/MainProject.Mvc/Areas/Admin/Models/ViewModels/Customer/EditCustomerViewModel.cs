namespace MainProject.Mvc.Areas.Admin.Models.ViewModels.Customer
{
    public class EditCustomerViewModel
    {
        public long CustomerId { get; set; }
        public string Address { get; set; }
        public long CityId { get; set; }
        public long ProvinceId { get; set; }
        public string Phone { get; set; }
    }
}
