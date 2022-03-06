using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace cerezOturum.Pages.Shared
{
    public class _sayacModel : PageModel
    {
        private readonly ISingletonHizmeti _singletonService1;

        public _sayacModel(ISingletonHizmeti singletonService1)
        {
            _singletonService1 = singletonService1;
        }

        public string sonuc { get; set; }

        public void OnGet()
        {
            sonuc = _singletonService1.sayacOku() + " / " + DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
