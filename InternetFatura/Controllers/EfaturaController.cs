using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;


namespace InternetFatura.Controllers
{
    public class EfaturaController : Controller
    {
        // GET: Efatura
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kampanyalar()
        {
            return View();
        }
        public ActionResult Destek()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
        public ActionResult KVKK()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult Blog2()
        {
            return View();
        }
        public ActionResult Blog3()
        {
            return View();
        }

        public ActionResult EFaturaya_Gecis_Zorunlulugu()
        {
            return View();
        }
        public ActionResult EFatura_Nedir()
        {
            return View();
        }
        public ActionResult Ücretsiz_EFatura_Nasil_Kullanilir()
        {
            return View();
        }
        public ActionResult Ön_Muhasebe_Nedir()
        {
            return View();
        }
        public ActionResult E_Arsiv_Fatura_Nedir()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Index(Models.Email model, HttpPostedFileBase myFiles)
        {
            MailMessage mailim = new MailMessage();
            mailim.To.Add("bilgi@sanalfatura.com");
            mailim.From = new MailAddress("bilgi@sanalfatura.com");
            mailim.Subject = "Bize Ulaşın Sayfasından Mesajınız Var. ";
            mailim.Body = "Ad Soyad: " + model.Ad + " <br>Mail adresi: " + model.Mail + "<br>Telefon Numarası:" + model.Telefon + "<br>Konu: " + model.Konu + "<br>Mesaj:" + model.Mesaj;
            mailim.IsBodyHtml = true;

            if (myFiles != null)
            {
                mailim.Attachments.Add(new Attachment(myFiles.InputStream, myFiles.FileName));
            }

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("bilgi@sanalfatura.com", "5487mdjk*");
            smtp.Port = 587;
            smtp.Host = "smtp.sanalfatura.com";
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(mailim);

                TempData["Message"] = "Mesajınız iletilmiştir. En kısa zamanda size geri dönüş sağlanacaktır.";
            }
            catch (Exception ex)
            {
                TempData["Message"] = "Mesaj gönderilemedi.Hata nedeni:" + ex.Message;
            }


            return Json("asdasd");
        }
    }
}

    

