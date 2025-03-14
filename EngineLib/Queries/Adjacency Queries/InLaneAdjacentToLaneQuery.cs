
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<InLaneAdjacentToLaneQuery>))]
public class InLaneAdjacentToLaneQuery : AdjacencyQuery
{

}
