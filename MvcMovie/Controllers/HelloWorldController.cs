using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
     public IActionResult Welcome(string name, int numTimes = 1)
       {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;
            return View();
       }
        //public string Index()
        //{
          //  return " This is my fault action...";
        //
        //}

        //GET /HelloWorld/Welcome
        //Requirea using system.Text.Encoding.Web
       // public string Welcome(string name, int ID = 1)
       // {
           // return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
       // }
        
    }
}
