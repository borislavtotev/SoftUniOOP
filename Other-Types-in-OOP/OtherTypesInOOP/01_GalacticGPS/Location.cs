public struct Location
{
    public Location(double latitude, double longitude, Planet planet): this()
    {
        this.Latitute = latitude;
        this.Longitude = longitude;
        this.Planet = planet;
    }

    public double Latitute { get; private set; }
    
    public double Longitude { get; private set; }

    public Planet Planet { get; private set; }

    public override string ToString()
    {
        return string.Format("{0}, {1} - {2}", this.Latitute, this.Longitude, this.Planet);
    }
}

