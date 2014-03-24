using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dibware.System.Extensions.Tests
{
    /// <summary>
    /// Provides extensions to the string class
    /// </summary>
    [TestClass]
    public class StringExtensionTests
    {
        #region HasValue

        [TestMethod]
        public void Test_HasValue_ReturnsFalse_ForNullString()
        {
            // Arrange
            const String value = null;
            const Boolean expectedValue = false;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.HasValue());
        }

        [TestMethod]
        public void Test_HasValue_ReturnsFalse_ForEmptyString()
        {
            // Arrange
            const String value = "";
            const Boolean expectedValue = false;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.HasValue());
        }

        [TestMethod]
        public void Test_HasValue_Returnstrue_ForFilledString()
        {
            // Arrange
            const String value = "SomeValue";
            const Boolean expectedValue = true;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.HasValue());
        }

        [TestMethod]
        public void Test_HasValue_Returnstrue_ForWhiteSpace()
        {
            // Arrange
            const String value = "  ";
            const Boolean expectedValue = true;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.HasValue());
        }

        #endregion

        #region IsNullOrEmpty

        [TestMethod]
        public void Test_IsNullOrEmpty_ReturnsTrue_ForNullString()
        {
            // Arrange
            const String value = null;
            const Boolean expectedValue = true;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrEmpty());
        }

        [TestMethod]
        public void Test_IsNullOrEmpty_ReturnsTrue_ForEmptyString()
        {
            // Arrange
            const String value = "";
            const Boolean expectedValue = true;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrEmpty());
        }

        [TestMethod]
        public void Test_IsNullOrEmpty_ReturnsFalse_ForFilledString()
        {
            // Arrange
            const String value = "SomeValue";
            const Boolean expectedValue = false;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrEmpty());
        }

        [TestMethod]
        public void Test_IsNullOrEmpty_ReturnsFalse_ForWhiteSpace()
        {
            // Arrange
            const String value = "   ";
            const Boolean expectedValue = false;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrEmpty());
        }

        #endregion

        #region IsNullOrWhiteSpace

        [TestMethod]
        public void Test_IsNullOrWhiteSpace_ReturnsTrue_ForNullString()
        {
            // Arrange
            const String value = null;
            const Boolean expectedValue = true;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrWhiteSpace());
        }

        [TestMethod]
        public void Test_IsNullOrWhiteSpace_ReturnsTrue_ForEmptyString()
        {
            // Arrange
            const String value = "";
            const Boolean expectedValue = true;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrWhiteSpace());
        }

        [TestMethod]
        public void Test_IsNullOrWhiteSpace_ReturnsFalse_ForFilledString()
        {
            // Arrange
            const String value = "SomeValue";
            const Boolean expectedValue = false;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrWhiteSpace());
        }

        [TestMethod]
        public void Test_IsNullOrWhiteSpace_ReturnsFalse_ForWhiteSpace()
        {
            // Arrange
            const String value = "    ";
            const Boolean expectedValue = true;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrWhiteSpace());
        }

        #endregion

        #region IsNullOrEmptyOrWhiteSpace

        [TestMethod]
        public void Test_IsNullOrEmptyOrWhiteSpace_ReturnsTrue_ForNullString()
        {
            // Arrange
            const String value = null;
            const Boolean expectedValue = true;

            // Act


            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrEmptyOrWhiteSpace());
        }

        [TestMethod]
        public void Test_IsNullOrEmptyOrWhiteSpace_ReturnsTrue_ForEmptyString()
        {
            // Arrange
            const String value = "";
            const Boolean expectedValue = true;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrEmptyOrWhiteSpace());
        }

        [TestMethod]
        public void Test_IsNullOrEmptyOrWhiteSpace_ReturnsFalse_ForFilledString()
        {
            // Arrange
            const String value = "SomeValue";
            const Boolean expectedValue = false;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrEmptyOrWhiteSpace());
        }

        [TestMethod]
        public void Test_IsNullOrEmptyOrWhiteSpace_ReturnsFalse_ForWhiteSpace()
        {
            // Arrange
            const String value = "    ";
            const Boolean expectedValue = true;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrEmptyOrWhiteSpace());
        }

        #endregion
    }
}