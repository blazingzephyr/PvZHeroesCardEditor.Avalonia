
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<CardGuidQuery>))]
public partial class CardGuidQuery : SingleIntegerQuery
{
    [ObservableProperty]
    [JsonProperty(Path = ["Guid"])]
    public override partial uint Value { get; set; }
}
