using ConsoleAppGenericHostWithSample.Interfaces;
using Microsoft.Extensions.Logging;

namespace ConsoleAppGenericHostWithSample.Services;

public class SampleHostedService: ISampleHostedService
{
    private readonly ILogger<SampleHostedService> _logger;

    public SampleHostedService(ILogger<SampleHostedService> logger)
    {
        _logger = logger;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("SampleHostedService started");
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("SampleHostedService stopped");
        return Task.CompletedTask;
    }
}