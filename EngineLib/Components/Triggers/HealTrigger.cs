
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<HealTrigger>))]
public class HealTrigger : Trigger
{

}
