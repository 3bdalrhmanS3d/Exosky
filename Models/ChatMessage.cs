using System.ComponentModel.DataAnnotations;

namespace Exosky.Models
{
    public class ChatMessage
    {
        [Key]
        public int MessageId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string MessageText { get; set; }

        [Required]
        public DateTime SentTime { get; set; }
    }
}
