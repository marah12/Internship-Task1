using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Reflection;
using System.Net.Http.Headers;
using Xunit;

namespace Task1.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestObject()
        {
            //arange
            var version = 2; 
            var domainName = "www.training.com"; 
            string[] ipAddress = new string[]{"192.168.1.8","192.168.1.2"}; 
            var config = new Configuration(version, domainName, ipAddress);
            //act            
          var actual =Program.ParseToJson(config);
          var expected = @"""{""Version"":2,""DomainName"":""www.training.com"",""IpAddresses"":[""192.168.1.8"",""192.168.1.2""]}""";
         
            //assert
            Assert.Equal(expected,actual );

     
        }
         [Fact]
        public void TestObjectWithDifferentProperties()
        {
            //arange
            var version = 2.1; 
            var domainName = "www.training.com"; 
            var config = new Config(version, domainName);
            //act            
          var actual =Program.ParseToJson(config);
          var expected = @"""{""Version"":2.1,""DomainName"":""www.training.com""}""";
         
            //assert
            Assert.Equal(expected,actual );

     
        }
           
      [Fact]
        public void TestObjectWithNoProperties_GivingEmptyResult()
        {
            //arange
           
            var config = new Config1();
            //act            
          var actual =Program.ParseToJson(config);
          var expected = @"""{}""";
         
            //assert
            Assert.Equal(expected,actual );

     
        }
    }
}