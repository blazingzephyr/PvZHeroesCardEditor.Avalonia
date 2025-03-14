
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<TriggerTargetFilter>))]
public partial class TriggerTargetFilter : QueryOnlyComponent
{
    [ObservableProperty]
    [JsonProperty(Path = ["Query"])]
    public override partial Query Query { get; set; } = new AlwaysMatchesQuery();

    partial void OnQueryChanged(Query value)
    {
        value?.WhenAnyPropertyChanged().Subscribe(p => OnPropertyChanged(nameof(Query)));
    }
}
