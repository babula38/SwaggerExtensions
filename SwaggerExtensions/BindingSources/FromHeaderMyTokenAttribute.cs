using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace SwaggerExtensions.BindingSources
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class FromHeaderMyTokenAttribute : Attribute, IBindingSourceMetadata, IModelNameProvider
    {
        public BindingSource BindingSource => BindingSource.Header;

        public string Name { get; set; } = "X-NIS-LDC";
    }
}
