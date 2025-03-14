
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<Component>))]
[GeneratesDataTemplate]
public class Component : ObservableRecipient
{

}
