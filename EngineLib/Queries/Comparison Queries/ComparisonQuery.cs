
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<ComparisonQuery>))]
[GeneratesDataTemplate]
public abstract partial class ComparisonQuery : Query
{
    [ObservableProperty]
    [JsonProperty(Path = ["ComparisonOperator"])]
    [DataTemplateField(Name = "Operator", Tooltip = "Which comparison operation will be used.")]
    public partial ComparisonOperator Operator { get; set; }

    [DataTemplateField(Name = "Value", Tooltip = "This should be more/less/equal to this value.")]
    public abstract int Value { get; set; }
}
