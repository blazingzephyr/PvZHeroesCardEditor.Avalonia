
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<AdjacentLaneQuery>))]
[GeneratesDataTemplate]
public partial class AdjacentLaneQuery : Query
{
    [ObservableProperty]
    [JsonProperty(Path = ["Side"])]
    [DataTemplateField(Name = "Side", Tooltip = "Side that should be checked for adjacency.")]
    public partial Side Side { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["OriginEntityType"])]
    [DataTemplateField(Name = "Origin Entity", Tooltip = "This checks adjacency relatively to this entity.")]
    public partial OriginEntityType OriginEntity { get; set; }
}
