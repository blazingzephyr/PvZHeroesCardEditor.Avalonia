
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<HasComponentQuery>))]
public class HasComponentQuery : ComponentQuery
{

}
