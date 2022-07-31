using System.ComponentModel.DataAnnotations;

namespace First_Project.Models
{
    public class Form
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public bool IsActive { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
    }

    //public enum Province
    //{
    //    Province1,
    //    Province2,
    //    Province3,
    //    Gandaki,
    //    Province5,
    //    Karnali,
    //    Sudurpashchim
    //}
}
