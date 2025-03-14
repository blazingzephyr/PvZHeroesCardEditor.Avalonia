
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<GrantableAbilityCounter>))]
[NoTypeAnnotation]
public partial class GrantableAbilityCounter : Component
{
    [ObservableProperty]
    [JsonProperty(Path = ["SourceId"])]
    public partial int SourceID { get; set; } = -1;

    [ObservableProperty]
    [JsonProperty(Path = ["Duration"])]
    public partial uint Duration { get; set; } = 0;

    [ObservableProperty]
    [JsonProperty(Path = ["Value"])]
    public partial int Value { get; set; } = 0;
}

[JsonConverter(typeof(ComponentConverter<GrantableAbility>))]
public partial class GrantableAbility : Component
{
    [ObservableProperty]
    [JsonProperty(Path = ["Counters", "IsPersistent"])]
    public partial bool IsPersistent { get; set; } = true;

    [JsonProperty(Path = ["Counters", "Counters"])]
    public ObservableCollection<GrantableAbilityCounter> Counters { get; set; } = [ new GrantableAbilityCounter() ];
}
