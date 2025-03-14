
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<AttackInLaneEffectDescriptor>))]
public partial class AttackInLaneEffectDescriptor : IntegerEffectDescriptor
{
    [ObservableProperty]
    [JsonProperty(Path = ["DamageAmount"])]
    public override partial int Value { get; set; }
}
