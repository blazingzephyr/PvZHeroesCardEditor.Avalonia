
namespace TemplateSourceGenerator;

[AttributeUsage(AttributeTargets.Property)]
public class DataTemplateFieldAttribute : Attribute
{
    public string? Name { get; set; }
    public string? Tooltip { get; set; }
}
