using CsvHelper.Configuration;
using Exosky.Models;

public class MainStarMap : ClassMap<MainStar>
{
    public MainStarMap()
    {
        // Map CSV headers to model properties
        Map(m => m.Id).Name("id");
        Map(m => m.bf).Name("bf");
        Map(m => m.Proper).Name("proper");
        Map(m => m.RA).Name("ra").TypeConverterOption.NullValues("").Default(0.0);
        Map(m => m.Dec).Name("dec").TypeConverterOption.NullValues("").Default(0.0);
        Map(m => m.Distance).Name("dist").TypeConverterOption.NullValues("").Default(0.0);
        Map(m => m.ProperMotionRA).Name("pmra").TypeConverterOption.NullValues("").Default(0.0);
        Map(m => m.ProperMotionDec).Name("pmdec").TypeConverterOption.NullValues("").Default(0.0);
        Map(m => m.RadialVelocity).Name("rv").TypeConverterOption.NullValues("").Default(0.0);
        Map(m => m.ApparentMagnitude).Name("mag").TypeConverterOption.NullValues("").Default(0.0);
        Map(m => m.AbsoluteMagnitude).Name("absmag").TypeConverterOption.NullValues("").Default(0.0);
        Map(m => m.SpectralType).Name("spect");
        Map(m => m.ColorIndex).Name("ci").TypeConverterOption.NullValues("").Default(0.0);
        Map(m => m.X).Name("x").TypeConverterOption.NullValues("").Default(0.0);
        Map(m => m.Y).Name("y").TypeConverterOption.NullValues("").Default(0.0);
        Map(m => m.Z).Name("z").TypeConverterOption.NullValues("").Default(0.0);
        Map(m => m.VelocityX).Name("vx").TypeConverterOption.NullValues("").Default(0.0);
        Map(m => m.VelocityY).Name("vy").TypeConverterOption.NullValues("").Default(0.0);
        Map(m => m.VelocityZ).Name("vz").TypeConverterOption.NullValues("").Default(0.0);
        Map(m => m.Constellation).Name("con");

        // Ignore the 'mainStarID' property
        Map(m => m.mainStarID).Ignore();
    }
}
