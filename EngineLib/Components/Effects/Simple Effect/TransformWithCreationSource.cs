
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<TransformWithCreationSource>))]
public partial class TransformWithCreationSource : EffectDescriptor
{
    [ObservableProperty]
    [JsonProperty(Path = ["SourceGuid"])]
    public partial int Value { get; set; } = -1;
}
