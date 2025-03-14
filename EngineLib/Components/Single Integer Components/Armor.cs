
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<Armor>))]
public partial class Armor : SingleIntegerComponent
{
    [ObservableProperty]
    [JsonProperty(Path = ["ArmorAmount", "BaseValue"])]
    public override partial uint Value { get; set; }
}
