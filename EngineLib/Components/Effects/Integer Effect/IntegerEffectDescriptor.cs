
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<IntegerEffectDescriptor>))]
[GeneratesDataTemplate]
public abstract class IntegerEffectDescriptor : EffectDescriptor
{
    [DataTemplateField(Name = "Value")]
    public abstract int Value { get; set; }
}
