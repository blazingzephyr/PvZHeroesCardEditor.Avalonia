
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<PrimaryTargetFilter>))]
public class PrimaryTargetFilter : Filter
{

}
