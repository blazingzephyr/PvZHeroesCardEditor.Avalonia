
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<PlayTrigger>))]
public class PlayTrigger : Trigger
{

}
