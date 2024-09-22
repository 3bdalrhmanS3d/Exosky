using System.ComponentModel.DataAnnotations.Schema;

namespace Exosky.Models
{
    public class Comment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } // معرف التعليق
        public User User { get; set; } // المستخدم الذي قام بكتابة التعليق
        public string Content { get; set; } // محتوى التعليق
        public DateTime CommentDate { get; set; } // تاريخ التعليق
    }
}
