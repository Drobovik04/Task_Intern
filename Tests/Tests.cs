using Lib;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void CircleAreaTestRadius5()
        {
            Circle circle = new Circle(5);
            Assert.That(Math.PI * 25 == circle.GetArea());
        }
        [Test]
        public void CircleAreaTestRadius1()
        {
            Circle circle = new Circle(1);
            Assert.That(Math.PI * 1 == circle.GetArea());
        }
        [Test]
        public void TriangleAreaTest1()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.That(6 == triangle.GetArea());
        }
        [Test]
        public void TriangleAreaTest2()
        {
            Triangle triangle = new Triangle(8, 4, 5);
            Assert.That(8.181534085976786 == triangle.GetArea());
        }
        [Test]
        public void RightAngleTriangleTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.IsRectangularTriangle());
        }
    }
}