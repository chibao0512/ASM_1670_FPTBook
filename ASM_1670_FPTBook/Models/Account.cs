using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASM_1670_FPTBook.Models
{
    public class Account
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Account_Id { get; set; }
        [Required]
        public string Account_Name { get; set; }
        [Required]
        public string Account_Password { get; set; }
        [Required]
        public string Account_Email { get; set; }
        [Required]
        public string Account_Phone { get; set; }


    }
}
