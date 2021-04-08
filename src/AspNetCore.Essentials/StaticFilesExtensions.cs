using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Essentials
{
    public static class StaticFilesExtensions
    {
        /// <summary>
        /// Enables static file serving with the given options with Max-Age header.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="maxAge"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseStaticFiles(this IApplicationBuilder builder, TimeSpan maxAge)
        {
            builder.UseStaticFiles(new StaticFileOptions()
            {
                OnPrepareResponse = ctx =>
                {
                    ctx.Context.Response.GetTypedHeaders().CacheControl =
                                                                    new CacheControlHeaderValue()
                                                                    {
                                                                        Public = true,
                                                                        MaxAge = maxAge
                                                                    };
                }
            });

            return builder;
        }
    }
}
