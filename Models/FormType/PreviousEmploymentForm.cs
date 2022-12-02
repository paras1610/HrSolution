using OCR_Implementation.Models.Entity;
using OCR_Implementation.Models.OCR_Repository;

namespace OCR_Implementation.Models.FormType
{
    public class PreviousEmploymentForm : IFormType
    {
        public void GenerateData(string raw)
        {
            PreviousEmploymentInfo employmentInfo= new PreviousEmploymentInfo();

            string[] t = raw.Split(" ");


            for (int i = 0; i < t.Length; i++)
            {
                if (t[i].Equals("Employee") && t[i + 1].Equals("Name"))
                {
                    employmentInfo.Name = t[i + 2] +" " + t[i+3];
                }
                if (t[i].Equals("Previous") && t[i + 1].Equals("Company") && t[i + 2].Equals("Name"))
                {
                    employmentInfo.CompanyName = t[i + 3] + t[i + 4] + t[i + 5];
                }
                if (t[i].Equals("Designation"))
                {
                    employmentInfo.Designation = t[i + 1]+" " + t[i+2];
                }
                if (t[i].Equals("Company") && t[i + 1].Equals("Email"))
                {
                    employmentInfo.CompanyEmail = t[i + 2];
                }

                if (t[i].Equals("Previous") && t[i + 1].Equals("Salary"))
                {
                    employmentInfo.salary = t[i + 2];
                }
                if (t[i].Equals("Company") && t[i + 1].Equals("Phone") && t[i + 2].Equals("Number"))
                {
                    employmentInfo.CompanyPhone = t[i + 3];
                }

                
            }
            IOCR_Repository repo = new OCR_Repo();
            repo.PreviousEmploymentSave(employmentInfo);
        }
    }
}
