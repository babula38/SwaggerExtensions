namespace SwaggerExtensions.Swagger
{
    public class RequiredMyTokenHeaderAttribute : AbstractRequiredHeaderAttribute
    {
        public RequiredMyTokenHeaderAttribute() : base("X-My-Token")
        {

        }
    }

    public class RequiredMyToken2HeaderAttribute : AbstractRequiredHeaderAttribute
    {
        public RequiredMyToken2HeaderAttribute() : base("X-My-Token2")
        {

        }
    }
}
