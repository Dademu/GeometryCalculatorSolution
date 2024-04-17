using GeometryCalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryCalculatorTests;
[TestClass]
public class RectangleTests
{
    [TestMethod]
    public void TestArea()
    {
        // Arrange
        var rectangle = new Rectangle { Length = 5, Width = 3 };

        // Act
        var result = rectangle.CalculateArea();

        // Assert
        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(15, result);
    }

    [TestMethod]
    public void TestPerimeter()
    {
        // Arrange
        var rectangle = new Rectangle { Length = 5, Width = 3 };

        // Act
        var result = rectangle.CalculatePerimeter();

        // Assert
        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(16, result);
    }
}
