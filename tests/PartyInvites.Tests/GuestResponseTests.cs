using System;
using Xunit;
using PartyInvites.Models;

namespace PartyInvites.Tests
{
    public class GuestResponseTests{
        [Fact]
        public void CanChangeName() {
            // Arrange
            var p = new GuestResponse { Name = "Test", Email = "test@test.com", Phone = "1234", WillAttend = true };
            // Act
            p.Name = "New Name";
            //Assert
            Assert.Equal("New Name", p.Name);
        }

        [Fact]
        public void CanChangeEmail() {
            // Arrange
            var p = new GuestResponse { Name = "Test", Email = "test@test.com", Phone = "1234", WillAttend = true };
            // Act
            p.Email = "tested@test.com";
            //Assert
            Assert.Equal("tested@test.com", p.Email);
        }
        [Fact]
        public void CanChangeAttendance() {
            // Arrange
            var p = new GuestResponse { Name = "Test", Email = "test@test.com", Phone = "1234", WillAttend = true };
            // Act
            p.WillAttend = false;
            //Assert
            Assert.Equal(false, p.WillAttend);
        }
    }
}