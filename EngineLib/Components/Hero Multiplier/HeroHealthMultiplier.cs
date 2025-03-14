
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<HeroHealthMultiplier>))]
public class HeroHealthMultiplier : HeroMultiplier
{

}
