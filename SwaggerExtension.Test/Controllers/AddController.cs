using Microsoft.AspNetCore.Mvc;
using SwaggerExtensions.Swagger;

namespace SwaggerExtension.Test.Controllers
{
    [SwaggerFeatureGroup("Calculator")]
    [Route("api/[controller]")]
    [ApiController]
    public class AddController : ControllerBase
    {
        [HttpPost]
        public int Post(int number1, int number2) => number1 + number2;
    }

    /// <summary>
    /// [RequiredMyTokenHeader] used in controller level
    /// </summary>
    [SwaggerFeatureGroup("Calculator")]
    [Route("api/[controller]")]
    [ApiController]
    [RequiredMyTokenHeader]
    public class SubstractController : ControllerBase
    {
        [HttpPost]
        public int Post(int number1, int number2) => number1 - number2;

        [HttpPost("Check")]
        public int Check(int number1, int number2) => number1 - number2;
    }

    /// <summary>
    /// [RequiredMyTokenHeader] used only on method level
    /// </summary>
    [SwaggerFeatureGroup("Calculator")]
    [Route("api/[controller]")]
    [ApiController]
    public class MultiplyController : ControllerBase
    {
        [RequiredMyTokenHeader]
        [HttpPost]
        public int Post(int number1, int number2) => number1 * number2;
        //RequiredMyTokenTwoHeader
    }

    /// <summary>
    /// RequiredMyTokenHeader & RequiredMyTokenHeader multiple used
    /// </summary>
    [SwaggerFeatureGroup("Calculator")]
    [Route("api/[controller]")]
    [ApiController]
    public class DivisionController : ControllerBase
    {
        [RequiredMyTokenHeader]
        [RequiredMyToken2Header]
        [HttpPost]
        public int Post(int number1, int number2) => number1 / number2;
    }
}
