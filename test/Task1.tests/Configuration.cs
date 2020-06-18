using System;

public class Configuration
{
    public Configuration()
    {
    }

    public Configuration(int version, string domainName, string[] ipAddresses)
    {
        Version = version;
        DomainName = domainName;
        IpAddresses = ipAddresses;
    }
    public Configuration(int version, string[] ipAddresses)
    {
        Version = version;
        IpAddresses = ipAddresses;
    }

    public int Version { get; }
    public string DomainName { get; }
    public string[] IpAddresses { get; }

}
