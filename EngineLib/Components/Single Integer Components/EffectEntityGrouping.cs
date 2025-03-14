
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<EffectEntityGrouping>))]
public partial class EffectEntityGrouping : SingleIntegerComponent
{
    [ObservableProperty]
    [JsonProperty(Path = ["AbilityGroupId"])]
    public override partial uint Value { get; set; }
}
