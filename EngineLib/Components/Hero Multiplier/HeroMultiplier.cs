
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<DrawnCardCostMultiplier>))]
[GeneratesDataTemplate]
public partial class HeroMultiplier : Component
{
    [ObservableProperty]
    [JsonProperty(Path = ["Faction"])]
    [DataTemplateField(Name = "Faction", Tooltip = "This multiplier uses a stat of a hero.")]
    public partial Faction Faction { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["Divider"])]
    [DataTemplateField(Name = "Divider", Tooltip = "The selected hero stat will be divided by this amount.")]
    public partial int Divider { get; set; }
}
