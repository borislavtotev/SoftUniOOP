using System;
[AttributeUsage(AttributeTargets.All)]
public class VersionAttribute : System.Attribute
{
    public readonly int mainVersion;
    public readonly int minorVersion;

    public VersionAttribute(int mainVersion, int minorVersion)
    {
        this.mainVersion = mainVersion;
        this.minorVersion = minorVersion;
    }

    public override string ToString()
    {
        return mainVersion.ToString() + "." + minorVersion.ToString();
    }
}

