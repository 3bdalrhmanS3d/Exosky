using System.ComponentModel.DataAnnotations.Schema;

namespace Exosky.Models
{
    public class Like
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } // معرف الإعجاب
        public User User { get; set; } // المستخدم الذي قام بالإعجاب
        public DateTime LikeDate { get; set; } // تاريخ الإعجاب
    }
}
