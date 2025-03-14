
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<ComponentQuery>))]
[GeneratesDataTemplate]
public partial class ComponentQuery : Query
{
    [ObservableProperty]
    [JsonProperty(Path = ["ComponentType"])]
    [DataTemplateField(Name = "Component Type", Tooltip = "Checks whether this component is present.")]
    public partial string ComponentType { get; set; } = string.Empty;
}
