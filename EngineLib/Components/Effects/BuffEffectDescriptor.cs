
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<BuffEffectDescriptor>))]
[GeneratesDataTemplate]
public partial class BuffEffectDescriptor : EffectDescriptor
{
    [ObservableProperty]
    [JsonProperty(Path = ["AttackAmount"])]
    [DataTemplateField(Name = "Attack", Tooltip = "Buff the target by X attack.")]
    public partial int Attack { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["HealthAmount"])]
    [DataTemplateField(Name = "Health", Tooltip = "Buff the target by X attack.")]
    public partial int Health { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["BuffDuration"])]
    [DataTemplateField(Name = "Duration", Tooltip = "Duration of the applied buff.")]
    public partial Duration Duration { get; set; }
}
