using OCR_Implementation.Models.Entity;

namespace OCR_Implementation.Models.OCR_Repository
{
    public class OCR_Repo : IOCR_Repository
    {
        OCR_DBContext db = new OCR_DBContext();
        public void PersonalSave(Employee emp)
        {
           
            db.Employees.Add(emp);
            db.SaveChanges();
        }

        public void PreviousEmploymentSave(PreviousEmploymentInfo data)
        {
            db.PreviousEmploymentInfos.Add(data);
            db.SaveChanges();
        }
    }
}
