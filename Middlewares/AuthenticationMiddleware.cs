using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.Abstractions;

namespace LIST.Middlewares
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            var path = httpContext.Request.Path;
            if (path.HasValue && !path.Value.Equals("/Home") && !path.Value.StartsWith("/Login") && !path.Value.StartsWith("/Home/Nieuws"))
            {
                if (httpContext.Session.GetString("Token") == null)
                {
                    httpContext.Response.Redirect("/Home");
                }
                else
                {
                    //Leerling
                    int? type = httpContext.Session.GetInt32("Type");
                    if (type != null)//0 (leerling) 1 (docent) 2 (mediatheek) 3  (ouder) 4 (decaan) 5 (admin)
                    {
                        if (path.Value.StartsWith("/Leerling") && type != 0)
                        {
                            httpContext.Response.Redirect("/Login");
                        }
                        else if(path.Value.StartsWith("/Docent") && type != 1)
                        {
                            httpContext.Response.Redirect("/Login");
                        }
                        else if (path.Value.StartsWith("/Decaan") && type != 4)
                        {
                            httpContext.Response.Redirect("/Login");
                        }
                        else if (path.Value.StartsWith("/Admin") && type != 5)
                        {
                            httpContext.Response.Redirect("/Login");
                        }
                    }
                    else
                    {
                        httpContext.Response.WriteAsync("Authentication failed.");
                    }
                }
               
            }
            else
            {
                
            }
            return _next(httpContext);
        }
    }

    public static class AuthenticationMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuthenticationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthenticationMiddleware>();
        }
    }
}
