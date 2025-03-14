
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<SelfQuery>))]
public class SelfQuery : Query
{

}
