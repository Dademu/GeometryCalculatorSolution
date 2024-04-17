using GeometryCalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryCalculatorTests;

[TestClass]

public class TriangleTests
{
    [TestMethod]
    public void TestArea()
    {
        // Arrange
        var triangle = new Triangle { Base = 6, Height = 4 };

        // Act
        var result = triangle.CalculateArea();

        // Assert
        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(12, result);
    }

    [TestMethod]
    public void TestPerimeter()
    {
        // Arrange
        var triangle = new Triangle { Base = 6 };

        // Act
        var result = triangle.CalculatePerimeter();

        // Assert
        Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(18, result);
    }
}
