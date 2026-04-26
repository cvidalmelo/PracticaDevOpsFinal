using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using Xunit;

namespace WebApplication1.Tests;

public class UnitTest1 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public UnitTest1(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task Inicio_DebeRetornar_HolaMundo()
    {
        var client = _factory.CreateClient();

        var response = await client.GetAsync("/");
        var contenido = await response.Content.ReadAsStringAsync();

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Contains("Hola", contenido);
    }
}