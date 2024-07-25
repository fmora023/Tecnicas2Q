using Quiz2;

namespace Quiz2Test
{
    /// <summary>
    /// Test class for each of the algorithms of <see cref="Algorithms"/>.
    /// Here we are using AAA pattern => Arrange, Act, Assert.
    /// </summary>
    [TestClass]
    public class AlgorithmsTest
    {
        /// <summary>
        /// Tests the sum algorithm.
        /// </summary>
        [TestMethod]
        public void TestSumAlgorithm()
        {
            // Arrange
            var x = 5;
            var y = 10;

            // Act
            var result = Algorithms.Sum(x, y);

            // Assert
            Assert.AreEqual(15, result);
        }

        /// <summary>
        /// Tests the div algorithm.
        /// </summary>
        [TestMethod]
        public void TestDivAlgorithm()
        {
            // Arrange
            var x = 10;
            var y = 4;

            // Act
            var result = Algorithms.Div(x, y);

            // Assert
            Assert.AreEqual(2, result);
        }

        /// <summary>
        /// Tests the div algorithm with zero.
        /// </summary>
        [TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        public void TestDivAlgorithmWithZero()
        {
            // Arrange
            var x = 70;
            var y = 0;

            // Act
            Assert.ThrowsException<ArgumentException>(() => Algorithms.Div(x, y));
            //var result = Algorithms.Div(x, y);

            // Assert
            //Assert.AreEqual(0, result);
        }
        
    }
}