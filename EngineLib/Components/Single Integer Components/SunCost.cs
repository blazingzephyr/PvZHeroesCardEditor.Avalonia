
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<SunCost>))]
public partial class SunCost : SingleIntegerComponent
{
    [ObservableProperty]
    [JsonProperty(Path = ["SunCostValue", "BaseValue"])]
    public override partial uint Value { get; set; }
}
