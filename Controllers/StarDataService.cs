using CsvHelper;
using Exosky.Data;
using Exosky.Models;
using Microsoft.AspNetCore.Mvc;
using System.Formats.Asn1;
using System.Globalization;

namespace Exosky.Controllers
{
    public class StarDataService : Controller
    {
        private readonly AppDbContext _context;
        public StarDataService(AppDbContext context)
        { 
            _context = context;
        }


        public IActionResult Index()
        {
            ImportStarsFromCsv();
            return Ok();
        }

        //    /StarDataService/Index
        public void ImportStarsFromCsv()
        {
            using (var reader = new StreamReader("C:\\Users\\Concept D\\source\\repos\\Exosky\\wwwroot\\NasaData.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<MainStarMap>();

                // Disable header validation to avoid errors if headers are different
                /*csv.Configuration.HeaderValidated = null;
                csv.Configuration.MissingFieldFound = null; // Prevent errors from missing fields
*/
                //csv.Configuration.HeaderValidated = null;
                // Read the CSV records into a list
                var records = csv.GetRecords<MainStar>().ToList();

                // Previous record for filling empty fields
                MainStar previousRecord = null;

                foreach (var record in records)
                {
                    // Fill empty fields with values from the previous record
                    if (previousRecord != null)
                    {
                        record.Id = (record.Id) ;
                        record.bf = string.IsNullOrEmpty(record.bf) ? previousRecord.bf : record.bf;
                        record.Proper = string.IsNullOrEmpty(record.Proper) ? previousRecord.Proper : record.Proper;
                        record.RA = record.RA == 0 ? previousRecord.RA : record.RA;
                        record.Dec = record.Dec == 0 ? previousRecord.Dec : record.Dec;
                        record.Distance = record.Distance == 0 ? previousRecord.Distance : record.Distance;
                        record.ProperMotionRA = record.ProperMotionRA == 0 ? previousRecord.ProperMotionRA : record.ProperMotionRA;
                        record.ProperMotionDec = record.ProperMotionDec == 0 ? previousRecord.ProperMotionDec : record.ProperMotionDec;
                        record.RadialVelocity = record.RadialVelocity == 0 ? previousRecord.RadialVelocity : record.RadialVelocity;
                        record.ApparentMagnitude = record.ApparentMagnitude == 0 ? previousRecord.ApparentMagnitude : record.ApparentMagnitude;
                        record.AbsoluteMagnitude = record.AbsoluteMagnitude == 0 ? previousRecord.AbsoluteMagnitude : record.AbsoluteMagnitude;
                        record.SpectralType = string.IsNullOrEmpty(record.SpectralType) ? previousRecord.SpectralType : record.SpectralType;
                        record.ColorIndex = record.ColorIndex == 0 ? previousRecord.ColorIndex : record.ColorIndex;
                        record.X = record.X == 0 ? previousRecord.X : record.X;
                        record.Y = record.Y == 0 ? previousRecord.Y : record.Y;
                        record.Z = record.Z == 0 ? previousRecord.Z : record.Z;
                        record.VelocityX = record.VelocityX == 0 ? previousRecord.VelocityX : record.VelocityX;
                        record.VelocityY = record.VelocityY == 0 ? previousRecord.VelocityY : record.VelocityY;
                        record.VelocityZ = record.VelocityZ == 0 ? previousRecord.VelocityZ : record.VelocityZ;
                        record.Constellation = string.IsNullOrEmpty(record.Constellation) ? previousRecord.Constellation : record.Constellation;
                    }

                    // Update the previous record
                    previousRecord = record;
                }

                // Add the stars to the database context
                _context.MainStars.AddRange(records);

                // Save changes to the database
                _context.SaveChanges();
            }
        }
    }
}
