using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace uygulamamiz.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public string? cerez { get; set; } = "varsayılan";
        public string? oturum { get; set; } = "varsayılan";

        public void OnGet(string? sil = null)
        {
            if (sil == "sil")
            {
                //tarih ile de silinebilir
                Response.Cookies.Delete("anahtar");
                cerez = "<çerez silindi>";

                //tüm bilgileri siler
                HttpContext.Session.Clear();
                oturum = "<oturum silindi>";
            }
            else
            {
                if (Request.Cookies["anahtar"] != null)
                    cerez = Request.Cookies["anahtar"];
                else
                    cerez = "<çerez daha oluşmamış>";

                if (HttpContext.Session.GetString("oturum") != null)
                    oturum = HttpContext.Session.GetString("oturum");
                else
                    oturum = "<oturum daha oluşmamış>";
            }
        }
    }
}