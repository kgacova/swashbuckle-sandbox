using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using Microsoft.OpenApi.Models;
using System.Linq;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Swagger;
using Models;

namespace SandboxApi.Filters
{
    public class WeatherPostOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.OperationId != "Weather_Post")
                return;
            operation.RequestBody = new OpenApiRequestBody()
            {
                Content = new Dictionary<string, OpenApiMediaType> {
                    {"multipart/form-data",
                    new OpenApiMediaType()
                    {
                        Schema = context.SchemaGenerator
                        .GenerateSchema(typeof(WeatherForecast), context.SchemaRepository)
                    }
                    }
                }
            };
        }
    }
}
