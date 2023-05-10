using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using ProjectOfNET6.Database;
using SideProjectForNET6.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(action =>
{
    action.ReturnHttpNotAcceptable = true; //檢核不允許的Content Type ==> 返回406 Not Acceptable
    //action.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
}).AddNewtonsoftJson(setupAction =>
{
    setupAction.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
})
.AddXmlDataContractSerializerFormatters() //擴充支援xml 之後前端可以玩
.ConfigureApiBehaviorOptions(setupAction => //將返回前端的錯誤碼優化為422status 與 客製化訊息，並將回傳的header新增problem type
{
    setupAction.InvalidModelStateResponseFactory = context =>
    {
        var problemDetail = new ValidationProblemDetails(context.ModelState)
        {
            Title = "資料驗證失敗",
            Status = StatusCodes.Status422UnprocessableEntity,
            Detail = "請看詳細說明",
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
builder.Services.AddSwaggerGen(); //註冊Swagger文件

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); //中間件使用Swagger文件服務
}

app.UseRouting();
app.UseEndpoints(endpoint =>
{
    endpoint.MapControllers();
});
app.Run();
