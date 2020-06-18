
using System;


using System.Reflection;
namespace Task1
{
    public  class Program
    {
        static void Main(string[] args)
        {
        
        }
      
        
        public static String ParseToJson(object obj)
        {
            string result = @"""{";

            Type t = obj.GetType();

            PropertyInfo[] props = t.GetProperties();

            foreach (var prop in props)
                if (prop.GetIndexParameters().Length == 0)


                {
                  if(!(prop.GetValue(obj) is int) && !(prop.GetValue(obj) is String) && !(prop.PropertyType.IsArray)){
                        continue; 
                    }
                    result += @"""" + prop.Name + @""":";
                    if (prop.GetValue(obj) is int)
                    {

                        result += prop.GetValue(obj) + ",";
                    }
                    else if (prop.PropertyType.Name.Equals("String"))

                    {

                        result += @"""" + prop.GetValue(obj) + @""",";
                    }
                    else if (prop.PropertyType.IsArray)
                    {

                        object[] ip = (object[])prop.GetValue(obj);
                        result += "[";
                        if (ip != null)
                        {
                            for (int i = 0; i < ip.Length; i++)
                            {
                                object o = ip.GetValue(i);
                                if (i == ip.Length - 1)
                                {
                                    result += @"""" + o + @"""";

                                }
                                else
                                {
                                    result += @"""" + o + @""",";
                                }

                            }
                        }

                        result += "]";


                    }

                }
                else
                    return "";
            string s = result.Substring(result.Length - 1);
            if (s.Equals(","))
            {
                result = result.Remove(result.Length - 1, 1);
            }
            result += @"}""";
            return result;

        }

    }
}

