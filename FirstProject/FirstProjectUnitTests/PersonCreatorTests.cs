using FirstProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectUnitTests
{
    [TestClass]
    public class PersonCreatorTests
    {
        [TestMethod]
        public void Test_CreatePersonFromTypeName_ShouldCreateProperObject()
        {
            // Arrange
            ObjectCreator creator = new ObjectCreator();
            string expectedType = "FirstProject.Person";

            // Act 
            Person person = creator.CreateFromTypeUsingDefaultConstructor<Person>(expectedType);

            // Assert
            Assert.IsNotNull(person);
            Assert.AreEqual(expectedType, person.GetType().FullName);
        }
    }
}
