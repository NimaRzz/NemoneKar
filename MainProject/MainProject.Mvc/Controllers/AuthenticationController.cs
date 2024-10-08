using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MainProject.Application.Interfaces.FacadPatterns;
using MainProject.Application.Services.Users.Commands.Login;
using MainProject.Application.Services.Users.Commands.Register;
using MainProject.Common.Dto;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using MainProject.Mvc.Models.ViewModels.AuthenticationViewModel;


namespace MainProject.Mvc.Controllers
{
    public class AuthenticationController : Controller
    {

        private readonly IUserFacad _userFacad;

        public AuthenticationController(IUserFacad userFacad)
        {
            _userFacad = userFacad;
        }

        [HttpGet]
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel request)
        {
            if (string.IsNullOrWhiteSpace(request.Email) ||
                string.IsNullOrWhiteSpace(request.Password) ||
                string.IsNullOrWhiteSpace(request.RePassword) ||
                string.IsNullOrWhiteSpace(request.UserName)
               )
            {
                return Json(new ResultDto() { IsSuccess = false, Message = "لطفا تمامی موارد را ارسال نمایید" }
                );
            }

            if (User.Identity.IsAuthenticated == true)
            {
                return Json(new ResultDto() { IsSuccess = false, Message = "شما به حساب کاربری خود وارد شده اید" });
            }

            if (request.Password != request.RePassword)
            {
                return Json(new ResultDto() { IsSuccess = false, Message = "رمز عبور و تکرار آن برابر نیست" });
            }

            if (request.Password.Length < 8)
            {
                return Json(new ResultDto() { IsSuccess = false, Message = "رمز عبور باید بیشتر از 8 کاراکتر باشد" });
            }

            string emailRegex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[A-Z0-9.-]+\.[A-Z]{2,}$";
            var match = Regex.Match(request.Email, emailRegex, RegexOptions.IgnoreCase);


            if (!match.Success)
            {
                return Json(new ResultDto() { IsSuccess = false, Message = "ایمیل خود را به درستی وارد نمایید" });
            }

            var registerResult = _userFacad.UserRegisterService.Execute(new RequestRegisterUserDto()
            {
                Email = request.Email,
                Password = request.Password,
                RePassword = request.RePassword,
                UserName = request.UserName,
                roles = new List<RolesInRegisterUserDto>()
                {
                    new RolesInRegisterUserDto {Id = 3}
                }
            });

            if (registerResult.IsSuccess == true)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, registerResult.Data.UserId.ToString()),
                    new Claim(ClaimTypes.Email, request.Email),
                    new Claim(ClaimTypes.Name, request.UserName),
                    new Claim(ClaimTypes.Role, "Customer")

                };


                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var properties = new AuthenticationProperties()
                {
                    IsPersistent = true
                };
                HttpContext.SignInAsync(principal, properties);

            }

            return Json(registerResult);


        }


        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel request)
        {

            var loginResult = _userFacad.UserLoginService.Execute(new RequestLoginUserDto()
            {
                Email = request.Email,
                Password = request.Password
            });

            if (loginResult.IsSuccess == true)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, loginResult.Data.UserId.ToString()),
                    new Claim(ClaimTypes.Email, request.Email),
                    new Claim(ClaimTypes.Name, loginResult.Data.UserName)
                };

                foreach (var item in loginResult.Data.Roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, item));
                }

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var properties = new AuthenticationProperties()
                {
                IsPersistent = true,
                ExpiresUtc = DateTime.Now.AddDays(7)
                };

                HttpContext.SignInAsync(principal, properties);

            }

            return Json(loginResult);

        }

        public async Task<IActionResult> Logout()
        {
            

           await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
