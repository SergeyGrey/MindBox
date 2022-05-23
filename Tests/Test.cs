using Forms;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void TestTriangleNormalArguments()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.GetArea() - 6, Is.LessThan(Double.Epsilon));

            // on subsequent calls, returns the value from that field
            Assert.That(triangle.GetArea() - 6, Is.LessThan(Double.Epsilon));
        }

        [Test]
        public void TestIsTriangleRight()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.IsRightTriangle(), Is.True);
        }

        [Test]
        public void TestTriangleArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(3, 4, 100));
        }
    }

    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void TestCircleNormalArguments()
        {
            var circle = new Circle(2);
            Assert.That(circle.GetArea() - Math.PI * 4, Is.LessThan(Double.Epsilon));
        }

        [Test]
        public void TestCircleArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-3));
        }
    }

    [TestFixture]
    public class FigureTests
    {
        [Test]
        public void TestPolymorphism()
        {
            List<Figure> list = new List<Figure>();

            list.Add(new Triangle(3, 4, 5));
            list.Add(new Triangle(5, 12, 13));
            list.Add(new Circle(2));

            double sumOfAreas = list.Sum(figure => figure.GetArea());

            Assert.That(sumOfAreas - (Math.PI * 4 + 36), Is.LessThan(Double.Epsilon));
        }
    }
}