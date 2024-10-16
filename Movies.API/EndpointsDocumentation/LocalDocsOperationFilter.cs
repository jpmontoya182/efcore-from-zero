using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace Movies.API.EndpointsDocumentation;

public class LocalDocsOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        try
        {
            var methodInfo = context.MethodInfo;

            var docAttribute = methodInfo.GetCustomAttribute<DocumentationFileAttribute>();
            if (docAttribute != null && File.Exists(docAttribute.FilePath))
            {
                var description = File.ReadAllText(docAttribute.FilePath);
                operation.Description = description;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("error getting descriptions of endpoints");
        }

    }
}
