﻿namespace ArvidsonFoto.Controllers;

public class RedirectRouterController : Controller
{
    [Route("/Index.html")]
    [Route("/Default.asp")]
    [Route("/Default.aspx")]
    public RedirectToActionResult RedirectToHomeIndex()
    {
        //Kommentera på/av för att aktivera/inaktivera loggning av denna redirect:
        var url = Url.ActionContext.HttpContext;
        string visitedUrl = HttpRequestExtensions.GetRawUrl(url);
        Log.Fatal($"Redirect from page: {visitedUrl} , To startpage: /");

        return RedirectToActionPermanent("Index", "Home");
    }

    [Route("/Sk")]
    [Route("/Sok")]
    [Route("/Search")]
    [Route("/Search.asp")]
    public RedirectToActionResult RedirectToBilderSök()
    {
        ////Kommentera på/av för att aktivera/inaktivera loggning av denna redirect:
        //var url = Url.ActionContext.HttpContext;
        //string visitedUrl = HttpRequestExtensions.GetRawUrl(url);
        //Log.Fatal($"Redirect from page: {visitedUrl} , To page: /Sök");

        return RedirectToActionPermanent("Sök", "Bilder");
    }

    [Route("/Latest.asp")]
    [Route("/Bild_kalender.asp")]
    [Route("/Bilder/Senast")]
    [Route("/Bilder/Senast/{sortering}")]
    [Route("/Senast")]
    [Route("/Senast/Index.html")]
    [Route("/Senast/Default.asp")]
    public RedirectToActionResult RedirectToSenast(string sortering)
    {
        ////Kommentera på/av för att aktivera/inaktivera loggning av denna redirect:
        //var url = Url.ActionContext.HttpContext;
        //string visitedUrl = HttpRequestExtensions.GetRawUrl(url);
        //Log.Fatal($"Redirect from page: {visitedUrl} , To page: /Senast/Fotograferad");

        return RedirectToActionPermanent("Index", "Senast", new { sortOrder = "Fotograferad" });
    }

    [Route("/Info.asp")]
    public RedirectToActionResult RedirectToInfoIndex()
    {
        //Kommentera på/av för att aktivera/inaktivera loggning av denna redirect:
        var url = Url.ActionContext.HttpContext;
        string visitedUrl = HttpRequestExtensions.GetRawUrl(url);
        Log.Fatal($"Redirect from page: {visitedUrl} , To page: /Info");

        return RedirectToActionPermanent("Index", "Info");
    }

    [Route("/Info/GB")]
    [Route("/Info/Gstbok")]
    [Route("/Info/Gastbok")]
    //[Route("/GB.asp")] //Tar bort denna routern för att slippa gamla spammers. 
    public RedirectToActionResult RedirectToInfoGästbok()
    {
        //Kommentera på/av för att aktivera/inaktivera loggning av denna redirect:
        var url = Url.ActionContext.HttpContext;
        string visitedUrl = HttpRequestExtensions.GetRawUrl(url);
        Log.Fatal($"Redirect from page: {visitedUrl} , To page: /Info/Gästbok");

        return RedirectToActionPermanent("Gästbok", "Info");
    }

    [Route("/Kontakta.asp")]
    [Route("/Kontakta")]
    [Route("/Info/Contact")]
    public RedirectToActionResult RedirectToInfoKontakta()
    {
        //Kommentera på/av för att aktivera/inaktivera loggning av denna redirect:
        var url = Url.ActionContext.HttpContext;
        string visitedUrl = HttpRequestExtensions.GetRawUrl(url);
        Log.Fatal($"Redirect from page: {visitedUrl} , To page: /Info/Kontakta");

        return RedirectToActionPermanent("Kontakta", "Info");
    }

    [Route("/Kop.asp")]
    [Route("/Köp_av_bilder")]
    [Route("/Info/Kp_av_bilder")]
    [Route("/Info/Kop_av_bilder")]
    public RedirectToActionResult RedirectToInfoKöp_av_bilder()
    {
        //Kommentera på/av för att aktivera/inaktivera loggning av denna redirect:
        var url = Url.ActionContext.HttpContext;
        string visitedUrl = HttpRequestExtensions.GetRawUrl(url);
        Log.Fatal($"Redirect from page: {visitedUrl} , To page: /Info/Köp_av_bilder");

        return RedirectToActionPermanent("Köp_av_bilder", "Info");
    }

    [Route("/Om.asp")]
    [Route("/Om")]
    public RedirectToActionResult RedirectToInfoOm_mig()
    {
        //Kommentera på/av för att aktivera/inaktivera loggning av denna redirect:
        var url = Url.ActionContext.HttpContext;
        string visitedUrl = HttpRequestExtensions.GetRawUrl(url);
        Log.Fatal($"Redirect from page: {visitedUrl} , To page: /Info/Om_mig");

        return RedirectToActionPermanent("Om_mig", "Info");
    }

    [Route("/Sitemap.txt")]
    [Route("/Sitemap.asp")]
    [Route("/Sidkarta")]
    public RedirectToActionResult RedirectToInfoSidkarta()
    {
        //Kommentera på/av för att aktivera/inaktivera loggning av denna redirect:
        var url = Url.ActionContext.HttpContext;
        string visitedUrl = HttpRequestExtensions.GetRawUrl(url);
        Log.Fatal($"Redirect from page: {visitedUrl} , To page: /Info/Sidkarta");

        return RedirectToActionPermanent("Sidkarta", "Info");
    }

    [Route("/Copyright.asp")]
    [Route("/Copyright")]
    public RedirectToActionResult RedirectToInfoCopyright()
    {
        //Kommentera på/av för att aktivera/inaktivera loggning av denna redirect:
        var url = Url.ActionContext.HttpContext;
        string visitedUrl = HttpRequestExtensions.GetRawUrl(url);
        Log.Fatal($"Redirect from page: {visitedUrl} , To page: /Info/Copyright");

        return RedirectToActionPermanent("Copyright", "Info");
    }
}