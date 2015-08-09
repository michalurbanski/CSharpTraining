using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstProject.Exceptions;
using FirstProject;

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

    }
}
