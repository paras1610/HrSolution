using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPI.Models.CustomException;
using OCR_Implementation.Models;
using OCR_Implementation.Models.OCR_Repository;
using System.Diagnostics;

namespace MyFirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OCRController : ControllerBase
    {
        public static IConfiguration Configuration;
        string response;

        public  OCRController(IConfiguration _configuration)
        {
            Configuration = _configuration;
          // ConnStr.initstr(_configuration.GetConnectionString("MySqlDBConnectionString"));
        }       


        [HttpPost]
        public IActionResult Submit(IFormFile file)
        {  
            

            try 
            {
                OCR_Manager.ReadFile(file);
                response = "File Saved Successful";
            }
            catch(NotValidFileException ex)
            {
                response = ex.Message;

            }
            catch(Exception ex)
            {
                response = ex.Message;

            }
            return Ok(response);
            
           
        }

        [HttpGet]
        public IActionResult ShowRawData()
        {

            try
            {
                string processedData = OCR_Manager.GenerateText();
                response = processedData;
            }
            catch (EmptyStringException ex)
            {
                response = ex.Message;

            }
            catch (ChooseFileException ex)
            {
                response = ex.Message;

            }
            catch (NotValidFileException ex)
            {
                response = ex.Message;

            }
           
           
            return Ok(response);
           
        }
       


    }
}
