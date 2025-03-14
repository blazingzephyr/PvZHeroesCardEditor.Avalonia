
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<GrantAbilityEffectDescriptor>))]
[GeneratesDataTemplate]
public partial class GrantAbilityEffectDescriptor : EffectDescriptor
{
    [ObservableProperty]
    [JsonProperty(Path = ["GrantableAbilityType"])]
    [DataTemplateField(Name = "Type", Tooltip = "Which ability to grant to the target.")]
    public partial Engine.GrantableAbility AbilityType { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["Duration"])]
    [DataTemplateField(Name = "Duration", Tooltip = "Duration of the ability.")]
    public partial Duration Duration { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["AbilityValue"])]
    [DataTemplateField(Name = "Ability Value", Tooltip = "0 for most abilities, different for some others.")]
    public partial uint Value { get; set; } = 0;
}
