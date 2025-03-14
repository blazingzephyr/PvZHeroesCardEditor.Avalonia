
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<SameLaneAsTargetQuery>))]
public class SameLaneAsTargetQuery : Query
{

}
