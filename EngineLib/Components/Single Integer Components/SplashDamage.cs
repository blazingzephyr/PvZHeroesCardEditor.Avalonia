
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<SplashDamage>))]
public partial class SplashDamage : SingleIntegerComponent
{
    [ObservableProperty]
    [JsonProperty(Path = ["DamageAmount"])]
    public override partial uint Value { get; set; }
}
