
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<LaneOfIndexQuery>))]
public partial class LaneOfIndexQuery : SingleIntegerQuery
{
    [ObservableProperty]
    [JsonProperty(Path = ["LaneIndex"])]
    public override partial uint Value { get; set; }
}
