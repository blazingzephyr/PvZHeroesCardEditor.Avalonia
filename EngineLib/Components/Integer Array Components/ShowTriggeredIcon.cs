
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<ShowTriggeredIcon>))]
public class ShowTriggeredIcon : IntegerArrayComponent
{
    [JsonProperty(Path = ["abilities"])]
    public override ObservableCollection<uint> Values { get; set; } = [];
}
