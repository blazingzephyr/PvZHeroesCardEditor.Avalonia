


namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<HeraldEntities>))]
public class HeraldEntities : IntegerArrayComponent
{
    [JsonProperty(Path = ["ids"])]
    public override ObservableCollection<uint> Values { get; set; } = [];
}
