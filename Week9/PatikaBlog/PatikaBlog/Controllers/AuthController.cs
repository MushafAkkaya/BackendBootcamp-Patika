using Microsoft.AspNetCore.Mvc;
using PatikaBlog.Models;

namespace PatikaBlog.Controllers
{
    // Authentication & Authorization 
    public class AuthController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        public AuthController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }


        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SignUp(SignUpFormViewModel formData)
        {
            if (!ModelState.IsValid)
            {

                return View(formData);
            }

            // yooooooooooo.jpg
            // yoooo.script
            // yoooo.txt

            // yoooooo-dwakjhdawjhdwa.jpg
            var newFileName = "";

            if (formData.Image is not null)
            {

                var allowedFileTypes = new string[] { "image/jpeg", "image/jpg", "image/png", "image/jfif", "image(avif" };

                var allowedFileExtensions = new string[] { ".jpg", ".jpeg", ".png", "jfif",
                 ".avif"};


                var fileContentType = formData.Image.ContentType;
                // Dosyanın içerik tipi

                var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(formData.Image.FileName);
                // Dosyanın uzantısız adı

                var fileExtension = Path.GetExtension(formData.Image.FileName);
                // Dosyanın uzantı kısmı (.txt - .jpg gibi)



                if (!allowedFileTypes.Contains(fileContentType) || !allowedFileExtensions.Contains(fileExtension))
                {
                    // İstediğim tipte veya uzantıda değilse , geri gönderiyorum.

                    return View(formData);
                }

                newFileName = fileNameWithoutExtension + "-" + Guid.NewGuid() + fileExtension;

                var folderPath = Path.Combine("Users", "Profiles");
                // Users/Profiles

                var wwwrootFolderPath = Path.Combine(_environment.WebRootPath, folderPath);
                // wwwroot/Users/Profiles

                var filePath = Path.Combine(wwwrootFolderPath, newFileName);

                Directory.CreateDirectory(wwwrootFolderPath); // wwwroot/users/profiles yoksa oluştur.

                using (var filestream = new FileStream(filePath, FileMode.Create))
                {
                    formData.Image.CopyTo(filestream);
                    // Asıl dosya kopyalanıyor.
                }

            }

         

            return View();
        }
    }
}
