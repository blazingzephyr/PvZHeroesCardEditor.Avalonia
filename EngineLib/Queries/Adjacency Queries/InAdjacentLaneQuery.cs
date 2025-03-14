
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<InAdjacentLaneQuery>))]
public class InAdjacentLaneQuery : AdjacencyQuery
{

}
