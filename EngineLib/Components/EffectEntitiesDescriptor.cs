

namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<EffectEntity>))]
[NoTypeAnnotation]
public class EffectEntity
{
    [JsonProperty(Path = ["components"])]
    public ObservableCollection<Component> Components { get; set; } = [];
}

[JsonConverter(typeof(ComponentConverter<EffectEntitiesDescriptor>))]
public class EffectEntitiesDescriptor : Component
{
    [JsonProperty(Path = ["entities"])]
    public ObservableCollection<EffectEntity> Entities { get; set; } = [];
}
