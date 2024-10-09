namespace MainProject.Mvc.Models.ViewModels.AuthenticationViewModel
{
    public class LoginViewModel
    {
        public string Email { get; set; }
       
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
