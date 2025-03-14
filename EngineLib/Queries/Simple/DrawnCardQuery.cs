
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<DrawnCardQuery>))]
public class DrawnCardQuery : Query
{

}
