
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<GainSunEffectDescriptor>))]
[GeneratesDataTemplate]
public partial class GainSunEffectDescriptor : EffectDescriptor
{
    [ObservableProperty]
    [JsonProperty(Path = ["Amount"])]
    [DataTemplateField(Name = "Amount", Tooltip = "The amount of sun given.")]
    public partial int Amount { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["Duration"])]
    [DataTemplateField(Name = "Duration", Tooltip = "The duration of sun that is given. Usually EndOfTurn, Permanent for Solar Flare super and Cryobrain.")]
    public partial Duration Duration { get; set; } = Duration.EndOfTurn;

    [ObservableProperty]
    [JsonProperty(Path = ["ActivationTime"])]
    [DataTemplateField(Name = "Activation Time", Tooltip = "Whether the sun is given immediately or next turn.")]
    public partial ActivationTime ActivationTime { get; set; } = ActivationTime.Immediate;
}
