
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<Unhealable>))]
public class Unhealable : GrantableAbility
{

}
