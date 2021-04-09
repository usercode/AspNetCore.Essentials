using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Essentials
{
    /// <summary>
    /// HttpResponseExtensions
    /// </summary>
    public static class HttpResponseExtensions
    {
        /// <summary>
        /// The Referrer-Policy HTTP header controls how much referrer information (sent via the Referer header) should be included with requests. Aside from the HTTP header, you can set this policy in HTML.
        /// </summary>
        /// <param name="response"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static HttpResponse SetReferrerPolicy(this HttpResponse response, ReferrerPolicy value)
        {
            response.Headers.Append("Referrer-Policy", value switch
            {
                ReferrerPolicy.NoReferrer => "no-referrer",
                ReferrerPolicy.NoReferrerWhenDowngrade => "no-referrer-when-downgrade",
                ReferrerPolicy.Origin => "origin",
                ReferrerPolicy.OriginWhenCrossOrigin => "origin-when-cross-origin",
                ReferrerPolicy.SameOrigin => "same-origin",
                ReferrerPolicy.StrictOrigin => "strict-origin",
                ReferrerPolicy.StrictOriginWhenCrossOrigin => "strict-origin-when-cross-origin",
                _ => throw new Exception()
            });

            return response;
        }

        /// <summary>
        /// The X-Content-Type-Options response HTTP header is a marker used by the server to indicate that the MIME types advertised in the Content-Type headers should not be changed and be followed. This is a way to opt out of MIME type sniffing, or, in other words, to say that the MIME types are deliberately configured.
        /// </summary>
        /// <param name="headers"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static HttpResponse SetXContentTypeOptions(this HttpResponse response, XContentOptions value)
        {
            response.Headers.Append("X-Content-Type-Options", value switch
            {
                XContentOptions.NoSniff => "nosniff",
                _ => throw new Exception()
            });

            return response;
        }

        /// <summary>
        /// The X-Frame-Options HTTP response header can be used to indicate whether or not a browser should be allowed to render a page in a <frame>, <iframe>, <embed> or <object>. Sites can use this to avoid click-jacking attacks, by ensuring that their content is not embedded into other sites.
        /// <br /><br />
        /// The added security is provided only if the user accessing the document is using a browser that supports X-Frame-Options.
        /// </summary>
        /// <param name="headers"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static HttpResponse SetXFrameOptions(this HttpResponse response, XFrameOptions value)
        {
            response.Headers.Append("X-Frame-Options",
                    value switch
                    {
                        XFrameOptions.Deny => "deny",
                        XFrameOptions.SameOrigin => "sameorigin",
                        _ => throw new Exception()
                    });

            return response;
        }

        /// <summary>
        /// The HTTP Cross-Origin-Opener-Policy (COOP) response header allows you to ensure a top-level document does not share a browsing context group with cross-origin documents.
        /// <br/><br/>
        /// COOP will process-isolate your document and potential attackers can't access to your global object if they were opening it in a popup, preventing a set of cross-origin attacks dubbed XS-Leaks.
        /// <br /><br />
        /// If a cross-origin document with COOP is opened in a new window, the opening document will not have a reference to it, and the window.opener property of the new window will be null. This allows you to have more control over references to a window than rel=noopener, which only affects outgoing navigations.
        /// </summary>
        /// <param name="headers"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static HttpResponse SetCrossOriginOpenerPolicy(this HttpResponse response, CrossOriginOpenerPolicy value)
        {
            response.Headers.Append("Cross-Origin-Opener-Policy", value switch
            {
                CrossOriginOpenerPolicy.UnsafeNone => "unsafe-none",
                CrossOriginOpenerPolicy.SameOrigin => "same-origin",
                CrossOriginOpenerPolicy.SameOriginAllowPopups => "same-origin-allow-popups",
                _ => throw new Exception()
            });

            return response;
        }

        /// <summary>
        /// The HTTP Cross-Origin-Embedder-Policy (COEP) response header prevents a document from loading any cross-origin resources that don't explicitly grant the document permission (using CORP or CORS).
        /// </summary>
        /// <param name="headers"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static HttpResponse SetCrossOriginEmbedderPolicy(this HttpResponse response, CrossOriginEmbedderPolicy value)
        {
            response.Headers.Append("Cross-Origin-Embedder-Policy",
                   value switch
                   {
                       CrossOriginEmbedderPolicy.UnsafeNone => "unsafe-none",
                       CrossOriginEmbedderPolicy.RequireCorp => "require-corp",
                       _ => throw new Exception()
                   });

            return response;
        }

        /// <summary>
        /// The HTTP Cross-Origin-Resource-Policy (CORP) response header conveys a desire that the browser blocks no-cors cross-origin/cross-site requests to the given resource.
        /// </summary>
        /// <param name="headers"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static HttpResponse SetCrossOriginResourcePolicy(this HttpResponse response, CrossOriginResourcePolicy value)
        {
            response.Headers.Append("Cross-Origin-Resource-Policy",
                    value switch
                    {
                        CrossOriginResourcePolicy.SameSite => "same-site",
                        CrossOriginResourcePolicy.SameOrigin => "same-origin",
                        CrossOriginResourcePolicy.CrossOrigin => "cross-origin",
                        _ => throw new Exception()
                    });

            return response;
        }
    }
}
