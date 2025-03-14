
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<Attack>))]
public partial class Attack : SingleIntegerComponent
{
    [ObservableProperty]
    [JsonProperty(Path = ["AttackValue", "BaseValue"])]
    public override partial uint Value { get; set; }
}
