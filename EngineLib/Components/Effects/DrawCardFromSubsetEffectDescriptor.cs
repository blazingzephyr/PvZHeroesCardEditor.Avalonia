
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<DrawCardFromSubsetEffectDescriptor>))]
[GeneratesDataTemplate]
public partial class DrawCardFromSubsetEffectDescriptor : EffectDescriptor
{
    [ObservableProperty]
    [JsonProperty(Path = ["SubsetQuery"])]
    [DataTemplateField(Name = "Subset Query", Tooltip = "Filters the cards that will be drawn.")]
    public partial Query SubsetQuery { get; set; } = new AlwaysMatchesQuery();

    [ObservableProperty]
    [JsonProperty(Path = ["DrawAmount"])]
    [DataTemplateField(Name = "Draw Amount", Tooltip = "The amount of cards that should be drawn.")]
    public partial uint DrawAmount { get; set; } = 1;
}
