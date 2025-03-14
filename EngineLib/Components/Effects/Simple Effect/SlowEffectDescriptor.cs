
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<SlowEffectDescriptor>))]
public class SlowEffectDescriptor : EffectDescriptor
{

}
