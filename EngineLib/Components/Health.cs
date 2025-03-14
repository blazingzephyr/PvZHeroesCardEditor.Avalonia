
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<Health>))]
public class Health : Component
{
    [JsonProperty(Path = ["MaxHealth", "BaseValue"])]
    public uint MaxHealth { get; set; } = 0;

    [JsonProperty(Path = ["CurrentDamage"], IgnoredIfNull = true, IsRequired = false)]
    public uint? CurrentDamage { get; set; } = null;
}
