using System.Dynamic;

namespace COMP003B.LectureActivity2.Middleware;

public class RequestLoggingMiddleware
{
    //fields
    private readonly RequestDelegate _next;
    
    //constructor
    public RequestLoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    
    public async Task Invoke(HttpContext context)
    {
        Console.WriteLine($"[Request] {context.Request.Method} {context.Request.Path}");
        await _next(context);
        Console.WriteLine($"[Response] {context.Response.StatusCode}");
    }
    
    
    
}