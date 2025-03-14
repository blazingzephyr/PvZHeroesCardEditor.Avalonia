
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<Card>))]
public partial class Card : SingleIntegerComponent
{
    [ObservableProperty]
    [JsonProperty(Path = ["Guid"])]
    public override partial uint Value { get; set; }
}
