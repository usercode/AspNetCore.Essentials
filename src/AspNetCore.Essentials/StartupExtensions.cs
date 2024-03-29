﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;

namespace AspNetCore.Essentials
{
    /// <summary>
    /// StartupExtensions
    /// </summary>
    public static class StartupExtensions
    {
        /// <summary>
        /// The Referrer-Policy HTTP header controls how much referrer information (sent via the Referer header) should be included with requests. Aside from the HTTP header, you can set this policy in HTML.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IApplicationBuilder AddReferrerPolicy(this IApplicationBuilder builder, ReferrerPolicy value)
        {
            builder.Use((context, next) =>
            {
                context.Response.SetReferrerPolicy(value);

                return next();
            });

            return builder;
        }

        /// <summary>
        /// The X-Content-Type-Options response HTTP header is a marker used by the server to indicate that the MIME types advertised in the Content-Type headers should not be changed and be followed. This is a way to opt out of MIME type sniffing, or, in other words, to say that the MIME types are deliberately configured.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IApplicationBuilder AddXContentTypeOptions(this IApplicationBuilder builder, XContentOptions value)
        {
            builder.Use((context, next) => 
            {
                context.Response.SetXContentTypeOptions(value);

                return next();
            });

            return builder;
        }

        /// <summary>
        /// The X-Frame-Options HTTP response header can be used to indicate whether or not a browser should be allowed to render a page in a <frame>, <iframe>, <embed> or <object>. Sites can use this to avoid click-jacking attacks, by ensuring that their content is not embedded into other sites.
        /// The added security is provided only if the user accessing the document is using a browser that supports X-Frame-Options.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="value"></param>
        /// <param name="allowFromUri"></param>
        /// <returns></returns>
        public static IApplicationBuilder AddXFrameOptions(this IApplicationBuilder builder, XFrameOptions value)
        {
            builder.Use((context, next) =>
            {
                context.Response.SetXFrameOptions(value);

                return next();
            });

            return builder;
        }

        /// <summary>
        /// The HTTP Cross-Origin-Opener-Policy (COOP) response header allows you to ensure a top-level document does not share a browsing context group with cross-origin documents.
        /// <br/><br/>
        /// COOP will process-isolate your document and potential attackers can't access to your global object if they were opening it in a popup, preventing a set of cross-origin attacks dubbed XS-Leaks.
        /// <br /><br />
        /// If a cross-origin document with COOP is opened in a new window, the opening document will not have a reference to it, and the window.opener property of the new window will be null. This allows you to have more control over references to a window than rel=noopener, which only affects outgoing navigations.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IApplicationBuilder AddCrossOriginOpenerPolicy(this IApplicationBuilder builder, CrossOriginOpenerPolicy value)
        {
            builder.Use((context, next) =>
            {
                context.Response.SetCrossOriginOpenerPolicy(value);

                return next();
            });

            return builder;
        }

        /// <summary>
        /// The HTTP Cross-Origin-Embedder-Policy (COEP) response header prevents a document from loading any cross-origin resources that don't explicitly grant the document permission (using CORP or CORS).
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IApplicationBuilder AddCrossOriginEmbedderPolicy(this IApplicationBuilder builder, CrossOriginEmbedderPolicy value)
        {
            builder.Use((context, next) =>
            {
                context.Response.SetCrossOriginEmbedderPolicy(value);

                return next();
            });

            return builder;
        }

        /// <summary>
        /// The HTTP Cross-Origin-Resource-Policy (CORP) response header conveys a desire that the browser blocks no-cors cross-origin/cross-site requests to the given resource.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IApplicationBuilder AddCrossOriginResourcePolicy(this IApplicationBuilder builder, CrossOriginResourcePolicy value)
        {
            builder.Use((context, next) =>
            {
                context.Response.SetCrossOriginResourcePolicy(value);

                return next();
            });

            return builder;
        }
    }
}
