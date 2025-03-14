
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<InSameLaneQuery>))]
[GeneratesDataTemplate]
public partial class InSameLaneQuery : Query
{
    [ObservableProperty]
    [JsonProperty(Path = ["OriginEntityType"])]
    [DataTemplateField(Name = "Origin Entity", Tooltip = "This checks adjacency relatively to this entity.")]
    public partial OriginEntityType OriginEntity { get; set; }
}
