using HomeWork5.Prototype.Implementations;
using System.Text.Json;

namespace HomeWork5.Prototype.Tests
{
    public class StudentTest
    {
        [Fact]
        public void MyCloneableTest_MustReturnStudentWithEqualFields()
        {
            // Arrange
            var student = new Student("Tom", 20, 1);
            var clone = student.MyClone();

            // Act

            // Assert
            Assert.Multiple(() =>
            {
                Assert.False(student.Equals(clone));
                Assert.Equal(JsonSerializer.Serialize(student), JsonSerializer.Serialize(clone));
            });

        }

        [Fact]
        public void CloneableTest_MustReturnStudentWithEqualFields()
        {
            // Arrange
            var student = new Student("Tom", 20, 1);
            var clone = student.Clone();

            // Act

            // Assert
            Assert.Multiple(() =>
            {
                Assert.False(student.Equals(clone));
                Assert.Equal(JsonSerializer.Serialize(student), JsonSerializer.Serialize(clone));
            });

        }

        [Fact]
        public void DeepCloneableTest_MustReturnStudentWithEqualFields()
        {
            // Arrange
            var student = new Student("Tom", 20, 1);
            var clone = student.DeepCopy();

            // Act

            // Assert
            Assert.Multiple(() =>
            {
                Assert.False(student.Equals(clone));
                Assert.Equal(JsonSerializer.Serialize(student), JsonSerializer.Serialize(clone));
            });

        }

        [Fact]
        public void MyCloneableTest_MustReturnStudentWithDifferentReferencesToFields()
        {
            // Arrange
            var student = new Student("Tom", 20, 1);
            var clone = student.MyClone();

            // Act
            clone.Name = "Sam";
            clone.Age = 22;
            clone.Course = 2;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.False(student.Equals(clone));
                Assert.NotEqual(JsonSerializer.Serialize(student), JsonSerializer.Serialize(clone));
            });
        }

        [Fact]
        public void CloneableTest_MustReturnStudentWithDifferentReferencesToFields()
        {
            // Arrange
            var student = new Student("Tom", 20, 1);
            var clone = (Student)student.Clone();

            // Act
            clone.Name = "Sam";
            clone.Age = 22;
            clone.Course = 2;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.False(student.Equals(clone));
                Assert.NotEqual(JsonSerializer.Serialize(student), JsonSerializer.Serialize(clone));
            });
        }

        [Fact]
        public void DeepCloneableTest_MustReturnStudentWithDifferentReferencesToFields()
        {
            // Arrange
            var student = new Student("Tom", 20, 1);
            var clone = student.DeepCopy();

            // Act
            clone.Name = "Sam";
            clone.Age = 22;
            clone.Course = 2;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.False(student.Equals(clone));
                Assert.NotEqual(JsonSerializer.Serialize(student), JsonSerializer.Serialize(clone));
            });
        }
    }
}
