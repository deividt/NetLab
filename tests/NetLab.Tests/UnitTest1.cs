using FluentAssertions;
using NetLab.Library;

namespace NetLab.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var sut = new Class1();

        // Act
        var result = sut.HelloWorld();

        // Assert
        result.Should().Be("Hello World");
    }
}