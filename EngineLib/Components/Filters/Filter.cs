
using DynamicData.Binding;

namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<Filter>))]
[GeneratesDataTemplate]
public partial class Filter : Component
{
    [ObservableProperty]
    [JsonProperty(Path = ["SelectionType"])]
    [DataTemplateField(Name = "Selection Type", Tooltip = "How to select the target(s).")]
    public partial SelectionType SelectionType { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["NumTargets"])]
    [DataTemplateField(Name = "Number", Tooltip = "Number of targets selected.")]
    public partial uint NumTargets { get; set; } = 0;

    [ObservableProperty]
    [JsonProperty(Path = ["TargetScopeType"])]
    [DataTemplateField(Name = "Scope Type", Tooltip = "Whether the targets are sorted or not.")]
    public partial TargetScopeType TargetScopeType { get; set; } = TargetScopeType.All;

    [ObservableProperty]
    [JsonProperty(Path = ["TargetScopeSortValue"])]
    [DataTemplateField(Name = "Scope Sort Value", Tooltip = "Which stat to use for sorting.")]
    public partial TargetScopeSortValueType TargetScopeSortValue { get; set; } = TargetScopeSortValueType.None;

    [ObservableProperty]
    [JsonProperty(Path = ["TargetScopeSortMethod"])]
    [DataTemplateField(Name = "Scope Sort Method", Tooltip = "How to sort the targets.")]
    public partial TargetScopeSortMethodType TargetScopeSortMethod { get; set; } = TargetScopeSortMethodType.None;

    [ObservableProperty]
    [JsonProperty(Path = ["AdditionalTargetType"])]
    [DataTemplateField(Name = "Additional Target Type", Tooltip = "Whether additional targets should be selected or not.")]
    public partial AdditionalTargetType AdditionalTargetType { get; set; } = AdditionalTargetType.None;

    [ObservableProperty]
    [JsonProperty(Path = ["AdditionalTargetQuery"], IsRequired = false)]
    [DataTemplateField(Name = "Additional Target Query", Tooltip = "Used for selecting the additional targets.")]
    public partial Query? AdditionalTargetQuery { get; set; } = null;

    [ObservableProperty]
    [JsonProperty(Path = ["OnlyApplyEffectsOnAdditionalTargets"])]
    [DataTemplateField(Name = "Only Apply Effects On Additional Targets")]
    public partial bool OnlyApplyEffectsOnAdditionalTargets { get; set; } = false;

    [ObservableProperty]
    [JsonProperty(Path = ["Query"])]
    [DataTemplateField(Name = "Target Query", Tooltip = "Used for selecting the base targets.")]
    public partial Query Query { get; set; } = new AlwaysMatchesQuery();

    partial void OnAdditionalTargetQueryChanged(Query? value)
    {
        value?.WhenAnyPropertyChanged().Subscribe(p => OnPropertyChanged(nameof(AdditionalTargetQuery)));
    }

    partial void OnQueryChanged(Query value)
    {
        value?.WhenAnyPropertyChanged().Subscribe(p => OnPropertyChanged(nameof(Query)));
    }
}
