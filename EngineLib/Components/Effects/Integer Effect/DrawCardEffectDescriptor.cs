
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<DrawCardEffectDescriptor>))]
public partial class DrawCardEffectDescriptor : IntegerEffectDescriptor
{
    [ObservableProperty]
    [JsonProperty(Path = ["DrawAmount"])]
    public override partial int Value { get; set; }
}
