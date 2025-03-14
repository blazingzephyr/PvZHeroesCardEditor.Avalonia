
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<AttacksOnlyInAdjacentLanes>))]
public class AttacksOnlyInAdjacentLanes : Component
{

}
