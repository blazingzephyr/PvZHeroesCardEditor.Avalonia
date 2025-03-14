
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<SlowedTrigger>))]
public class SlowedTrigger : Trigger
{

}
