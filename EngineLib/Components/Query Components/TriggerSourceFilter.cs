
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<TriggerSourceFilter>))]
public partial class TriggerSourceFilter : QueryOnlyComponent
{
    [ObservableProperty]
    [JsonProperty(Path = ["Query"])]
    public override partial Query Query { get; set; } = new AlwaysMatchesQuery();

    partial void OnQueryChanged(Query value)
    {
        value?.WhenAnyPropertyChanged().Subscribe(p => OnPropertyChanged(nameof(Query)));
    }
}
