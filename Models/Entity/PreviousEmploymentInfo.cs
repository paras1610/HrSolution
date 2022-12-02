using System.ComponentModel.DataAnnotations;

namespace OCR_Implementation.Models.Entity
{
    public class PreviousEmploymentInfo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPhone { get; set;}
        public string Designation { get; set; }
        public string CompanyEmail { get; set; }
        public string salary { get; set; }
        
    }
}
