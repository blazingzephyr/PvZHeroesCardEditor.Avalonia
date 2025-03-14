
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<AttackOverride>))]
public class AttackOverride : GrantableAbility
{

}
