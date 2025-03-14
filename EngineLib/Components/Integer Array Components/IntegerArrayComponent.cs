
namespace PvZCards.Engine;

[GeneratesDataTemplate]
public abstract class IntegerArrayComponent : Component
{
    [JsonProperty(Path = ["Values"])]
    [DataTemplateField(Name = "Values", Tooltip = "IDK")]
    public abstract ObservableCollection<uint> Values { get; set; }
}
