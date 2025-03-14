
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<MultiplierComponent>))]
[GeneratesDataTemplate]
public partial class MultiplierComponent : Component
{
    [ObservableProperty]
    [JsonProperty(Path = ["Divider"])]
    [DataTemplateField(Name = "Divider", Tooltip = "Divide the value of this multiplier by X.")]
    public partial int Divider { get; set; }
}
