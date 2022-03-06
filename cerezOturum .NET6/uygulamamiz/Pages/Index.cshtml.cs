using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace uygulamamiz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly ISingletonHizmeti _singletonServisi;

        public IndexModel(ILogger<IndexModel> logger, ISingletonHizmeti singletonServis)
        {
            _logger = logger;
            _singletonServisi = singletonServis;
            _singletonServisi.sayfaYenilendi();
        }

        public string cerez { get; set; } = "form Çerez Değeri";
        public string oturum { get; set; } = "form Oturum Değeri";
        public string? durum { get; set; }

        public void OnGet()
        {
            durum = "Hoş geldiniz...";
        }

        public void OnPost(string? handler = null)
        {
            switch (handler)
            {
                case "oturumYolla":
                    if (Request.Form["oturum"] != "")
                    {
                        HttpContext.Session.SetString("oturum", Request.Form["oturum"].ToString());
                        oturum = Request.Form["oturum"];
                        durum = "Oturum eklendi...";
                    }
                    else
                        durum = "Oturumda boş veri yollandı, oturum oluşmadı...";
                    break;

                case "cerezYolla":
                    if (Request.Form["cerez"] != "")
                    {
                        int bayatlayacakDakika = 10;
                        CookieOptions option = new CookieOptions();
                        option.Expires = DateTime.Now.AddMinutes(bayatlayacakDakika);

                        Response.Cookies.Append("anahtar", Request.Form["cerez"].ToString(), option);

                        cerez = Request.Form["cerez"];
                        durum = "Çerez eklendi...";
                    }
                    else
                        durum = "Çerezde boş veri yollandı, çerez oluşmadı...";
                    break;

                default:
                    break;
            }
        }
    }
}