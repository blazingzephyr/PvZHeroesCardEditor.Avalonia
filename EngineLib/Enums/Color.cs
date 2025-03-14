
namespace PvZCards.Engine;

[Flags]
public enum Color : ushort
{
    [JsonStringEnumMemberName("0")]
    None = 0,

    Kabloom = 1,
    MegaGro = 2,
    Guardian = 4,
    Smarty = 8,
    Solar = 16,
    Brainy = 32,
    Hearty = 64,
    Sneaky = 128,
    Hungry = 256,
    Madcap = 512
}
