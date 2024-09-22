using System.ComponentModel.DataAnnotations.Schema;

namespace Exosky.Models
{
    public class Constellation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } // معرف الكوكبة
        public string Name { get; set; } // اسم الكوكبة
        public List<Star> Stars { get; set; } // النجوم المكونة للكوكبة
    }

}
