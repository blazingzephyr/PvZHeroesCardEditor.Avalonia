
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<SingleIntegerComponent>))]
[GeneratesDataTemplate]
public abstract class SingleIntegerComponent : Component
{
    [DataTemplateField(Name = "Value")]
    public abstract uint Value { get; set; }
}
