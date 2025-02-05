using HomeWork5.Prototype.Implementations;
using System.Text.Json;

namespace HomeWork5.Prototype.Tests
{

    public class PersonTests
    {
        [Fact]
        public void MyCloneableTest_MustReturnPersonWithEqualFields()
        {
            // Arrange
            var person = new Person("Tom", 20);
            var clone = person.MyClone();

            // Act

            // Assert
            Assert.Multiple(() =>
            {
                Assert.False(person.Equals(clone));
                Assert.Equal(JsonSerializer.Serialize(person), JsonSerializer.Serialize(clone));
            });
            
        }

        [Fact]
        public void CloneableTest_MustReturnPersonWithEqualFields()
        {
            // Arrange
            var person = new Person("Tom", 20);
            var clone = (Person)person.Clone();

            // Act

            // Assert
            Assert.Multiple(() =>
            {
                Assert.False(person.Equals(clone));
                Assert.Equal(JsonSerializer.Serialize(person), JsonSerializer.Serialize(clone));
            });

        }

        [Fact]
        public void DeepCloneableTest_MustReturnPersonWithEqualFields()
        {
            // Arrange
            var person = new Person("Tom", 20);
            var clone = person.DeepCopy();

            // Act

            // Assert
            Assert.Multiple(() =>
            {
                Assert.False(person.Equals(clone));
                Assert.Equal(JsonSerializer.Serialize(person), JsonSerializer.Serialize(clone));
            });
        }

        [Fact]
        public void MyCloneableTest_MustReturnPersonWithDifferentReferencesToFields()
        {
            // Arrange
            var person = new Person("Tom", 20);
            var clone = person.MyClone();

            // Act
            clone.Name = "Sam";
            clone.Age = 22;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.False(person.Equals(clone));
                Assert.NotEqual(JsonSerializer.Serialize(person), JsonSerializer.Serialize(clone));
            });
        }

        [Fact]
        public void CloneableTest_MustReturnPersonWithDifferentReferencesToFields()
        {
            // Arrange
            var person = new Person("Tom", 20);
            var clone = (Person)person.Clone();

            // Act
            clone.Name = "Sam";
            clone.Age = 22;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.False(person.Equals(clone));
                Assert.NotEqual(JsonSerializer.Serialize(person), JsonSerializer.Serialize(clone));
            });
        }

        [Fact]
        public void DeepCloneableTest_MustReturnPersonWithDifferentReferencesToFields()
        {
            // Arrange
            var person = new Person("Tom", 20);
            var clone = person.DeepCopy();

            // Act
            clone.Name = "Sam";
            clone.Age = 22;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.False(person.Equals(clone));
                Assert.NotEqual(JsonSerializer.Serialize(person), JsonSerializer.Serialize(clone));
            });
        }
    }
}
