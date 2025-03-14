
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<Strikethrough>))]
public class Strikethrough : GrantableAbility
{

}
