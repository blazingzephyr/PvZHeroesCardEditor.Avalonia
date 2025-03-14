


using DynamicData.Binding;

namespace PvZCards.Engine.Queries;

[JsonConverter(typeof(ComponentConverter<CompositeQuery>))]
[GeneratesDataTemplate]
public partial class CompositeQuery : Query
{
    [ObservableProperty]
    [JsonProperty(Path = ["queries"])]
    [DataTemplateField(Name = "Subqueries", Tooltip = "Queries evaluated together.")]
    public partial ObservableCollection<Query> Subqueries { get; set; } = [];

    public CompositeQuery()
    {
        foreach (var item in Subqueries)
        {
            item.WhenAnyPropertyChanged().Subscribe(p => OnPropertyChanged(nameof(Subqueries)));
        }
    }

    public void CollectionChanged(Query? query = null)
    {
        query?.WhenAnyPropertyChanged().Subscribe(p => OnPropertyChanged(nameof(Subqueries)));
        OnPropertyChanged(nameof(Subqueries));
    }
}
