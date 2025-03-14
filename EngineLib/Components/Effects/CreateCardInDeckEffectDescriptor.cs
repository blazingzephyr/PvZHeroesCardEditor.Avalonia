
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<CreateCardInDeckEffectDescriptor>))]
[GeneratesDataTemplate]
public partial class CreateCardInDeckEffectDescriptor : EffectDescriptor
{
    [ObservableProperty]
    [JsonProperty(Path = ["CardGuid"])]
    [DataTemplateField(Name = "Card Guid", Tooltip = "GUID of card that should be created.")]
    public partial uint CardGuid { get; set; }

    [ObservableProperty]
    [JsonProperty(Path = ["AmountToCreate"])]
    [DataTemplateField(Name = "Amount To Create", Tooltip = "The amount of cards that should be created.")]
    public partial uint Amount { get; set; } = 1;

    [ObservableProperty]
    [JsonProperty(Path = ["DeckPosition"])]
    [DataTemplateField(Name = "Deck Position", Tooltip = "Where to place the new card.")]
    public partial DeckPosition DeckPosition { get; set; } = DeckPosition.Random;
}
