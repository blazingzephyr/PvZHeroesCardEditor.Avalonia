
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<DestroyCardTrigger>))]
public class DestroyCardTrigger : Trigger
{

}
