using FirstProject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>Custom attribute has to be public</remarks>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple=true, Inherited=true)]
    public class ImportantInformationAttribute : Attribute
    {
        private SecurityLevelEnum _securityLevel;

        public ImportantInformationAttribute(SecurityLevelEnum securityLevel)
        {
            _securityLevel = securityLevel; 
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual SecurityLevelEnum SecurityLevel
        {
            get { return _securityLevel;  }
        }

        /// <summary>
        /// Optional property (not specified in constructor)
        /// </summary>
        public virtual int Version { get; set; }
    }
}
