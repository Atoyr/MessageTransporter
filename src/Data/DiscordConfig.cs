using Medoz.MessageTransporter.Clients;

namespace Medoz.MessageTransporter.Data;

/// <summary>
/// </summary>
public record DiscordConfig(ulong? DefaultChannelId, bool UseSpeaker, uint? Speaker)
{
}