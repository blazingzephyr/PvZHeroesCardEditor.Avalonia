
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<OncePerTurnCondition>))]
public class OncePerTurnCondition : Component
{

}
