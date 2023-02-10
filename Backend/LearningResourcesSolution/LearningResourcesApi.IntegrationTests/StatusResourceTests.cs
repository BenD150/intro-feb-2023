namespace LearningResourcesApi.IntegrationTests;

public class StatusResourceTests
{
    [Fact]
    public async Task TheStatusResource()
    {
        await using var host = await AlbaHost.For<Program>();

        await host.Scenario(api => // Integration test - usually has many steps
        {
            api.Get.Url("/status");
            api.StatusCodeShouldBeOk(); // 200 status code
        });
    }
}
