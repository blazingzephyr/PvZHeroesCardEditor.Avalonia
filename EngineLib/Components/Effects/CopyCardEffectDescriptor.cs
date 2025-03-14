
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<CopyCardEffectDescriptor>))]
[GeneratesDataTemplate]
public partial class CopyCardEffectDescriptor : EffectDescriptor
{
    [ObservableProperty]
    [JsonProperty(Path = ["GrantTeamup"])]
    [DataTemplateField(Name = "Grant Teamup", Tooltip = "Grants teamup to the copied plant.")]
    public partial bool GrantTeamup { get; set; } = false;

    [ObservableProperty]
    [JsonProperty(Path = ["ForceFaceDown"])]
    [DataTemplateField(Name = "Force Gravestone", Tooltip = "'ForceFaceDown'. Does not work for plants.")]
    public partial bool ForceFaceDown { get; set; } = false;

    [ObservableProperty]
    [JsonProperty(Path = ["CreateInFront"])]
    [DataTemplateField(Name = "Create In Front", Tooltip = "Creates a new card in front of the source.")]
    public partial bool CreateInFront { get; set; } = true;
}
