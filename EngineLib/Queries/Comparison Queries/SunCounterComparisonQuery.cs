
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<SunCounterComparisonQuery>))]
public partial class SunCounterComparisonQuery : ComparisonQuery
{
    [ObservableProperty]
    [JsonProperty(Path = ["SunCounterValue"])]
    public override partial int Value { get; set; }
}
