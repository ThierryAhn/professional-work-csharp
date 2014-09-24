using KSAEvenementiel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;

namespace KSAEvenementiel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Bienvenue dans ASP.NET MVC !";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View(new EditableContact());
        }

        [HttpPost]
        public ActionResult Contact(EditableContact editableContact)
        {
            string name = editableContact.Name;
            string email = editableContact.Email;
            string objecT = editableContact.ObjecT;
            string message = editableContact.Message;

            string to = "folabi41@gmail.com";

            string contenu = "Message de " + name + ", email : " + email + "\n" + "Contenu : " + message;

            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            mail.From = new MailAddress(email);
            mail.Subject = objecT;
            mail.Body = message;

            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            
            smtp.Credentials = new System.Net.NetworkCredential("folabi41", "la vie est belle");// Enter seders User name and password
            
            
            smtp.EnableSsl = true;
            smtp.Send(mail);

            
            return RedirectToAction("Contact");
        }
    }
}
