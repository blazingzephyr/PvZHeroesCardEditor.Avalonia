
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<TrickQuery>))]
public class TrickQuery : Query
{

}
