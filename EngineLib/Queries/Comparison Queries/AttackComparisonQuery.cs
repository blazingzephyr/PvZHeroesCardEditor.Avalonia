
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<AttackComparisonQuery>))]
public partial class AttackComparisonQuery : ComparisonQuery
{
    [ObservableProperty]
    [JsonProperty(Path = ["AttackValue"])]
    public override partial int Value { get; set; }
}
