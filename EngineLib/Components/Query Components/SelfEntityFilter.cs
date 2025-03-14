
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<SelfEntityFilter>))]
public partial class SelfEntityFilter : QueryOnlyComponent
{
    [ObservableProperty]
    [JsonProperty(Path = ["Query"])]
    public override partial Query Query { get; set; } = new AlwaysMatchesQuery();

    partial void OnQueryChanged(Query value)
    {
        value?.WhenAnyPropertyChanged().Subscribe(p => OnPropertyChanged(nameof(Query)));
    }
}
