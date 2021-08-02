using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsItALeapYear;
//using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Year_2001_Is_not_a_leap_year()
        {
            // Arrange
            var p = new Program();
            var expected = false;
            // Act
            var actual = p.IsItALeapYear(2001);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Year_1996_Is_a_leap_year()
        {
            // Arrange
            var p = new Program();
            var expected = true;
            // Act
            var actual = p.IsItALeapYear(1996);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Year_1900_is_not_a_leap_year()
        {
            // Arrange
            var p = new Program();
            var expected = false;
            // Act
            var actual = p.IsItALeapYear(1900);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Year_2000_is_a_leap_year()
        {
            // Arrange
            var p = new Program();
            var expected = true;
            // Act
            var actual = p.IsItALeapYear(2000);
            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
