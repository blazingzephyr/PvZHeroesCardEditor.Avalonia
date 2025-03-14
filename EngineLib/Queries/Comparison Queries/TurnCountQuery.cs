
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<TurnCountQuery>))]
public partial class TurnCountQuery : ComparisonQuery
{
    [ObservableProperty]
    [JsonProperty(Path = ["TurnCount"])]
    public override partial int Value { get; set; }
}
