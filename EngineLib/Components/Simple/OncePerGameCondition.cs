
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<OncePerGameCondition>))]
public class OncePerGameCondition : Component
{

}
