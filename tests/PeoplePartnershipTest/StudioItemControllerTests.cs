using AutoFixture;
using Moq;
using FluentAssertions;
using PeoplePartnershipTest.Interfaces;
using PeoplePartnershipTest.Controllers;
using PeoplePartnershipTest.DTOs;
using PeoplePartnershipTest.Library;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PeoplePartnershipTest.Data;

namespace PeoplePartnershipTest.Tests
{
    public class StudioItemControllerTests
    {
        private readonly IFixture _fixture;
        private readonly Mock<IInterfaceWithDatabase> _serviceMock;
        private readonly StudioItemController _sut;
        public StudioItemControllerTests()
        {
            _fixture = new Fixture() { OmitAutoProperties = true };
            _serviceMock = _fixture.Freeze<Mock<IInterfaceWithDatabase>>();
            _sut = new StudioItemController(_serviceMock.Object);
        }
        [Fact]
        public async Task GetStudioItemById_ShouldReturnOkResponce_WhenDataFound()
        {
            //Arrange
            var studioItemMock = _fixture.Create<ServiceResponse<GetStudioItemDto>>();
            var studioItemID = 10;
            
            _serviceMock.Setup(x => x.GetStudioItemById(studioItemID)).ReturnsAsync(studioItemMock);

            //Act
            var result = await _sut.GetById(studioItemID).ConfigureAwait(false);
            //var expected = studioItemID.ToString();

            //Assert
           Assert.NotNull(result);
           //Assert.IsAssignableFrom<ServiceResponse<GetStudioItemDto>>(result);
           
        }
    }
}