using csharp_fundamentals_arrays.Main;
using NUnit.Framework;

namespace csharp_fundamentals_arrays.Test
{
    public class ExerciseTest
    {
        Exercise exercise;

        public ExerciseTest()
        {
            this.exercise = new Exercise();
        }

        [Test]
        public void shouldChange17To68()
        {
            Assert.AreEqual(68, this.exercise.one()[2]);
        }

        [Test]
        public void shouldBeCarlo()
        {
            Assert.AreEqual("Carlo", this.exercise.two());
        }

        [Test]
        public void shouldContainCarManufacturers()
        {
            String[] cars = this.exercise.three();
            Assert.AreEqual(3, cars.Length);
            Assert.AreEqual("Audi", cars[0]);
            Assert.AreEqual("BMW", cars[1]);
            Assert.AreEqual("Dodge", cars[2]);
        }

        [Test]
        public void shouldBe163()
        {
            Assert.AreEqual(163, this.exercise.four());
        }

        [Test]
        public void fiveShouldBeArrayOfFloats()
        {
            float[] floats = this.exercise.five();
            Assert.AreEqual(3, floats.Length);
            Assert.AreEqual(9.62f, floats[0]);
            Assert.AreEqual(23.17f, floats[1]);
            Assert.AreEqual(3.14f, floats[2]);
        }
    }
}