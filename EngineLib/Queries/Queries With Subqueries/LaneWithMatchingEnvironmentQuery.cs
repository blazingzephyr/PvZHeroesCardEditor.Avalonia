
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<LaneWithMatchingEnvironmentQuery>))]
public class LaneWithMatchingEnvironmentQuery : QueryWithSubquery
{

}
