using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstProject;
using FirstProject.Attributes;
using FirstProject.Enums;

namespace FirstProjectUnitTests
{
    [TestClass]
    public class AttributesTests
    {
        [TestMethod]
        public void Test_GetAttributeForPersonName_ShouldNotBeNull()
        {
            // Arrange
            Person person = new Person(); 

            // Act 
            var result = ImportantInformationHelper.GetImportantInformationAttribute(typeof(Person), "Name");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(SecurityLevelEnum.Administrator.ToString(), result.SecurityLevel.ToString());
        }

        [TestMethod]
        public void Test_GetAttributeNotDefinedForProperty_ShouldBeNull()
        {
            // Arrange
            Person person = new Person();

            // Act 
            var result = ImportantInformationHelper.GetImportantInformationAttribute(typeof(Person), "Id");

            // Assert
            Assert.IsNull(result); 
        }

        [TestMethod]
        public void Test_GetAttribute_PropertyNotExists_ShouldBeNull()
        {
            // Arrange
            Person person = new Person();

            // Act 
            var result = ImportantInformationHelper.GetImportantInformationAttribute(typeof(Person), "WrongPropertyName");

            // Assert
            Assert.IsNull(result); 
        }
    }
}
