
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<PlayerInfoCondition>))]
[GeneratesDataTemplate]
public class PlayerInfoCondition : Component
{
    [JsonProperty(Path = ["Faction"])]
    [DataTemplateField(Name = "Faction", Tooltip = "")]
    public Faction Faction { get; set; } = Faction.Plants;

    [JsonProperty(Path = ["Query"])]
    [DataTemplateField(Name = "Query", Tooltip = "")]
    public Query Query { get; set; } = new AlwaysMatchesQuery();
}
