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
        public InvalidAgeException()
        {

        }

        public InvalidAgeException(string message) : base(message)
        {

        }

        public InvalidAgeException(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected InvalidAgeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }

    }
}
 