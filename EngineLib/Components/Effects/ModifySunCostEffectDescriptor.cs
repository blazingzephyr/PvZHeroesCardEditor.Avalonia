
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<ModifySunCostEffectDescriptor>))]
[GeneratesDataTemplate]
public partial class ModifySunCostEffectDescriptor : EffectDescriptor
{
    [ObservableProperty]
    [JsonProperty(Path = ["SunCostAmount"])]
    [DataTemplateField(Name = "Amount", Tooltip = "The sun cost diff to apply.")]
    public partial int SunCostAmount { get; set; } = -1;

    [ObservableProperty]
    [JsonProperty(Path = ["BuffDuration"])]
    [DataTemplateField(Name = "Buff Duration", Tooltip = "The duration of sun modification buff.")]
    public partial Duration BuffDuration { get; set; } = Duration.EndOfTurn;
}
