using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace cwiczenia10_mp_s23525.Views.HelloWorld
{
    public class Welcome : PageModel
    {
        private readonly ILogger<Welcome> _logger;

        public Welcome(ILogger<Welcome> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}