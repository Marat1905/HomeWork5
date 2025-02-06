using HomeWork5.Prototype.Implementations;
using System.Text.Json;

namespace HomeWork5.Prototype.Tests
{
    public class UserTests
    {
        [Fact]
        public void MyCloneableTest_MustReturnUserWithEqualFields()
        {
            // Arrange
            IdInfo info = new IdInfo(1, "Паспорт");
            var user = new User("Tom", 20,info);
            var clone = user.MyClone();

            // Act

            // Assert
            Assert.Multiple(() =>
            {
                Assert.False(user.Equals(clone));
                Assert.True(user.Id.Equals(clone.Id));
                Assert.Equal(JsonSerializer.Serialize(user), JsonSerializer.Serialize(clone));
            });

        }

        [Fact]
        public void CloneableTest_MustReturnUserWithEqualFields()
        {
            IdInfo info = new IdInfo(1, "Паспорт");
            // Arrange
            var user = new User("Tom", 20, info);
            var clone = (User)user.Clone();

            // Act

            // Assert
            Assert.Multiple(() =>
            {
                Assert.False(user.Equals(clone));
                Assert.True(user.Id.Equals(clone.Id));
                Assert.Equal(JsonSerializer.Serialize(user), JsonSerializer.Serialize(clone));
            });

        }

        [Fact]
        public void DeepCloneableTest_MustReturnUserWithEqualFields()
        {
            IdInfo info = new IdInfo(1, "Паспорт");
            // Arrange
            var user = new User("Tom", 20, info);
            var clone = user.DeepCopy();

            // Act

            // Assert
            Assert.Multiple(() =>
            {
                Assert.False(user.Equals(clone));
                Assert.NotEqual(clone.Id, user.Id);
                Assert.Equal(JsonSerializer.Serialize(user), JsonSerializer.Serialize(clone));
            });

        }

        [Fact]
        public void MyCloneableTest_MustReturnUserWithDifferentReferencesToFields()
        {
            // Arrange
            IdInfo info = new IdInfo(1, "Паспорт");
            var user = new User("Tom", 20, info);
            var clone = user.MyClone();

            // Act
            clone.Name = "Sam";
            clone.Age = 22;

            user.Id.IdNumber = 2;
            user.Id.Type = "Загран";

            // Assert
            Assert.Multiple(() =>
            {
                Assert.False(user.Equals(clone));
                Assert.Equal(user.Id, clone.Id);
                Assert.NotEqual(JsonSerializer.Serialize(user), JsonSerializer.Serialize(clone));
            });
        }

        [Fact]
        public void CloneableTest_MustReturnUserWithDifferentReferencesToFields()
        {
            // Arrange
            IdInfo info = new IdInfo(1, "Паспорт");
            var user = new User("Tom", 20, info);
            var clone = (User)user.Clone();

            // Act
            clone.Name = "Sam";
            clone.Age = 22;

            user.Id.IdNumber = 2;
            user.Id.Type = "Загран";

            // Assert
            Assert.Multiple(() =>
            {
                Assert.False(user.Equals(clone));
                Assert.Equal(user.Id, clone.Id);
                Assert.NotEqual(JsonSerializer.Serialize(user), JsonSerializer.Serialize(clone));
            });
        }

        [Fact]
        public void DeepCloneableTest_MustReturnUserWithDifferentReferencesToFields()
        {
            // Arrange
            IdInfo info = new IdInfo(1, "Паспорт");
            var user = new User("Tom", 20, info);
            var clone = user.DeepCopy();

            // Act
            clone.Name = "Sam";
            clone.Age = 22;
            //IdInfo info2 = new IdInfo(2, "Загран");
            user.Id.IdNumber = 2;
            user.Id.Type = "Загран"; 

            // Assert
            Assert.Multiple(() =>
            {
                Assert.False(user.Equals(clone));
                Assert.NotEqual(user.Id, clone.Id);
                Assert.NotEqual(JsonSerializer.Serialize(user), JsonSerializer.Serialize(clone));
            });
        }
    }
}
