using System.ComponentModel.DataAnnotations.Schema;

namespace Exosky.Models
{
    public class SkyMap
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } // معرف الخريطة
        public Exoplanet Exoplanet { get; set; } // الكوكب الخارجي المرتبط بالخريطة
        public List<Star> Stars { get; set; } // قائمة النجوم المرئية
        public List<Constellation> Constellations { get; set; } // قائمة الكوكبات المرسومة
        public DateTime ObservationTime { get; set; } // وقت الملاحظة
    }

}
