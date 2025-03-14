
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<CreateCardEffectDescriptor>))]
[GeneratesDataTemplate]
public partial class CreateCardEffectDescriptor : EffectDescriptor
{
    [ObservableProperty]
    [JsonProperty(Path = ["CardGuid"])]
    [DataTemplateField(Name = "Card GUID", Tooltip = "Card GUID (number on the left)")]
    public partial uint CardGuid { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["ForceFaceDown"])]
    [DataTemplateField(Name = "Force Gravestone", Tooltip = "'ForceFaceDown'. Does not work for plants.")]
    public partial bool ForceFaceDown { get; set; } = false;
}
