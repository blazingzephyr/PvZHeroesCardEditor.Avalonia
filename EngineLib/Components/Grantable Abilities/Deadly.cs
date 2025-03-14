
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<Deadly>))]
public class Deadly : GrantableAbility
{

}
