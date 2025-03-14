
using System.ComponentModel;
using Component = PvZCards.Engine.Components.Component;

namespace PvZCards.Engine;

[JsonConverter(typeof(ComponentConverter<CardDescriptor>))]
[NoTypeAnnotation]
public partial class CardDescriptor : ObservableRecipient
{
    [ObservableProperty]
    [JsonProperty(Path = ["#comment"], IsRequired = false, IgnoredIfNull = true)]
    public partial string? Comment { get; set; } = null;

    [JsonProperty(Path = ["entity", "components"])]
    public ObservableCollection<Component> Components { get; set; } = [];

    [ObservableProperty]
    [JsonProperty(Path = ["prefabName"], IsRequired = false)]
    public partial string? PrefabName { get; set; } = null;

    [ObservableProperty]
    [JsonProperty(Path = ["baseId"])]
    public partial BaseIdType BaseID { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["color"])]
    public partial Color Color { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["set"], IsRequired = false)]
    public partial string? Set { get; set; } = null;

    [ObservableProperty]
    [JsonProperty(Path = ["rarity"])]
    public partial uint Rarity { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["setAndRarityKey"], IsRequired = false)]
    public partial string? SetAndRarityKey { get; set; } = string.Empty;

    [ObservableProperty]
    [DefaultValue(0)]
    [JsonProperty(Path = ["craftingBuy"], IsRequired = false, IgnoredIfNull = true)]
    public partial int? CraftingBuy { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["craftingSell"], IsRequired = false, IgnoredIfNull = true)]
    public partial int? CraftingSell { get; set; } = 0;

    [ObservableProperty]
    [JsonProperty(Path = ["displayHealth"])]
    public partial uint DisplayHealth { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["displayAttack"])]
    public partial uint DisplayAttack { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["displaySunCost"])]
    public partial uint DisplaySunCost { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["faction"])]
    public partial Faction Faction { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["ignoreDeckLimit"])]
    public partial bool IgnoreDeckLimit { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["isPower"])]
    public partial bool IsPower { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["isPrimaryPower"])]
    public partial bool IsPrimaryPower { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["isFighter"])]
    public partial bool IsFighter { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["isEnv"])]
    public partial bool IsEnv { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["isAquatic"])]
    public partial bool IsAquatic { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["isTeamup"])]
    public partial bool IsTeamup { get; set; }

    [JsonProperty(Path = ["subtypes"])]
    public ObservableCollection<string> Subtypes { get; set; } = [];

    [JsonProperty(Path = ["tags"])]
    public ObservableCollection<string> Tags { get; set; } = [];

    [JsonProperty(Path = ["subtype_affinities"])]
    public ObservableCollection<string> SubtypeAffinities { get; set; } = [];

    [JsonProperty(Path = ["subtype_affinity_weights"])]
    public ObservableCollection<double> SubtypeAffinityWeights { get; set; } = [];

    [JsonProperty(Path = ["tag_affinities"])]
    public ObservableCollection<string> TagAffinities { get; set; } = [];

    [JsonProperty(Path = ["tag_affinity_weights"])]
    public ObservableCollection<double> TagAffinityWeights { get; set; } = [];

    [JsonProperty(Path = ["card_affinities"])]
    public ObservableCollection<uint> CardAffinities { get; set; } = [];

    [JsonProperty(Path = ["card_affinity_weights"])]
    public ObservableCollection<double> CardAffinityWeights { get; set; } = [];

    [ObservableProperty]
    [JsonProperty(Path = ["usable"])]
    public partial bool Usable { get; set; } = true;

    [JsonProperty(Path = ["special_abilities"])]
    public ObservableCollection<SpecialAbility> SpecialAbilities { get; set; } = [];
}
