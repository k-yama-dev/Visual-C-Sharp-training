var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (HttpContext context) => 
{
    context.Response.ContentType = "text/html";
            return """
            <html><head>
            <title>HelloHTML</title>
            </head>
            <body>
            <h1>HelloHTML</h1>
            <p>This is My HTML You Know?</p>
            </body>
            </html>
            """;
}
);

app.Run();
