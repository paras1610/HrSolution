using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using MyFirstWebAPI.Controllers;
using MyFirstWebAPI.Models.CustomException;
using OCR_Implementation.Models.FormType;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using Tesseract;

namespace OCR_Implementation.Models
{
    /// <summary>
    /// this class is used for all OCR related operation like 1: saving file 2:Reading/Extraction 3:Saving in database.
    /// </summary>
    public class OCR_Manager
    {

        static ImageManager manager = new ImageManager();

        static string FileName = null;
        static string Raw = null;

        //Function for Saving uploaded file in the Uploads folder 
        public static void ReadFile(IFormFile file) 
        {
                    
            try
            {
                //for validating the file type 
                ValidateFile validateFile = new ValidateFile();
                validateFile.Validate(file);

                //calling image manager to save the file .jpg/.png file in uploads 
                manager.Save(file);
                FileName = file.FileName.ToString();               
            }
            catch(NotValidFileException)
            {
                throw;
            }
        }


        public static string GenerateText()
        {
            try
            {
                
                if (FileName != null)
                {
                    //converting .jpg file to Tesseract readable Pix format. 
                    Pix img = manager.GetPixImage(FileName);
 
                    ValidateRawImageData validateRawImage = new ValidateRawImageData();

                    //Fetching tesseract library path and language from the Appsettiing.json and storing them in the variable   @Loose coupling implemented.
                    string tesslib= (OCRController.Configuration.GetSection("TesseractSettings").GetSection("TesseractEngine").Value);                   
                    string tesslang = (OCRController.Configuration.GetSection("TesseractSettings").GetSection("Language").Value) ;

                    //Created object of tesseeract engine/Environment. 
                    TesseractEngine engine = new TesseractEngine(@"TessLib\tessdata\", tesslang);
                   
                    //converting pix image to text by tesseract engine 
                    using (var page = engine.Process(img))
                    {
                        // initiating string manager to convert the raw data in proceessed data. 
                        StringManager stringManager = new StringManager();
                        
                        // Received formated data from String manager.
                        string RawData = stringManager.GenerateString(page.GetText());
                       
                        //validate Is Image contains any Data or it is a blank image.
                        validateRawImage.Validate(RawData);
                        Raw = RawData;

                        return RawData;
                    }
                }
                else
                    throw new ChooseFileException("No File Selected");
            }
            catch(EmptyStringException)
            {
                throw;
            }
            catch(Exception)
            {
                throw;
            }
 
        }

        //method to call the form facctory class to save the data from the image if it is HRform series type form   
        public static bool SaveData() 
        {
            try
            {
                FormFactory factory = FormFactory.GetFactory();
                if (!FormName(Raw).Equals("Invalid") && !(Raw.Equals("clear")) )
                {
                    IFormType form = factory.GetForm(FormName(Raw));

                    form.GenerateData(Raw);
                    Raw = "clear";
                    return true;
                }
                else if (Raw.Equals("clear"))
                {
                    throw new NullReferenceException("Process failed:-Please first Upload and generate the raw data from file");
                }
                
                else
                    return false;
            }
            catch(Exception)
            {
                throw;
            }

        }
        public static string FormName(string f)
        {
            Dictionary<string, string> form = OCRController.Configuration.GetSection("FormTypes").GetChildren().ToDictionary(x => x.Key, x => x.Value);

            string[] t = f.Split(" ");
            foreach (string s in form.Keys)
            {
                int i = 0;
                if (t.AsQueryable().Contains(s))
                {
                    return form[s];
                }

            }           
            return "Invalid";
        }
    }
}
