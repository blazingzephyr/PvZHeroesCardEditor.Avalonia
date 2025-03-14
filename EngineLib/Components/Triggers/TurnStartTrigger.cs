
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<TurnStartTrigger>))]
public class TurnStartTrigger : Trigger
{

}
