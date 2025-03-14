
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<GrantedTriggeredAbility>))]
[NoTypeAnnotation]
[GeneratesDataTemplate]
public partial class GrantedTriggeredAbility : ObservableRecipient
{
    [JsonProperty(Path = ["g"])]
    [ObservableProperty]
    [DataTemplateField(Name = "Guid")]
    public partial uint Guid { get; set; } = 0;

    [JsonProperty(Path = ["vt"])]
    [ObservableProperty]
    [DataTemplateField(Name = "ValueType")]
    public partial uint ValueType { get; set; } = 0;

    [JsonProperty(Path = ["va"])]
    [ObservableProperty]
    [DataTemplateField(Name = "ValueAmount")]
    public partial uint ValueAmount { get; set; } = 0;
}

[JsonConverter(typeof(ComponentConverter<GrantedTriggeredAbilities>))]
public class GrantedTriggeredAbilities : Component
{
    [JsonProperty(Path = ["a"])]
    public ObservableCollection<GrantedTriggeredAbility> Abilities { get; set; } = [];
}
