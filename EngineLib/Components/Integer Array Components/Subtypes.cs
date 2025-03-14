
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<Subtypes>))]
public class Subtypes : IntegerArrayComponent
{
    [JsonProperty(Path = ["subtypes"])]
    public override ObservableCollection<uint> Values { get; set; } = [];
}
