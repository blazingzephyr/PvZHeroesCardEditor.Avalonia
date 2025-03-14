
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<ExtraAttackEffectDescriptor>))]
public class ExtraAttackEffectDescriptor : EffectDescriptor
{

}
