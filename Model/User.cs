using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApiInto_1.Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        //[MaxLength(100,ErrorMessage ="Abeg !")]
        //[MinLength(5,ErrorMessage ="")]
        //[StringLength(100,MinimumLength = 34,ErrorMessage ="")]
        public string Name { get; set; }
        public bool IsMale { get; set; }
        public int Age { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
