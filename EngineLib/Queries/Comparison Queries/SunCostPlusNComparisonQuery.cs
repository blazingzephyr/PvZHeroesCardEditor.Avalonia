
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<SunCostPlusNComparisonQuery>))]
public partial class SunCostPlusNComparisonQuery : ComparisonQuery
{
    [ObservableProperty]
    [JsonProperty(Path = ["AdditionalCost"])]
    public override partial int Value { get; set; }
}
