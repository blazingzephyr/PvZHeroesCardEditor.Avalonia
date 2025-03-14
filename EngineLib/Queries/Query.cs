
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<Query>))]
[GeneratesDataTemplate]
public class Query : ObservableRecipient
{

}
