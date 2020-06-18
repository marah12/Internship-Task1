using System;

public class Config
{
    public Config()
    {
    }
    public Config(double version, string domainName)
    {
        Version = version;
        DomainName = domainName;
    }


    public double Version { get; }
    public string DomainName { get; }



}