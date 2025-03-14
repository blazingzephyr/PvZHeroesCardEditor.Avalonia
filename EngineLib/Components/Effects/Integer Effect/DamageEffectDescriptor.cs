
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<DamageEffectDescriptor>))]
public partial class DamageEffectDescriptor : IntegerEffectDescriptor
{
    [ObservableProperty]
    [JsonProperty(Path = ["DamageAmount"])]
    public override partial int Value { get; set; }
}
