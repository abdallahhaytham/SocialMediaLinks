using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace SocialMediaLinks.Controllers
{
    public class HomeController : Controller
    {
        private readonly SocialMediaLinksOptions _socialMediaLinksOptions;
    private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(IOptions<SocialMediaLinksOptions> options,IWebHostEnvironment webHostEnvironment) 
        {

            _socialMediaLinksOptions = options.Value;



            _webHostEnvironment = webHostEnvironment;
        }



        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.EnvironmentName = _webHostEnvironment.EnvironmentName;

            SocialMediaLinksOptions socialMediaLinksOptions = new SocialMediaLinksOptions()
            {


               Facebook = _socialMediaLinksOptions.Facebook,
                Twitter = _socialMediaLinksOptions.Twitter,

                Youtube = _socialMediaLinksOptions.Youtube,

                Instagram = _socialMediaLinksOptions.Instagram


            };

            ViewBag.SocialMediaLinks = socialMediaLinksOptions;
            return View();
        }
    }
}
