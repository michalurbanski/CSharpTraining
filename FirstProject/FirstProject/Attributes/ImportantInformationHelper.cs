using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Attributes
{
    /// <summary>
    /// Reads information from defined attribute
    /// </summary>
    public static class ImportantInformationHelper
    {
        public static ImportantInformationAttribute GetImportantInformationAttribute(Type t, string propertyName)
        {
            MemberInfo[] memberInfo = t.GetProperties(); 
            MemberInfo property = memberInfo.Where(s => s.Name == propertyName).FirstOrDefault(); 

            if(property == null)
            {
                return null; 
            }

            return (ImportantInformationAttribute)Attribute.GetCustomAttribute(property, typeof(ImportantInformationAttribute));
        }
    }
}
