
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<SingleIntegerQuery>))]
[GeneratesDataTemplate]
public abstract class SingleIntegerQuery : Query
{
    [DataTemplateField(Name = "Value")]
    public abstract uint Value { get; set; }
}
