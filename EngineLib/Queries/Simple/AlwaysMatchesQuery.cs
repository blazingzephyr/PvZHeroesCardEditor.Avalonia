
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<AlwaysMatchesQuery>))]
public class AlwaysMatchesQuery : Query
{

}
