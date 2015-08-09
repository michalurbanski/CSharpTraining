using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.Exceptions
{
    /// <summary>
    /// Custom exception when age less than 0 has been encountered
    /// </summary>
    /// <remarks>
    /// For example purposes - in real application exception for such situation may not be the best solution
    /// </remarks>
    [Serializable]
    public class InvalidAgeException : Exception, ISerializable
    {
        public int Age { get; set; }

        public InvalidAgeException()
        {

        }

        public InvalidAgeException(string message) : base(message)
        {

        }

        public InvalidAgeException(string message, Exception innerException) : base(message, innerException)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        /// <remarks>This constructor is used for deserialization when no custom properties used. 
        /// Commenting out this constructor will throw an exception during deserialization attempt. 
        /// Handling required in case of custom properties used. 
        /// </remarks>
        protected InvalidAgeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            if (info != null)
                Age = info.GetInt32("Age");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        /// <remarks>Required for correct custom property serialization</remarks>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            if (info != null)
                info.AddValue("Age", Age);
        }

    }
}
 