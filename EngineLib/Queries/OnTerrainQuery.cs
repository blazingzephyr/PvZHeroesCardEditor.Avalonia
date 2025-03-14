
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<OnTerrainQuery>))]
[GeneratesDataTemplate]
public partial class OnTerrainQuery : Query
{
    [ObservableProperty]
    [JsonProperty(Path = ["TerrainType"])]
    [DataTemplateField(Name = "Terrain Type", Tooltip = "Whether the entity is on terrain(?)")]
    public partial TerrainType TerrainType { get; set; }
}
