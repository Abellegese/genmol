using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace genmol.Pages
{
    public class workspacesModel : PageModel
    {
        public string Message { get; set; } = "";
        private readonly IWebHostEnvironment Environment;
        public workspacesModel(IWebHostEnvironment env){
            Environment = env;
        }
        public void OnGet()
        {
            
        }
        [IgnoreAntiforgeryToken]
        public IActionResult OnPostMyUploader(IFormFile MyUploader)
        {
            if (MyUploader != null)
            {
                string uploadsFolder = Path.Combine(Environment.WebRootPath, "app/res");
                string filePath = Path.Combine(uploadsFolder, MyUploader.FileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    MyUploader.CopyTo(fileStream);
                }
                return new ObjectResult(new { status = "success" });
            }
            return new ObjectResult(new { status = "fail" });

        }
    }
}
