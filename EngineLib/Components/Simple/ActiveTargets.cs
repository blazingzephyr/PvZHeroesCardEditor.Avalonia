
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<ActiveTargets>))]
public class ActiveTargets : Component
{

}
