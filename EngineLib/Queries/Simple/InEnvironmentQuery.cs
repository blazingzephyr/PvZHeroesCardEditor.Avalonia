
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<InEnvironmentQuery>))]
public class InEnvironmentQuery : Query
{

}
