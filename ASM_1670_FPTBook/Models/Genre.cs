using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASM_1670_FPTBook.Models
{
    public class Genre
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Gen_Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Gen_Name { get; set; }
        [Required]
        public string Gen_Description { get; set; }
    }
}
