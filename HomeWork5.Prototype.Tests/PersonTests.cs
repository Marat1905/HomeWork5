using HomeWork5.Prototype.Implementations;
using System;
using System.Text.Json;

namespace HomeWork5.Prototype.Tests
{
    
    public class PersonTests
    {
        [Fact]
        public void MyCloneableTest_MustReturnPersonWithEqualFields()
        {
            // Arrange
            var person = new Person("Maks", 20);
            var clone = person.MyClone();

            // Act

            // Assert
            Assert.Equal(JsonSerializer.Serialize(person), JsonSerializer.Serialize(clone));
        }

        [Fact]
        public void CloneableTest_MustReturnPersonWithEqualFields()
        {
            // Arrange
            var person = new Person("Maks", 20);
            var clone = (Person)person.Clone();

            // Act

            // Assert
            Assert.Equal(JsonSerializer.Serialize(person), JsonSerializer.Serialize(clone));
        }

        [Fact]
        public void DeepCloneableTest_MustReturnPersonWithEqualFields()
        {
            // Arrange
            var person = new Person("Maks", 20);
            var clone = person.DeepCopy();

            // Act

            // Assert
            Assert.Equal(JsonSerializer.Serialize(person), JsonSerializer.Serialize(clone));
        }
    }
}
