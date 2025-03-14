
namespace PvZCards.Engine.Effects;

[JsonConverter(typeof(ComponentConverter<GrantTriggeredAbilityEffectDescriptor>))]
[GeneratesDataTemplate]
public partial class GrantTriggeredAbilityEffectDescriptor : EffectDescriptor
{
    [ObservableProperty]
    [JsonProperty(Path = ["AbilityGuid"])]
    [DataTemplateField(Name = "Ability Guid", Tooltip = "This grants an ability in form of an unusable hidden card.")]
    public partial uint Guid { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["AbilityValueType"])]
    [DataTemplateField(Name = "Value Type", Tooltip = "Which ability to grant to the target.")]
    public partial AbilityValueType ValueType { get; set; } = AbilityValueType.None;

    [ObservableProperty]
    [JsonProperty(Path = ["AbilityValueAmount"])]
    [DataTemplateField(Name = "Ability Value", Tooltip = "0 for most abilities, different for some others.")]
    public partial uint Value { get; set; } = 0;
}
