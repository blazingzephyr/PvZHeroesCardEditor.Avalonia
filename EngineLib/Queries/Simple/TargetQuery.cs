
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<TargetQuery>))]
public class TargetQuery : Query
{

}
