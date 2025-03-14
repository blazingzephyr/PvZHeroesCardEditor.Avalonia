
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<SetStatEffectDescriptor>))]
[GeneratesDataTemplate]
public partial class SetStatEffectDescriptor : EffectDescriptor
{
    [ObservableProperty]
    [JsonProperty(Path = ["StatType"])]
    [DataTemplateField(Name = "Stat Type", Tooltip = "Which stat to change.")]
    public partial StatType StatType { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["Value"])]
    [DataTemplateField(Name = "Amount", Tooltip = "Value of the effect.")]
    public partial uint Value { get; set; } = 0;

    [ObservableProperty]
    [JsonProperty(Path = ["ModifyOperation"])]
    [DataTemplateField(Name = "Operation", Tooltip = "Which stat setting operation to apply.")]
    public partial ModifyOperation ModifyOperation { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["StripNoncontinousModifiers"])]
    [DataTemplateField(Name = "Strip Non-Continous Modifiers", Tooltip = "Removes all buffs.")]
    public partial bool StripNoncontinousModifiers { get; set; } = false;
}
