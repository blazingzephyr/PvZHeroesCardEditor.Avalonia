
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<AdjacencyQuery>))]
[GeneratesDataTemplate]
public partial class AdjacencyQuery : Query
{
    [ObservableProperty]
    [JsonProperty(Path = ["Side"])]
    [DataTemplateField(Name = "Side", Tooltip = "Side which to check the adjecency of the target.")]
    public partial Side Side { get; set; }
}
