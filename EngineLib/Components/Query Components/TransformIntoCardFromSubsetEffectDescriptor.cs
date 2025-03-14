
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<TransformIntoCardFromSubsetEffectDescriptor>))]
public partial class TransformIntoCardFromSubsetEffectDescriptor : QueryOnlyComponent
{
    [ObservableProperty]
    [JsonProperty(Path = ["SubsetQuery"])]
    public override partial Query Query { get; set; } = new AlwaysMatchesQuery();

    partial void OnQueryChanged(Query value)
    {
        value?.WhenAnyPropertyChanged().Subscribe(p => OnPropertyChanged(nameof(Query)));
    }
}
