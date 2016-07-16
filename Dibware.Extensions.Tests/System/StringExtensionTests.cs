using Dibware.Extensions.System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace Dibware.Extensions.Tests.System
{
    /// <summary>
    /// Tests extensions to the String class
    /// </summary>
    [TestClass]
    public class StringExtensionTests
    {
        #region HasValue

        [TestMethod]
        public void HasValue_ReturnsFalse_ForNullString()
        {
            // Arrange
            const String value = null;
            const Boolean expectedValue = false;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.HasValue());
        }

        [TestMethod]
        public void HasValue_ReturnsFalse_ForEmptyString()
        {
            // Arrange
            const String value = "";
            const Boolean expectedValue = false;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.HasValue());
        }

        [TestMethod]
        public void HasValue_ReturnsTrue_ForFilledString()
        {
            // Arrange
            const String value = "SomeValue";
            const Boolean expectedValue = true;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.HasValue());
        }

        [TestMethod]
        public void HasValue_ReturnsTrue_ForWhiteSpace()
        {
            // Arrange
            const String value = "  ";
            const Boolean expectedValue = true;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.HasValue());
        }

        #endregion

        #region IsDateTime

        [TestMethod]
        public void IsDateTime_ReturnsFalse_ForNullString()
        {
            // Arrange
            const String value = null;
            const Boolean expectedValue = false;

            // Act
            var result = value.IsDateTime();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsDateTime_ReturnsFalse_ForemptyString()
        {
            // Arrange
            const String value = "";
            const Boolean expectedValue = false;

            // Act
            var result = value.IsDateTime();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsDateTime_ReturnsFalse_ForNonDateString()
        {
            // Arrange
            const String value = "BillyBob";
            const Boolean expectedValue = false;

            // Act
            var result = value.IsDateTime();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsDateTime_ReturnsFalse_ForNumericString()
        {
            // Arrange
            const String value = "123456";
            const Boolean expectedValue = false;

            // Act
            var result = value.IsDateTime();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsDateTime_ReturnsTrue_ForDate()
        {
            // Arrange
            var value = DateTime.Now.ToShortTimeString();
            const Boolean expectedValue = true;

            // Act
            var result = value.IsDateTime();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        #endregion

        #region IsInt16

        [TestMethod]
        public void IsInt16_ReturnsFalse_ForNullString()
        {
            // Arrange
            const String value = null;
            const Boolean expectedValue = false;

            // Act
            var result = value.IsInt16();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsInt16_ReturnsFalse_ForEmptyString()
        {
            // Arrange
            const String value = "";
            const Boolean expectedValue = false;

            // Act
            var result = value.IsInt16();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsInt16_ReturnsFalse_ForNonIntegerValue()
        {
            // Arrange
            const String value = "Bacon Rind";
            const Boolean expectedValue = false;

            // Act
            var result = value.IsInt16();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsInt16_ReturnsTrue_ForInt16Value()
        {
            // Arrange
            var value = Int16.MaxValue.ToString(CultureInfo.InvariantCulture);
            const Boolean expectedValue = true;

            // Act
            var result = value.IsInt16();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsInt16_ReturnsFalse_ForInt32Value()
        {
            // Arrange
            var value = Int32.MaxValue.ToString(CultureInfo.InvariantCulture);
            const Boolean expectedValue = false;

            // Act
            var result = value.IsInt16();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsInt16_ReturnsFalse_ForInt64Value()
        {
            // Arrange
            var value = Int64.MaxValue.ToString(CultureInfo.InvariantCulture);
            const Boolean expectedValue = false;

            // Act
            var result = value.IsInt16();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        #endregion

        #region IsInt32

        [TestMethod]
        public void IsInt32_ReturnsFalse_ForNullString()
        {
            // Arrange
            const String value = null;
            const Boolean expectedValue = false;

            // Act
            var result = value.IsInt32();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsInt32_ReturnsFalse_ForEmptyString()
        {
            // Arrange
            const String value = "";
            const Boolean expectedValue = false;

            // Act
            var result = value.IsInt32();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsInt32_ReturnsFalse_ForNonIntegerValue()
        {
            // Arrange
            const String value = "Bacon Rind";
            const Boolean expectedValue = false;

            // Act
            var result = value.IsInt32();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsInt32_ReturnsTrue_ForInt16Value()
        {
            // Arrange
            var value = Int16.MaxValue.ToString(CultureInfo.InvariantCulture);
            const Boolean expectedValue = true;

            // Act
            var result = value.IsInt32();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsInt32_ReturnsTrue_ForInt32Value()
        {
            // Arrange
            var value = Int32.MaxValue.ToString(CultureInfo.InvariantCulture);
            const Boolean expectedValue = true;

            // Act
            var result = value.IsInt32();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsInt32_ReturnsFalse_ForInt64Value()
        {
            // Arrange
            var value = Int64.MaxValue.ToString(CultureInfo.InvariantCulture);
            const Boolean expectedValue = false;

            // Act
            var result = value.IsInt32();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        #endregion

        #region IsInt64

        [TestMethod]
        public void IsInt64_ReturnsFalse_ForNullString()
        {
            // Arrange
            const String value = null;
            const Boolean expectedValue = false;

            // Act
            var result = value.IsInt64();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsInt64_ReturnsFalse_ForEmptyString()
        {
            // Arrange
            const String value = "";
            const Boolean expectedValue = false;

            // Act
            var result = value.IsInt64();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsInt64_ReturnsFalse_ForNonIntegerValue()
        {
            // Arrange
            const String value = "Bacon Rind";
            const Boolean expectedValue = false;

            // Act
            var result = value.IsInt64();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsInt64ReturnsTrue_ForInt16Value()
        {
            // Arrange
            var value = Int16.MaxValue.ToString(CultureInfo.InvariantCulture);
            const Boolean expectedValue = true;

            // Act
            var result = value.IsInt64();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsInt64_ReturnsTrue_ForInt32Value()
        {
            // Arrange
            var value = Int32.MaxValue.ToString(CultureInfo.InvariantCulture);
            const Boolean expectedValue = true;

            // Act
            var result = value.IsInt64();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsInt64_ReturnsTrue_ForInt64Value()
        {
            // Arrange
            var value = Int64.MaxValue.ToString(CultureInfo.InvariantCulture);
            const Boolean expectedValue = true;

            // Act
            var result = value.IsInt64();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        #endregion

        #region IsNullOrEmpty

        [TestMethod]
        public void IsNullOrEmpty_ReturnsTrue_ForNullString()
        {
            // Arrange
            const String value = null;
            const Boolean expectedValue = true;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrEmpty());
        }

        [TestMethod]
        public void IsNullOrEmpty_ReturnsTrue_ForEmptyString()
        {
            // Arrange
            const String value = "";
            const Boolean expectedValue = true;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrEmpty());
        }

        [TestMethod]
        public void IsNullOrEmpty_ReturnsFalse_ForFilledString()
        {
            // Arrange
            const String value = "SomeValue";
            const Boolean expectedValue = false;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrEmpty());
        }

        [TestMethod]
        public void IsNullOrEmpty_ReturnsFalse_ForWhiteSpace()
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
        public void IsNullOrWhiteSpace_ReturnsTrue_ForNullString()
        {
            // Arrange
            const String value = null;
            const Boolean expectedValue = true;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrWhiteSpace());
        }

        [TestMethod]
        public void IsNullOrWhiteSpace_ReturnsTrue_ForEmptyString()
        {
            // Arrange
            const String value = "";
            const Boolean expectedValue = true;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrWhiteSpace());
        }

        [TestMethod]
        public void IsNullOrWhiteSpace_ReturnsFalse_ForFilledString()
        {
            // Arrange
            const String value = "SomeValue";
            const Boolean expectedValue = false;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrWhiteSpace());
        }

        [TestMethod]
        public void IsNullOrWhiteSpace_ReturnsFalse_ForWhiteSpace()
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
        public void IsNullOrEmptyOrWhiteSpace_ReturnsTrue_ForNullString()
        {
            // Arrange
            const String value = null;
            const Boolean expectedValue = true;

            // Act


            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrEmptyOrWhiteSpace());
        }

        [TestMethod]
        public void IsNullOrEmptyOrWhiteSpace_ReturnsTrue_ForEmptyString()
        {
            // Arrange
            const String value = "";
            const Boolean expectedValue = true;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrEmptyOrWhiteSpace());
        }

        [TestMethod]
        public void IsNullOrEmptyOrWhiteSpace_ReturnsFalse_ForFilledString()
        {
            // Arrange
            const String value = "SomeValue";
            const Boolean expectedValue = false;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrEmptyOrWhiteSpace());
        }

        [TestMethod]
        public void IsNullOrEmptyOrWhiteSpace_ReturnsFalse_ForWhiteSpace()
        {
            // Arrange
            const String value = "    ";
            const Boolean expectedValue = true;

            // Act

            //Assert
            Assert.AreEqual(expectedValue, value.IsNullOrEmptyOrWhiteSpace());
        }

        #endregion

        #region IsNumeric

        [TestMethod]
        public void IsNumeric_ReturnsFalse_ForNullString()
        {
            // Arrange
            const String value = null;
            const Boolean expectedValue = false;

            // Act
            var result = value.IsNumeric();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsNumeric_ReturnsFalse_ForEmptyString()
        {
            // Arrange
            const String value = "";
            const Boolean expectedValue = false;

            // Act
            var result = value.IsNumeric();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsNumeric_ReturnsFalse_ForNonNumericString()
        {
            // Arrange
            const String value = "BollyBob";
            const Boolean expectedValue = false;

            // Act
            var result = value.IsNumeric();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsNumeric_ReturnsTrue_ForNumeric()
        {
            // Arrange
            const String value = "1.05";
            const Boolean expectedValue = true;

            // Act
            var result = value.IsNumeric();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsNumeric_ReturnsTrue_ForNegativeNumeric()
        {
            // Arrange
            const String value = "-1.05";
            const Boolean expectedValue = true;

            // Act
            var result = value.IsNumeric();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        #endregion

        #region IsNumericCsv

        [TestMethod]
        public void IsNumericCsv_ReturnsFalse_ForNonCsvString()
        {
            // Arrange
            const String value = "BollyBob";
            const Boolean expectedValue = false;

            // Act
            var result = value.IsNumericCsv();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsNumericCsv_ReturnsFalse_ForNonNumericCsv()
        {
            // Arrange
            const String value = "Dog,Cat,Banana";
            const Boolean expectedValue = false;

            // Act
            var result = value.IsNumericCsv();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsNumericCsv_ReturnsTrue_ForNumericCsv()
        {
            // Arrange
            const String value = "1,2,3,77,919";
            const Boolean expectedValue = true;

            // Act
            var result = value.IsNumericCsv();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsNumericCsv_ReturnsTrue_ForNumericCsvWithSpaces()
        {
            // Arrange
            const String value = "1, 2, 3, 77, 919";
            const Boolean expectedValue = true;

            // Act
            var result = value.IsNumericCsv();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        #endregion

        #region IsValidEmailAddressFormat

        [TestMethod]
        public void IsValidEmailAddressFormat_ReturnsFalse_ForNonValidEmailAddressFormat()
        {
            // Arrange
            const String value = "Billy bob eats locusts";
            const Boolean expectedValue = false;

            // Act
            var result = value.IsValidEmailAddressFormat();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsValidEmailAddressFormat_ReturnsTrue_ForDotComEmailAddress()
        {
            // Arrange
            const String value = "anyone@emailhost.com";
            const Boolean expectedValue = true;

            // Act
            var result = value.IsValidEmailAddressFormat();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void IsValidEmailAddressFormat_ReturnsTrue_ForDotCoDotUkEmailAddress()
        {
            // Arrange
            const String value = "anyone@emailhost.co.uk";
            const Boolean expectedValue = true;

            // Act
            var result = value.IsValidEmailAddressFormat();

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        #endregion
    }
}