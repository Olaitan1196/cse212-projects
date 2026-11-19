public class Properties
{
    public string? Place { get; set; }
    public double? Mag { get; set; }
}

public class Feature
{
    public Properties? Properties { get; set; }
}

public class FeatureCollection
{
    public List<Feature>? Features { get; set; }
}