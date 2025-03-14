
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<BlockMeterValueQuery>))]
public partial class BlockMeterValueQuery : ComparisonQuery
{
    [ObservableProperty]
    [JsonProperty(Path = ["BlockMeterValue"])]
    public override partial int Value { get; set; }
}
