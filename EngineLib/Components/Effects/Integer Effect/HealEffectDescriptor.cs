
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<HealEffectDescriptor>))]
public partial class HealEffectDescriptor : IntegerEffectDescriptor
{
    [ObservableProperty]
    [JsonProperty(Path = ["HealAmount"])]
    public override partial int Value { get; set; }
}
