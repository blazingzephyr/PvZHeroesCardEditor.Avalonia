
namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<OpenLaneQuery>))]
[GeneratesDataTemplate]
public partial class OpenLaneQuery : Query
{
    [ObservableProperty]
    [JsonProperty(Path = ["PlayerFactionType"])]
    [DataTemplateField(Name = "Player Faction", Tooltip = "Whether the lane is opened for a certain faction.")]
    public partial PlayerFaction PlayerFactionType { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["IsForTeamupCard"])]
    [DataTemplateField(Name = "Is For Teamup Card", Tooltip = "Whether the lane is open for a Team-Up card.")]
    public partial bool IsForTeamupCard { get; set; }
}
