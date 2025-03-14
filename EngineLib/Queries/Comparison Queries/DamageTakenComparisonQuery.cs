
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<DamageTakenComparisonQuery>))]
public partial class DamageTakenComparisonQuery : ComparisonQuery
{
    [ObservableProperty]
    [JsonProperty(Path = ["DamageTakenValue"])]
    public override partial int Value { get; set; }
}
