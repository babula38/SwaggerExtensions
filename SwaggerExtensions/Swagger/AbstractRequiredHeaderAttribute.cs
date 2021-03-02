using System;

namespace SwaggerExtensions.Swagger
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class AbstractRequiredHeaderAttribute : Attribute
    {
        public AbstractRequiredHeaderAttribute(string headerName)
                        => HeaderName = headerName;

        public string HeaderName { get; }
    }
}
