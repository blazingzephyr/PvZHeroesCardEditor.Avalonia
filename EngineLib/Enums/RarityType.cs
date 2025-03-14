
using CommunityToolkit.Mvvm.ComponentModel;

namespace PvZCards.Engine;

public enum RarityType : byte
{
    [JsonStringEnumMemberName("R0")]
    Common = 4,

    [JsonStringEnumMemberName("R1")]
    Uncommon = 0,

    [JsonStringEnumMemberName("R2")]
    Rare = 1,

    [JsonStringEnumMemberName("R3")]
    SuperRare = 2,

    [JsonStringEnumMemberName("R4")]
    Legendary = 3,

    [JsonStringEnumMemberName("Event")]
    Event = 5
}
