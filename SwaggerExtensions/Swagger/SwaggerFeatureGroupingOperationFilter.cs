using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using System.Linq;

namespace SwaggerExtensions.Swagger
{
    public class SwaggerFeatureGroupingOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var attribute = context.ApiDescription.ActionDescriptor.EndpointMetadata.OfType<SwaggerFeatureGroupAttribute>()
                                                                                    .FirstOrDefault();
            if (attribute == null) return;

            if (attribute.FeatureName != null)
                operation.Tags = new List<OpenApiTag> { new OpenApiTag { Name = attribute.FeatureName } };
        }
    }
}
