
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<Player>))]
public class Player : Component
{

}
