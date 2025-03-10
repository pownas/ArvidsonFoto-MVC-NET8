﻿using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
namespace ArvidsonFoto.Controllers;

public class InfoController(ArvidsonFotoDbContext context) : Controller
{
    internal ICategoryService _categoryService = new CategoryService(context);
    internal IImageService _imageService = new ImageService(context);
    internal IGuestBookService _guestbookService = new GuestBookService(context);
    internal IPageCounterService _pageCounterService = new PageCounterService(context);

    public IActionResult Index()
    {
        ViewData["Title"] = "Info";
        if (User?.Identity?.IsAuthenticated is false)
            _pageCounterService.AddPageCount("Info");
        return View();
    }

    public IActionResult Gästbok(GuestbookInputModel inputModel)
    {
        ViewData["Title"] = "Gästbok";
        if (User?.Identity?.IsAuthenticated is false)
            _pageCounterService.AddPageCount("Gästbok");

        if (inputModel.FormSubmitDate < new DateTime(2000, 01, 01) && inputModel.Message is null)
        {
            inputModel = new GuestbookInputModel()
            {
                FormSubmitDate = DateTime.Now,
                DisplayPublished = false,
                DisplayErrorPublish = false
            };
        }

        return View(inputModel);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult PostToGb([Bind("Code,Name,Email,Homepage,Message,FormSubmitDate")] GuestbookInputModel inputModel)
    {
        Log.Information("A user trying to post to the Guestbook...");
        if (ModelState.IsValid)
        {
            inputModel.DisplayErrorPublish = false;
            try
            {
                string homePage = "";
                if (inputModel.Homepage is not null)
                {
                    homePage = inputModel.Homepage.Replace("https://", "");
                    homePage = homePage.Replace("http://", "");
                    string[] splittedHome = homePage.Split("/");
                    if (splittedHome is not null)
                    {
                        homePage = splittedHome[0];
                        if (splittedHome.Length > 1) { homePage += "/" + splittedHome[1]; }
                        if (splittedHome.Length > 2) { homePage += "/" + splittedHome[2]; }
                    }
                }

                TblGb postToPublish = new TblGb()
                {
                    GbId = (_guestbookService.GetLastGbId() + 1),
                    GbName = inputModel.Name,
                    GbEmail = inputModel.Email,
                    GbHomepage = homePage,
                    GbText = inputModel.Message,
                    GbDate = DateTime.Now
                };
                Log.Fatal("User GuestBook-post: " + postToPublish.GbId + " Name: " + postToPublish.GbName + " Email: " + postToPublish.GbEmail + " Homepage:" + postToPublish.GbHomepage);
                Log.Fatal("GB-Message: \n" + postToPublish.GbText);

                if (_guestbookService.CreateGBpost(postToPublish))
                {
                    Log.Information("GB-post, published OK.");
                    inputModel = new GuestbookInputModel();
                    inputModel.DisplayPublished = true;
                }
            }
            catch (Exception e)
            {
                inputModel.DisplayErrorPublish = true;
                inputModel.DisplayPublished = false;
                Log.Error("Error publishing the GB-post. Error-message: " + e.Message);
            }
        }
        else
        {
            //SKRIVS INTE UT???
            Log.Fatal($"Name: '{inputModel.Name}' Email: '{inputModel.Email}' Homepage: '{inputModel.Homepage}'"); //SKRIVS INTE UT???
            Log.Fatal($"GB-Message:\n {inputModel.Message}"); //SKRIVS INTE UT???
            Log.Warning($"Failed to send GB-post... Probably an incorrect Code-input: '{inputModel.Code}'."); //SKRIVS INTE UT???
            inputModel.DisplayPublished = false;
        }
        return RedirectToAction("Gästbok", inputModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult SendMessage([Bind("Code,Email,Name,Subject,Message")] ContactFormModel contactFormModel, string Page)
    {
        if (ModelState.IsValid)
        {
            contactFormModel.DisplayErrorSending = false;

            try
            {
                //Github-secrets, samt miljö variablar som krävs (Se dokumentation i OneDrive -> ArvidsonFoto -> Miljö-variabler) :
                var svc_mailServer = Environment.GetEnvironmentVariable("ARVIDSONFOTO_MAILSERVER");
                var svc_smtpadress = Environment.GetEnvironmentVariable("ARVIDSONFOTO_SMTPADRESS");
                var svc_smtppwd = Environment.GetEnvironmentVariable("ARVIDSONFOTO_SMTPPWD");

                Log.Information("User trying to send e-mail...");
                var fromName = Page + "-ArvidsonFoto.se";
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(contactFormModel.Name, contactFormModel.Email));
                //message.To.Add(new MailboxAddress(fromName, "torbjorn_arvidson@hotmail.com"));
                message.To.Add(new MailboxAddress(fromName, svc_smtpadress));
                message.Bcc.Add(new MailboxAddress(fromName, "jonas@arvidsonfoto.se"));
                message.Subject = "Arvidsonfoto.se/" + Page + " - " + contactFormModel.Subject;

                message.Body = new TextPart("plain")
                {
                    Text = contactFormModel.Message
                };

                Log.Information("User message: " + message);

                using (var client = new SmtpClient())
                {
                    client.Connect(svc_mailServer, 587, SecureSocketOptions.StartTls); //Kräver @using MailKit.Security;
                    //client.Connect(svc_mailServer, 465, true); //Alternativ anslutning, mindre säker...
                    //client.Connect(svc_mailServer, 587, false); //Alternativ anslutning, mindre säker...

                    // Note: only needed if the SMTP server requires authentication
                    client.Authenticate(svc_smtpadress, svc_smtppwd);
                    client.Send(message);
                    client.Disconnect(true);
                    Log.Information("Email, sent OK.");
                }

                contactFormModel = new ContactFormModel()
                {
                    DisplayEmailSent = true,
                    FormSubmitDate = DateTime.Now
                };
            }
            catch (Exception e)
            {
                contactFormModel.DisplayErrorSending = true;
                contactFormModel.DisplayEmailSent = false;
                Log.Error("Error sending email. Error-message: " + e.Message);
            }
        }
        else
        {
            contactFormModel.DisplayEmailSent = false;
        }

        if (Page.Equals("Kontakta"))
        {
            return RedirectToAction("Kontakta", contactFormModel);
        }
        else if (Page.Equals("Köp_av_bilder"))
        {
            return RedirectToAction("Köp_av_bilder", contactFormModel);
        }
        else
        {
            return RedirectToAction("Kontakta");
        }
    }

    public IActionResult Kontakta(ContactFormModel contactFormModel)
    {
        ViewData["Title"] = "Kontaktinformation";
        if (User?.Identity?.IsAuthenticated is false)
            _pageCounterService.AddPageCount("Kontaktinformation");

        if (contactFormModel.FormSubmitDate < new DateTime(2000, 01, 01) && contactFormModel.Message is null)
        {
            contactFormModel = new ContactFormModel()
            {
                FormSubmitDate = DateTime.Now,
                MessagePlaceholder = "Meddelande \n (Skriv gärna vad ni önskar kontakt om)", // \n = newLine
                DisplayEmailSent = false,
                DisplayErrorSending = false,
                ReturnPageUrl = "Kontakta"
            };
        }

        return View(contactFormModel);
    }

    public IActionResult Köp_av_bilder(ContactFormModel contactFormModel, string imgId)
    {
        ViewData["Title"] = "Köp av bilder";
        if (User?.Identity?.IsAuthenticated is false)
            _pageCounterService.AddPageCount("Köp av bilder");
        if (contactFormModel.FormSubmitDate < new DateTime(2000, 01, 01) && contactFormModel.Message is null)
        {
            contactFormModel = new ContactFormModel()
            {
                FormSubmitDate = DateTime.Now,
                MessagePlaceholder = "Meddelande \n (Skriv gärna bildnamn på de bilderna ni är intresserade av)", // \n = newLine
                DisplayEmailSent = false,
                DisplayErrorSending = false,
                ReturnPageUrl = "Köp_av_bilder"
            };

            if (imgId is not null)
            {
                try
                {
                    var image = _imageService.GetById(Convert.ToInt32(imgId));
                    var imageArt = _categoryService.GetNameById(image.ImageArt);

                    contactFormModel.Message = "Hej!\nJag är intresserad av att köpa en bild på: " + imageArt + "\n som har bildnamnet: " + image.ImageUrl + ".jpg";
                }
                catch (Exception)
                {

                }
            }
        }

        return View(contactFormModel);
    }

    public IActionResult Om_mig()
    {
        ViewData["Title"] = "Om mig, Torbjörn Arvidson";
        if (User?.Identity?.IsAuthenticated is false)
            _pageCounterService.AddPageCount("Om mig");
        return View();
    }

    public IActionResult Sidkarta()
    {
        ViewData["Title"] = "Sidkarta";
        if (User?.Identity?.IsAuthenticated is false)
            _pageCounterService.AddPageCount("Sidkarta");
        return View();
    }

    public IActionResult Copyright()
    {
        ViewData["Title"] = "Copyright";
        if (User?.Identity?.IsAuthenticated is false)
            _pageCounterService.AddPageCount("Copyright");
        return View();
    }
}