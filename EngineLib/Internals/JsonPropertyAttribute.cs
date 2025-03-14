
namespace PvZCards.Engine;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
internal class JsonPropertyAttribute : Attribute
{
    public required string[] Path { get; set; }
    public Type?[] Annotations { get; set; } = [];
    public bool IsRequired { get; set; } = true;
    public bool IgnoredIfNull { get; set; } = false;
}
