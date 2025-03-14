
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<KilledByQuery>))]
public class KilledByQuery : QueryWithSubquery
{

}
