
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<Rarity>))]
public partial class Rarity : Component
{
    [JsonProperty(Path = ["Value"])]
    public RarityType Value { get; set; }
}
