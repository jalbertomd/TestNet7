using FluentAssertions;
using NSubstitute;
using TestNet7.Datetime;
using TimeInTests2;
using Xunit;

namespace TimeInTests.Tests.Unit
{
    public class GreeterServiceTest
    {
        private readonly GreeterService _service;
        private readonly IDatetimeProvider _dateTimeProvider = Substitute.For<IDatetimeProvider>();
        public GreeterServiceTest()
        {
            _service = new GreeterService(_dateTimeProvider);
        }

        [Fact]
        public void GenerateGreetText_ShouldReturnGoodAfternoon_WhenItsAfternoon()
        {
            // Arrange
            //var sut = new GreeterService();
            _dateTimeProvider.Now.Returns(new DateTimeOffset(2022, 1, 1, 15, 0, 0, TimeSpan.Zero));

            // Act
            var message = _service.GenerateGreetText();
            // Assert
            message.Should().Be("Good afternoon");
        }

        [Fact]
        public void GenerateGreetText_ShouldReturnGoodMorning_WhenItsMorning()
        {
            // Arrange
            //var sut = new GreeterService();
            _dateTimeProvider.Now.Returns(new DateTimeOffset(2022, 1, 1, 10, 0, 0, TimeSpan.Zero));

            // Act
            var message = _service.GenerateGreetText();
            // Assert
            message.Should().Be("Good morning");
        }

        [Fact]
        public void GenerateGreetText_ShouldReturnGoodEvening_WhenItsEvening()
        {
            // Arrange
            //var sut = new GreeterService();
            _dateTimeProvider.Now.Returns(new DateTimeOffset(2022, 1, 1, 20, 0, 0, TimeSpan.Zero));

            // Act
            var message = _service.GenerateGreetText();
            // Assert
            message.Should().Be("Good evening");
        }
    }
}