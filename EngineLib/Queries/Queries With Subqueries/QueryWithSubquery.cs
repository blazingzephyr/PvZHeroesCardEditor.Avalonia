
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<QueryWithSubquery>))]
[GeneratesDataTemplate]
public partial class QueryWithSubquery : Query
{
    [ObservableProperty]
    [JsonProperty(Path = ["Query"])]
    [DataTemplateField(Name = "Subquery", Tooltip = "Checks whether the target of this query also satisfies this filter.")]
    public partial Query Query { get; set; } = new AlwaysMatchesQuery();
}
