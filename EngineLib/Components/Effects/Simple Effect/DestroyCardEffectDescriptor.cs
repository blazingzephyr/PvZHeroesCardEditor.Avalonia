
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<DestroyCardEffectDescriptor>))]
public class DestroyCardEffectDescriptor : EffectDescriptor
{

}
