using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using System.Linq;

namespace SwaggerExtensions.Swagger
{
    public class AddRequiredHeaderParameterOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var headerAttributes = context.ApiDescription.ActionDescriptor.EndpointMetadata.OfType<AbstractRequiredHeaderAttribute>()
                                                                                    .ToList();

            if (headerAttributes == null || headerAttributes.Count == 0) return;

            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();

            foreach (var requiredHeader in headerAttributes)
            {
                operation.Parameters.Add(new OpenApiParameter
                {
                    Name = requiredHeader.HeaderName,
                    In = ParameterLocation.Header,
                    Required = true,
                });
            }
        }
    }
}
