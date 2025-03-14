
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<ChargeBlockMeterEffectDescriptor>))]
public partial class ChargeBlockMeterEffectDescriptor : IntegerEffectDescriptor
{
    [ObservableProperty]
    [JsonProperty(Path = ["ChargeAmount"])]
    public override partial int Value { get; set; }
}
