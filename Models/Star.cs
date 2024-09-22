using System.ComponentModel.DataAnnotations.Schema;

namespace Exosky.Models
{
    public class Star
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } // معرف النجم
        public string Name { get; set; } // اسم النجم
        public double RightAscension { get; set; } // الصعود المستقيم RA
        public double Declination { get; set; } // الميل Dec
        public double ApparentMagnitude { get; set; } // السطوع الظاهري
        public double DistanceFromEarth { get; set; } // المسافة من الأرض
    }
}
