namespace Movies.API.EndpointsDocumentation;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class DocumentationFileAttribute : Attribute
{
    public string FilePath { get; set; }

    public DocumentationFileAttribute(string filePath)
    {
        FilePath = filePath;
    }
}
