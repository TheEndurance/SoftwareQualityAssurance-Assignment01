using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Assignment01.tests
{
    [TestFixture]
    public class RectangleUnitTests
    {
        [Test]
        public void Rectangle_SetLengthTo5_ReturnsLength5()
        {
            //arrange
            Rectangle rectangle = new Rectangle();
            int expectedLength = 5;
            //act
            rectangle.SetLength(expectedLength);
            //assert
            Assert.AreEqual(rectangle.GetLength(), expectedLength);
        }

        [Test]
        public void Rectangle_GetLength_ReturnsLength15()
        {
            //arrange
            Rectangle rectangle = new Rectangle(15, 5);
            int expectedLength = 15;
            //assert
            Assert.AreEqual(rectangle.GetLength(), expectedLength);
        }

        [Test]
        public void Rectangle_GetWidth_ReturnsWidth15()
        {
            //arrange
            Rectangle rectangle = new Rectangle(5, 15);
            int expectedWidth = 15;
            //assert
            Assert.AreEqual(rectangle.GetWidth(), expectedWidth);
        }

        [Test]
        public void Rectangle_SetWidthTo5_ReturnsWidth5()
        {
            //arrange
            Rectangle rectangle = new Rectangle();
            int expectedWidth = 5;
            //act
            rectangle.SetWidth(expectedWidth);
            //assert
            Assert.AreEqual(rectangle.GetWidth(),expectedWidth);
        }

        [Test]
        public void Rectangle_GetPerimeterOf5x10_ReturnsPerimeter30()
        {
            //arrange
            Rectangle rectangle = new Rectangle(5, 10);
            int expectedPerimeter = 30;
            //act
            int perimeter = rectangle.GetPerimeter();
            //assert
            Assert.AreEqual(perimeter,expectedPerimeter);
        }

        [Test]
        public void Rectangle_GetAreaOf5x10_ReturnsArea50()
        {
            //arrange
            Rectangle rectangle = new Rectangle(5, 10);
            int expectedArea = 50;
            //act
            int area = rectangle.GetArea();
            //assert
            Assert.AreEqual(area, expectedArea);
        }
    }
}
