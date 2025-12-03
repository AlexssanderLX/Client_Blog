using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using ClientBlog.Models;

public class ContactController : Controller
{
    public IActionResult Contact()
    {
        var contact = new ClientBlog.Models.Contact
        {
            CellNumber = "+5511989275868",
            Instagram = "https://www.instagram.com/lexis_lx1/",
            Linkedin = "https://www.linkedin.com/in/alexssander-ferreira-de-almeida-4a3841284/",
            Email = "alexssander.f.almeida2006@email.com"
        };
        return View(contact);
    }
}

