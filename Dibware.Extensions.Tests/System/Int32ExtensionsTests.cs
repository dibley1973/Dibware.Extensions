using Dibware.Extensions.System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dibware.Extensions.Tests.System
{
    /// <summary>
    /// Tests extensions to the System.Int32 class
    /// </summary>
    [TestClass]
    public class Int32ExtensionsTests
    {
        #region Clamp

        [TestMethod]
        public void Clamp_ReturnsIntegerDataType_WhenCalled()
        {
            const int min = 5;
            const int value = 10;
            const int max = 20;

            // ACT
            var actual = value.Clamp(min, max);

            // ASSERT
            Assert.IsInstanceOfType(actual, typeof(int));
        }

        [TestMethod]
        public void Clamp_ReturnsMax_WhenGivenValueGreaterThanMax()
        {
            // ARRANGE
            const int min = 5;
            const int value = 30;
            const int max = 20;

            // ACT
            var actual = value.Clamp(min, max);

            // ASSERT
            Assert.AreEqual(max, actual);
        }

        [TestMethod]
        public void Clamp_ReturnsMin_WhenGivenValueLessThanMin()
        {
            // ARRANGE
            const int min = 5;
            const int value = 2;
            const int max = 20;

            // ACT
            var actual = value.Clamp(min, max);

            // ASSERT
            Assert.AreEqual(min, actual);
        }

        [TestMethod]
        public void Clamp_ReturnsValue_WhenGivenValueBetweenMinAndMax()
        {
            // ARRANGE
            const int min = 5;
            const int value = 10;
            const int max = 20;

            // ACT
            var actual = value.Clamp(min, max);

            // ASSERT
            Assert.AreEqual(value, actual);
        }

        #endregion
    }
}
