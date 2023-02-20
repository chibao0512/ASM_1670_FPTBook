using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASM_1670_FPTBook.Models
{
    public class OrderDetail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Order_Id { get; set; }
        [Column(Order = 2)]
        public int Book_Id { get; set; }
        [ForeignKey("Order_Id")]
        public virtual Order Orders { get; set; }
        [ForeignKey("Book_Id")]
        public virtual Book Books { get; set; }

    }
}
