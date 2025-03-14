
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<CombatEndTrigger>))]
public class CombatEndTrigger : Trigger
{

}
