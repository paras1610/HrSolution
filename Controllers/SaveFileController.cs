using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OCR_Implementation.Models;

namespace MyFirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaveFileController : ControllerBase
    {
        [HttpGet]
        public IActionResult SaveDataInDB()
        {
            try
            {
                if (OCR_Manager.SaveData())
                {
                    return Ok("Saved in Db");
                }
                else
                    return Ok("Process Failed.\n Potential Causes it is not HRForm Series \n or  Server Down ");
            }
            catch(Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}
