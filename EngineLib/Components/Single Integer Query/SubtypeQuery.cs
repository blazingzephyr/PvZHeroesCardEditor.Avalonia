
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<SubtypeQuery>))]
public partial class SubtypeQuery : SingleIntegerQuery
{
    [ObservableProperty]
    [JsonProperty(Path = ["Subtype"])]
    public override partial uint Value { get; set; }
}
