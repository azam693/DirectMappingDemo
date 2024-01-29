using CommunityToolkit.Diagnostics;

namespace DirectMappingDemo.Application.Common;

public sealed class Correlation
{
    public string CorrelationId { get; private set; }
    public string RequestId { get; private set; }
    public int UserId { get; private set; }

    public Correlation(
        string correlationId,
        string requestId,
        string userIdText)
    {
        Guard.IsNotNullOrWhiteSpace(correlationId);
        Guard.IsNotNullOrWhiteSpace(requestId);
        Guard.IsNotNullOrWhiteSpace(userIdText);

        if (!int.TryParse(userIdText, out var userId))
        {
            throw new ArgumentException($"{nameof(userIdText)} should contain int value");
        }

        CorrelationId = correlationId;
        RequestId = requestId;
        UserId = userId;
    }
}
