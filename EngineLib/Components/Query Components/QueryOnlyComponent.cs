
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<QueryOnlyComponent>))]
[GeneratesDataTemplate]
public abstract class QueryOnlyComponent : Component
{
    [DataTemplateField(Name = "Query", Tooltip = "Filters the data.")]
    public abstract Query Query { get; set; }    
}
