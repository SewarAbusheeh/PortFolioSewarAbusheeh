using Microsoft.AspNetCore.Mvc;
using PortFolioSewar.Data;
using PortFolioSewar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PortFolioSewar.Controllers
{
    public class ContactController : Controller
    {

        private AppDbContext db;

        public ContactController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            //if (ModelState.IsValid)
            //{
            //    Contact


            //}
            db.Contacts.Add(contact);
            db.SaveChanges();
            return View();
        }
        //[HttpGet]
        //public IActionResult send()
        //{
        //    return View();
        //}
        public IActionResult send(Contact contact)
        {
            if (ModelState.IsValid)
            {
                // obj mail 
                // كلاس يمثل رساله
                var mail = new MailMessage();
                //  معطيات تسجيل الدخول بغرض ارسال الرسائل من خلاله يت تحويل الرسائل  
                // نتورك كردنشل ينتظر الايميل والباسورد
                //   الايميل الذي سوف نرسل من خلاله اللي رح اقوم بالارسال من خلاله 
                var Loginfo = new NetworkCredential( );


                // مين هو المرسل 
                mail.From = new MailAddress(contact.Email);
                // الوجهه 
                mail.To.Add(new MailAddress("sewarabusheeh@gmail.com"));

                mail.Subject = contact.Subject;
                mail.IsBodyHtml = true;
                string body = "Name :" + contact.CName + "<br>" +
                              "Email: <br> <b> " + contact.Email + "<br>" +
                                "Subject:" + contact.Subject + "<br>" +
                                 "Message: <b>" + contact.Message + "<br>";
                mail.Body = body;
                //  smtpClient بدي ارسل ايميل ب دوت نت عن طريق   واحدد الهوست 
                //the port of gmail is 587
                var smtpClient = new SmtpClient("smtp.gmail.com", 587);
                // الجميل يسمح بالوضع الامن   ؟؟ البيانات محميه عند تحويل  من البراوسر الى سيرفر
                // smtp deal with ssl
                smtpClient.EnableSsl = true;
                //معطيات الارسال 

                smtpClient.Credentials = Loginfo;
                smtpClient.Send(mail);
                db.Contacts.Add(contact);
                db.SaveChanges();
                //  return RedirectToAction("Index","Home", "<script> alert('SENT')</script>");
                ViewBag.succ = "Success";
                return View("Index");

            }

            ViewBag.err = "Fill The Info";
            //return Content("<script> alert('Not SENT')</script>");
            return View("Index");




        }
    }
}
