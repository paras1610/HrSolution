using System.Drawing;
using Tesseract;

namespace OCR_Implementation.Models
{
    public class ImageManager
    {
        string AbsolutePath = @"Uploads\";
        public bool Save(IFormFile file)
        {
            var fileName = Path.GetFileName(file.FileName);           
            var path = Path.Combine(AbsolutePath, fileName);
            Stream stream = System.IO.File.OpenWrite(path);
            file.CopyTo(stream);
            stream.Close();
            return true;
        }
        public Pix GetPixImage(string filename) 
        {
            try
            {
               
                var img = Pix.LoadFromFile(AbsolutePath + filename);
                return img;
            }
            catch(Exception) { throw new FileNotFoundException("File Not found: \n\tcauses: \n\t\tEither file is not uploaded correctly.\n\t\tServer is down\n\tPotential fixes:\n\t\ttry uploading again. "); }
        }
    }
}
