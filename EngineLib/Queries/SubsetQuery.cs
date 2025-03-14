
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<SubsetQuery>))]
[GeneratesDataTemplate]
public partial class SubsetQuery : Query
{
    [ObservableProperty]
    [JsonProperty(Path = ["Subset"])]
    [DataTemplateField(Name = "Subset", Tooltip = "Whether a card fits this subset/tribe?")]
    public partial string Subset { get; set; } = string.Empty;
}
