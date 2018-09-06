using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Hl7.Fhir.Rest.Http.R4;
using Xunit;
using Hl7.Fhir.Model.R4;
using Task = System.Threading.Tasks.Task;

namespace Hl7.Fhir.Server.Tests
{
    public class FhirServerIntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public FhirServerIntegrationTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }
        [Fact]
        public async Task Test1()
        {
            _factory.CreateClient();
            var handler = _factory.Server.CreateHandler();

            var fhirClient = new FhirClient("http://localhost", messageHandler: handler);

            // Act
            var response = await fhirClient.ReadAsync<Patient>("Patient/1");
        }
    }
}
