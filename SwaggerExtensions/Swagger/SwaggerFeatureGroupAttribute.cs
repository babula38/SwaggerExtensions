using System;

namespace SwaggerExtensions.Swagger
{
    /// <summary>
    /// This is similar to "Area" concepts, but it works to group controllers 
    /// i.e. easier way to manage when using controller follow CQRS pattern(i.e CreateEmployeeController) in swagger ui
    /// </summary>
    public class SwaggerFeatureGroupAttribute : Attribute
    {
        public string FeatureName { get; private set; }
        public SwaggerFeatureGroupAttribute(string featureGroupName)
        {
            FeatureName = featureGroupName;
        }
    }
}
