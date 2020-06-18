using System;

public class Config<T,V>
{
    
    public Config(T version, V domainName)
    {
        Version = version;
        DomainName = domainName;
    }


    public T Version { get; }
    public V DomainName { get; }



}