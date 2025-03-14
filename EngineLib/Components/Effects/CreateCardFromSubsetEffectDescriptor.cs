
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<CreateCardFromSubsetEffectDescriptor>))]
[GeneratesDataTemplate]
public partial class CreateCardFromSubsetEffectDescriptor : EffectDescriptor
{
    [ObservableProperty]
    [JsonProperty(Path = ["ForceFaceDown"])]
    [DataTemplateField(Name = "Force Gravestone", Tooltip = "'ForceFaceDown'. Does not work for plants.")]
    public partial bool ForceFaceDown { get; set; } = false;

    [ObservableProperty]
    [JsonProperty(Path = ["SubsetQuery"])]
    [DataTemplateField(Name = "SubsetQuery", Tooltip = "Query that filters the subsets.")]
    public partial Query SubsetQuery { get; set; } = new AlwaysMatchesQuery();
}
