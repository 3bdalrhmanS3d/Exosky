using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exosky.Models
{
    public class Exoplanet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string HostStar { get; set; }

        public double DistanceFromEarth { get; set; }

        public double Radius { get; set; }

        public double Mass { get; set; }

        public double OrbitalPeriod { get; set; }
    }
}
