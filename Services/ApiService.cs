public class ApiService
{
    private readonly IConfiguration _configuration;

    public ApiService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string? ApiKey => _configuration["ApiKey"];
    public string? EndpointUrl => _configuration["Endpoint"];
}