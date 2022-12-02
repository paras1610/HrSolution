using OCR_Implementation.Models.Entity;
using OCR_Implementation.Models.OCR_Repository;
using static System.Net.Mime.MediaTypeNames;

namespace OCR_Implementation.Models.FormType
{
    public class EmployeePersonalForm : IFormType
    {
        Employee p = new Employee();
       
        public void GenerateData(string raw)
        {
            string[] t = raw.Split(" ");


            for (int i = 0; i < t.Length; i++)
            {
                if (t[i].Equals("First") && t[i + 1].Equals("Name"))
                {
                    p.FirstName = t[i + 2];
                }
                if (t[i].Equals("Last") && t[i + 1].Equals("Name"))
                {
                    p.LastName = t[i + 2];
                }
                if (t[i].Equals("Address"))
                {
                    p.Address = t[i + 1];
                }
                if (t[i].Equals("Mobile"))
                {
                    p.Mobile = t[i + 1];
                }
                if (t[i].Equals("Zip") && t[i + 1].Equals("Code"))
                {
                    p.ZipCode = t[i + 2];
                }
                if (t[i].Equals("Email"))
                {
                    p.Email = t[i + 1];
                }

            }
            
           IOCR_Repository repo=new OCR_Repo();
            repo.PersonalSave(p);
        }
    }
}
