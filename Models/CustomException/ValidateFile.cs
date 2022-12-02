using Microsoft.Extensions.FileProviders;
using OCR_Implementation.Models;

namespace MyFirstWebAPI.Models.CustomException
{
    internal class ValidateFile
    {
        public void Validate(IFormFile file)            
        {
            if (file == null || file.Length == 0)
            {
                throw new NotValidFileException("File Not found");
            }
            else if (!(file.FileName.Contains(".jpg") || file.FileName.Contains(".jpeg")|| file.FileName.Contains(".png")|| file.FileName.Contains(".PNG")||file.FileName.Contains(".JPEG")|| file.FileName.Contains(".JPG")))
            {
                throw new NotValidFileException("File type not valid !\n\t Acceptrd formats: .jpg/.jpeg/.png: ");
            }
           


        }
    }
}