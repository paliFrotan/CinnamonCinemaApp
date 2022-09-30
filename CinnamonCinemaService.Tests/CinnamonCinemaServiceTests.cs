using FluentAssertions;

namespace CinnamonCinemaService.Tests;


public class Tests
{
    private User _user;
    [SetUp]
    public void Setup()
    {
        _user = new User();
    }

    [Test]
    public void RandomNumberGeneratedbyUser()
    {
        _user.generateRandomInput().Should().Be(1);
        Assert.Pass();
    }
}