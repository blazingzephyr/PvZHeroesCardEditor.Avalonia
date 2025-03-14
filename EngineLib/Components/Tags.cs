
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<Tags>))]
public class Tags : Component
{
    [JsonProperty(Path = ["tags"])]
    public ObservableCollection<string> CardTags { get; set; } = [];
}
