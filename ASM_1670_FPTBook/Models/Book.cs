using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASM_1670_FPTBook.Models
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Book_Id { get; set; }
        [Required]
        public string Book_Title { get; set; }
        public int Publisher_Id { get; set; }
        public string Book_Author { get; set; }
        public int Genre_Id { get; set; }
        public decimal Book_Price { get; set; }
        public string Book_Description { get; set; }
        public virtual Genre? genre { get; set; }
        public virtual Publisher? publisher { get; set; }
    }
}
