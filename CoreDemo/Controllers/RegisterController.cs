using BCrypt.Net;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        [AllowAnonymous]
        [HttpGet]        
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Index(Writer p, string passwordAgain)
        {
            WriterValidator validator = new WriterValidator();
            ValidationResult results = validator.Validate(p);
            if (results.IsValid)
            {
                if (p.WriterPassword == passwordAgain)
                {
					p.WriterStatus = true;
					p.WriterAbout = "yazar about kısmı";
					//p.WriterPassword = BCrypt.Net.BCrypt.HashPassword(p.WriterPassword);
					wm.WriterAdd(p);
					return RedirectToAction("Index", "Blog");
                }
                else
                {
					ModelState.AddModelError("WriterPassword", "Girdiğiniz şifreler eşleşmedi.Tekrar deneyin...");
				}
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
    }
}
