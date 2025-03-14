
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<IsActiveQuery>))]
public class IsActiveQuery : Query
{

}
