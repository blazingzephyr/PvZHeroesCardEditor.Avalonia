
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<Continuous>))]
public class Continuous : Trigger
{

}
