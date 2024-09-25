using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exosky.Models
{
    public class MainStar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int mainStarID { get; set; }

        [Name("id")]
        public int Id { get; set; } // Unique identifier

        [Name("bf")]
        [Display(Name = "BayerFlamsteed designation")]
        public string bf { get; set; } // Bayer/Flamsteed designation

        [Name("proper")]
        [Display(Name = "Proper Name")]
        public string Proper { get; set; } // Proper name of the star

        [Name("ra")]
        [Display(Name = "Right Ascension")]
        public double RA { get; set; } // Right Ascension

        [Name("dec")]
        [Display(Name = "Declination")]
        public double Dec { get; set; } // Declination

        [Name("dist")]
        [Display(Name = "Distance (parsecs)")]
        public double Distance { get; set; } // Distance from Earth

        [Name("pmra")]
        [Display(Name = "Proper Motion RA")]
        public double ProperMotionRA { get; set; } // Proper motion in RA

        [Name("pmdec")]
        [Display(Name = "Proper Motion Dec")]
        public double ProperMotionDec { get; set; } // Proper motion in Dec

        [Name("rv")]
        [Display(Name = "Radial Velocity")]
        public double RadialVelocity { get; set; } // Radial velocity

        [Name("mag")]
        [Display(Name = "Apparent Magnitude")]
        public double ApparentMagnitude { get; set; } // Apparent magnitude

        [Name("absmag")]
        [Display(Name = "Absolute Magnitude")]
        public double AbsoluteMagnitude { get; set; } // Absolute magnitude

        [Name("spect")]
        [Display(Name = "Spectral Type")]
        public string SpectralType { get; set; } // Spectral type

        [Name("ci")]
        [Display(Name = "Color Index")]
        public double ColorIndex { get; set; } // Color index

        [Name("x")]
        [Display(Name = "X Coordinate")]
        public double X { get; set; } // X coordinate

        [Name("y")]
        [Display(Name = "Y Coordinate")]
        public double Y { get; set; } // Y coordinate

        [Name("z")]
        [Display(Name = "Z Coordinate")]
        public double Z { get; set; } // Z coordinate

        [Name("vx")]
        [Display(Name = "Velocity X")]
        public double VelocityX { get; set; } // Velocity in X direction

        [Name("vy")]
        [Display(Name = "Velocity Y")]
        public double VelocityY { get; set; } // Velocity in Y direction

        [Name("vz")]
        [Display(Name = "Velocity Z")]
        public double VelocityZ { get; set; } // Velocity in Z direction

        [Name("con")]
        [Display(Name = "Constellation")]
        public string Constellation { get; set; } // Constellation
    }
}
