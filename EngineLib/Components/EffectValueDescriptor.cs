
namespace PvZCards.Engine.Components;

[JsonConverter(typeof(ComponentConverter<EffectValueDescriptor>))]
[GeneratesDataTemplate]
public class EffectValueDescriptor : Component
{
    [DataTemplateField(Name = "DestToSourceMap", Tooltip = "If set to true, maps heal amount to damage amount. Otherwise, does the exact opposite.")]
    public bool HealToDamage {
        get => DestToSourceMap.ContainsKey("HealAmount");
        set {
            if (value)
            {
                DestToSourceMap.Remove("DamageAmount");
                DestToSourceMap["HealAmount"] = "DamageAmount";
            }
            else
            {
                DestToSourceMap.Remove("DamageAmount");
                DestToSourceMap["DamageAmount"] = "HealAmount";
            }
        } 
    }

    [JsonProperty(Path = ["DestToSourceMap"])]
    public Dictionary<string, string> DestToSourceMap { get; set; } = [];
}
