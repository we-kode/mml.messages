namespace Messages.Events;

/// <summary>
/// Events fires, when a client has changed.
/// </summary>
/// <param name="clientId">The client id, that has changed.</param>
public class ClientStateUpdated(string clientId)
{
    /// <summary>
    /// Client id.
    /// </summary>
    public string ClientId { get; set; } = clientId;

}
