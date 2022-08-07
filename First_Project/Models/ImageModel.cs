using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace First_Project.Models
{
    public class ImageModel
    {
        [Key]
        public int ImageId { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImageName { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        [Required]

        public IFormFile ImageFile { get; set; }
    }
}
