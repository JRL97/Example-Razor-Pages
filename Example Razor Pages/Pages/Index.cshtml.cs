using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Example_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Fullname { get; set; }

        [BindProperty]
        public string Email { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Fullname = "Jessica Leach";
        }

        public void OnPost ()
        {

        }
    }
}