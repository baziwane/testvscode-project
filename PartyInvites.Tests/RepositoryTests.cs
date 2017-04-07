using System;
using Xunit;
using PartyInvites.Models;

namespace PartyInvites.Tests
{
    public class RepositoryTests{
        [Fact]
        public void CanAddResponseToRepository()
        {
            var guest = new GuestResponse { Name = "Test", Email = "test@test.com", Phone = "1234", WillAttend = true };
            Repository.AddResponse(guest);
            Assert.NotEmpty(Repository.Responses);
        }
    }
}