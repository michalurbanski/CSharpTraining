using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstProject.Exceptions;
using FirstProject;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FirstProjectUnitTests
{
    [TestClass]
    public class ExceptionTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidAgeException), "Expected exception not raised")]
        public void Add_Person_WithAgeBelowZero_ThrowsInvalidAgeException()
        {
            // Arrange
            PeopleCollection people = new PeopleCollection(); 

            // Act
            people.AddPerson(new Person() { Name = "Jack", Age = -1 });
        }

        [TestMethod]
        public void Add_Person_WithIncorrectAge_ThrownExceptionShouldHaveMessage()
        {
            try 
	        {	        
		        // Arrange
                PeopleCollection people = new PeopleCollection();

                // Act
                people.AddPerson(new Person() { Name = "Jack", Age = -1 });

	        }
	        catch (Exception ex)
	        {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);

                Assert.AreNotEqual<string>(string.Empty, ex.Message); 
                Assert.IsNull(ex.InnerException); 
                
                Assert.IsTrue(true);
                return; 
	        }

            Assert.IsTrue(false); 
        }

        [TestMethod]
        public void Add_Person_WithIncorrectAge_ThrowsException_TestBasicSerialization()
        {
            // Arrange
            InvalidAgeException exception = new InvalidAgeException("Custom message");

            // Act
            using (Stream s = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(s, exception);

                s.Position = 0; // Reset stream position 
                exception = (InvalidAgeException)formatter.Deserialize(s);
            }

            // Assert
            Assert.AreEqual(exception.Message, "Custom message");
        }
    
    }
}
