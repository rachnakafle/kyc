using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DocumentFormat.OpenXml.Drawing.Diagrams;
namespace First_Project.Models
{
    public class Product
    {
        [Key]
        [StringLength(6)]
        public string Code { get; set; }
        [StringLength(75)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Required]
        [StringLength(2)]
        public string Category { get; set; }
        [Column(TypeName = "money")]
        public decimal Cost { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [StringLength(500)]
        public string ImageUrl { get; set; }
        [ForeignKey(nameof(Category))]
        [InverseProperty("Products")]
        public virtual Category CategoryNavigation { get; set; }

        [Required(ErrorMessage = "Please choose Front Image")]
        [Display(Name = "Front Image")]
        [NotMapped]
        public IFormFile FrontImage { get; set; }
    }
}
