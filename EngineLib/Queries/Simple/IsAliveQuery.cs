
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<IsAliveQuery>))]
public class IsAliveQuery : Query
{


}
