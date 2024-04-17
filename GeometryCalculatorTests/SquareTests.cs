using GeometryCalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryCalculatorTests;
[TestClass]
public class SquareTests
{
    [TestMethod]
    public void TestArea()
    {
        // Arrange
        var square = new Square { Length = 5 };

        // Act
        var result = square.CalculateArea();

        // Assert
        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void TestPerimeter()
    {
        // Arrange
        var square = new Square { Length = 5 };

        // Act
        var result = square.CalculatePerimeter();

        // Assert
        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(20, result);
    }
}







