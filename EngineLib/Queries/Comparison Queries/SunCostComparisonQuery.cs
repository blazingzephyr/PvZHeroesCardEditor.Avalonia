
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<SunCostComparisonQuery>))]
public partial class SunCostComparisonQuery : ComparisonQuery
{
    [ObservableProperty]
    [JsonProperty(Path = ["SunCost"])]
    public override partial int Value { get; set; }
}
