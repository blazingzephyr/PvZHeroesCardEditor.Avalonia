
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<SameFactionQuery>))]
public class SameFactionQuery : Query
{

}
