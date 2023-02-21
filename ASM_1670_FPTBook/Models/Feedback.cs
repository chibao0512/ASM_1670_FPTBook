using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASM_1670_FPTBook.Models
{
    public class Feedback
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Feedback_Id { get; set; }
        public string Feedback_Title { get; set; }

    }
}
