using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Exosky.Models
{
    /*
     * 
     * This entity represents sky maps that the user can share with everyone,
     * and contains information
     * about the user who shared the map, the number of likes and comments.
     */
    public class SharedSkyMap
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } // معرف المشاركة
        public SkyMap SkyMap { get; set; } // الخريطة التي تمت مشاركتها
        public User User { get; set; } // المستخدم الذي شارك الخريطة
        public List<Comment> Comments { get; set; } // التعليقات على المشاركة
        public List<Like> Likes { get; set; } // قائمة الإعجابات

        public DateTime SharedDate { get; set; } // تاريخ المشاركة
    }
}
