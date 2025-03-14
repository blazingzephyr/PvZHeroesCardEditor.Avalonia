
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<QueryEntityCondition>))]
[GeneratesDataTemplate]
public class QueryEntityCondition : Component
{
    [JsonProperty(Path = ["Finder"])]
    [DataTemplateField(Name = "Finder", Tooltip = "Presumably sorts out the entities.")]
    public Query Finder { get; set; } = new AlwaysMatchesQuery();

    [JsonProperty(Path = ["ConditionEvaluationType"])]
    [DataTemplateField(Name = "Condition Evaluation Type", Tooltip = "Whether All or Any should fit the condition.")]
    public ConditionEvaluationType ConditionEvaluationType { get; set; }

    [JsonProperty(Path = ["Query"])]
    [DataTemplateField(Name = "Query", Tooltip = "Queries the entities to see whether any/all fit the condition.")]
    public Query Query { get; set; } = new AlwaysMatchesQuery();
}
