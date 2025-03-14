
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<NotQuery>))]
public class NotQuery : QueryWithSubquery
{

}
