
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<QueryMultiplier>))]
[GeneratesDataTemplate]
public partial class QueryMultiplier : MultiplierComponent
{
    [ObservableProperty]
    [JsonProperty(Path = ["Query"])]
    [DataTemplateField(Name = "Query", Tooltip = "Multiplies the value of this ability by the number of entities which fit the query.")]
    public partial Query Query { get; set; } = new AlwaysMatchesQuery();
}
