
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<Untrickable>))]
public class Untrickable : GrantableAbility
{

}
