using task16;

namespace task16Tests
{
    [TestFixture]
    public class QuaternionTests
    {
        private const double Epsilon = 1e-13;

        [Test]
        public void Constructor_SetsFieldsCorrectly()
        {
            var q = new Quaternion(1, 2, 3, 4);
            Assert.That(q.A, Is.EqualTo(1).Within(Epsilon));
            Assert.That(q.B, Is.EqualTo(2).Within(Epsilon));
            Assert.That(q.C, Is.EqualTo(3).Within(Epsilon));
            Assert.That(q.D, Is.EqualTo(4).Within(Epsilon));
        }

        [Test]
        public void Abs_CalculatesMagnitudeCorrectly()
        {
            var q = new Quaternion(1, 2, 3, 4);
            Assert.That(q.Abs, Is.EqualTo(Math.Sqrt(1 * 1 + 2 * 2 + 3 * 3 + 4 * 4)).Within(Epsilon));
        }

        [Test]
        public void ToString_ReturnsCorrectStringRepresentation()
        {
            var q = new Quaternion(1, 2, 3, 4);
            Assert.That(q.ToString(), Is.EqualTo("1+2i+3j+4k"));

            var zero = new Quaternion(0, 0, 0, 0);
            Assert.That(zero.ToString(), Is.EqualTo("0"));

            var realOnly = new Quaternion(5, 0, 0, 0);
            Assert.That(realOnly.ToString(), Is.EqualTo("5"));
        }

        [Test]
        public void Equals_CompareQuaternionsCorrectly()
        {
            var q1 = new Quaternion(1, 2, 3, 4);
            var q2 = new Quaternion(1, 2, 3, 4);
            var q3 = new Quaternion(1, 2, 3, 5);

            Assert.That(q1.Equals(q2), Is.True);
            Assert.That(q1.Equals(q3), Is.False);
        }

        [Test]
        public void GetHashCode_EqualsForEqualQuaternions()
        {
            var q1 = new Quaternion(1, 2, 3, 4);
            var q2 = new Quaternion(1, 2, 3, 4);

            Assert.That(q1.GetHashCode(), Is.EqualTo(q2.GetHashCode()));
        }

        [Test]
        public void Addition_OperatesCorrectly()
        {
            var q1 = new Quaternion(1, 2, 3, 4);
            var q2 = new Quaternion(5, 6, 7, 8);

            var result = q1 + q2;
            Assert.That(result.A, Is.EqualTo(6).Within(Epsilon));
            Assert.That(result.B, Is.EqualTo(8).Within(Epsilon));
            Assert.That(result.C, Is.EqualTo(10).Within(Epsilon));
            Assert.That(result.D, Is.EqualTo(12).Within(Epsilon));
        }

        [Test]
        public void Subtraction_OperatesCorrectly()
        {
            var q1 = new Quaternion(1, 2, 3, 4);
            var q2 = new Quaternion(5, 6, 7, 8);

            var result = q1 - q2;
            Assert.That(result.A, Is.EqualTo(-4).Within(Epsilon));
            Assert.That(result.B, Is.EqualTo(-4).Within(Epsilon));
            Assert.That(result.C, Is.EqualTo(-4).Within(Epsilon));
            Assert.That(result.D, Is.EqualTo(-4).Within(Epsilon));
        }

        [Test]
        public void Multiplication_OperatesCorrectly()
        {
            var q1 = new Quaternion(1, 2, 3, 4);
            var q2 = new Quaternion(5, 6, 7, 8);

            var result = q1 * q2;

            Assert.That(result.A, Is.EqualTo(-60).Within(Epsilon));
            Assert.That(result.B, Is.EqualTo(12).Within(Epsilon));   
            Assert.That(result.C, Is.EqualTo(30).Within(Epsilon));
            Assert.That(result.D, Is.EqualTo(24).Within(Epsilon));
        }
    }
}