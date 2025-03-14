
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<DamageTrigger>))]
public class DamageTrigger : Trigger
{

}
