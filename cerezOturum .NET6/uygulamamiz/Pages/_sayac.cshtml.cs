using Microsoft.AspNetCore.Mvc.RazorPages;

namespace uygulamamiz.Pages
{
    public class _sayacModel : PageModel
    {
        private readonly ISingletonHizmeti _singletonServis;

        public _sayacModel(ISingletonHizmeti singletonService1)
        {
            _singletonServis = singletonService1;
        }

        public string? sonuc { get; set; }

        public void OnGet()
        {
            sonuc = _singletonServis.sayacOku() + " / " + DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
