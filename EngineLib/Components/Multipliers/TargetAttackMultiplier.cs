
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<TargetAttackMultiplier>))]
public class TargetAttackMultiplier : MultiplierComponent
{

}
