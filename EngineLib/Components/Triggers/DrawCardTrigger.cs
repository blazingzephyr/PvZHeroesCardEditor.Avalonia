
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<DrawCardTrigger>))]
public class DrawCardTrigger : Trigger
{

}
