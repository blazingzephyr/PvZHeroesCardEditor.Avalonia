
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<TargetAttackOrHealthMultiplier>))]
public class TargetAttackOrHealthMultiplier : MultiplierComponent
{

}
