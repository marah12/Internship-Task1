
using System;


using System.Reflection;
namespace Task1
{
    public static class Program
    {
        static void Main(string[] args)
        {
        
        }
        public static bool IsNumber(this object value)
        {
            return value is sbyte
                    || value is byte
                    || value is short
                    || value is ushort
                    || value is int
                    || value is uint
                    || value is long
                    || value is ulong
                    || value is float
                    || value is double
                    || value is decimal;
        }
        
        public static String ParseToJson(Object obj)
        {
            string result = @"""{";

            Type t = obj.GetType();

            PropertyInfo[] props = t.GetProperties();

            foreach (var prop in props)
                if (prop.GetIndexParameters().Length == 0)


                {
                    result += @"""" + prop.Name + @""":";
                    if (IsNumber(prop.GetValue(obj)))
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

