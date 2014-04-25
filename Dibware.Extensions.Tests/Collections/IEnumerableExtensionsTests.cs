using Dibware.Extensions.System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Dibware.Extensions.Tests.Collections
{
    /// <summary>
    /// Tests extensions to the IEnumerable class
    /// </summary>
    [TestClass]
    public class IEnumerableExtensionsTests
    {
        #region ForEach

        [TestMethod]
        public void Test_ForEach_PerformActionOnListUsingForEach_ResultsIn_TheActionBeingPerformed()
        {
            // Arrange
            IEnumerable<String> list =
                new List<String>() { "One", "Two", "Three" };
            var result = String.Empty;

            // Act
            // Create an action that concatenates each item in 
            // the list using commas.  A Trailing comma will be present.
            Action<String> action = s => result = String.Format("{0}{1},", result, s);

            // Perform the action on the list using the ForEach we are testing
            list.ForEach(action);

            // Remove the last comma
            result = result.TrimEnd(',');

            // Assert
            Assert.AreEqual("One,Two,Three", result);
        }

        #endregion

        #region AppendAll

        [TestMethod]
        public void Test_AppendAll_WithNoSeperator_ResultsIn_ConcatenatedStringReturned()
        {
            // Arrange
            const String item1 = "One";
            const String item2 = "Two";
            const String item3 = "Three";
            String expectedResult = String.Concat(item1, item2, item3);

            IEnumerable<String> list =
                new List<String>() { item1, item2, item3 };

            // Act
            var result = list.AppendAll();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_AppendAll_WithCommaSeperator_ResultsIn_CommaSeperatedListReturned()
        {
            // Arrange
            const String item1 = "One";
            const String item2 = "Two";
            const String item3 = "Three";
            const String seperator = ",";
            String expectedResult = String.Concat(item1, seperator, item2, seperator, item3);

            IEnumerable<String> list =
                new List<String>() { item1, item2, item3 };

            // Act
            var result = list.AppendAll(seperator);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        #endregion
    }
}
