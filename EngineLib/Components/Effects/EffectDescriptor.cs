
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<EffectDescriptor>))]
public class EffectDescriptor : Component
{

}
