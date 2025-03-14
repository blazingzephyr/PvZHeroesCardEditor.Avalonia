
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<TargetHealthMultiplier>))]
public class TargetHealthMultiplier : MultiplierComponent
{

}
