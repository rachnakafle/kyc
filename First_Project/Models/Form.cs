using First_Project.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace First_Project.Models
{
    public class Form
    {
        [Key]
        public int CustomerId { get; set; }
        [Display(Name = "Fullname")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter name.")]
        public string FullName{get;set;}

        [Display(Name = "DOB(AD)")]
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string Gender { get; set; }

        [Display(Name = "Email Address")]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [Required]
        public string PhoneNumber { get; set; }

        [Display(Name = "Marital Status")]
        [Required]
        public string MaritalStatus { get; set; }

        [Display(Name = "Father's Name")]
        [Required]
        public string FatherName { get; set; }

        [Display(Name = "Mother's Name")]
        [Required]
        public string MotherName { get; set; }

        [Display(Name = "Grand Father's Name")]
        [Required]
        public string GrandFatherName { get; set; }

        
        public string Occupation { get; set; }

        
        public string Nationality { get; set; }

        //Current Address Information

        public ProvinceEnum Province { get; set; }
        public string District { get; set; }

        [Display(Name = "Municipality or Gaupalika")]
        public string Municipality { get; set; }
        public int WardNo { get; set; }

        [Display(Name = "Street Name")] 
        public string StreetName { get; set; }

        [Display(Name = "House Number")] 
        public string HouseNumber { get; set; }

        //Document Information
        public int IdType { get; set; }
        public int DocumentNumber { get; set; }
        public string IssuedByState { get; set; }
        public string IssuedByDistrict { get; set; }
        public string IssueDate { get; set; }
        public StatusEnum Status { get; set; }
    }
}
