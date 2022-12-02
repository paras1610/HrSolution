using OCR_Implementation.Models.Entity;

namespace OCR_Implementation.Models.OCR_Repository
{
    public interface IOCR_Repository
    {
      
         void PersonalSave(Employee e);
        void PreviousEmploymentSave(PreviousEmploymentInfo info); 
    }
}
