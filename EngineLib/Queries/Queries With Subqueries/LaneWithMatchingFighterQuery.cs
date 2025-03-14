
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<LaneWithMatchingFighterQuery>))]
public class LaneWithMatchingFighterQuery : QueryWithSubquery
{

}
