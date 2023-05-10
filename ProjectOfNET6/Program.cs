using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using ProjectOfNET6.Database;
using SideProjectForNET6.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(action =>
{
    action.ReturnHttpNotAcceptable = true; //�ˮ֤����\��Content Type ==> ��^406 Not Acceptable
    //action.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
}).AddNewtonsoftJson(setupAction =>
{
    setupAction.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
})
.AddXmlDataContractSerializerFormatters() //�X�R�䴩xml ����e�ݥi�H��
.ConfigureApiBehaviorOptions(setupAction => //�N��^�e�ݪ����~�X�u�Ƭ�422status �P �Ȼs�ưT���A�ñN�^�Ǫ�header�s�Wproblem type
{
    setupAction.InvalidModelStateResponseFactory = context =>
    {
        var problemDetail = new ValidationProblemDetails(context.ModelState)
        {
            Title = "������ҥ���",
            Status = StatusCodes.Status422UnprocessableEntity,
            Detail = "�ЬݸԲӻ���",
            Instance = context.HttpContext.Request.Path
        };
        problemDetail.Extensions.Add("traceId", context.HttpContext.TraceIdentifier);
        return new UnprocessableEntityObjectResult(problemDetail)
        {
            ContentTypes = { "application/problem+json" }
        };
    };
});
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("db"));
});
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddSwaggerGen(); //���USwagger���

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); //������ϥ�Swagger���A��
}

app.UseRouting();
app.UseEndpoints(endpoint =>
{
    endpoint.MapControllers();
});
app.Run();
