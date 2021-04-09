using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Essentials
{
    public enum ReferrerPolicy
    {
        /// <summary>
        /// The Referer header will be omitted entirely. No referrer information is sent along with requests.
        /// </summary>
        NoReferrer,

        /// <summary>
        /// Send the origin, path, and querystring in Referer when the protocol security level stays the same or improves (HTTP→HTTP, HTTP→HTTPS, HTTPS→HTTPS). Don't send the Referer header for requests to less secure destinations (HTTPS→HTTP, HTTPS→file). 
        /// </summary>
        NoReferrerWhenDowngrade,

        /// <summary>
        /// Send the origin (only) in the Referer header. 
        /// <br /><br />
        /// For example, a document at https://example.com/page.html will send the referrer https://example.com/.
        /// </summary>
        Origin,

        /// <summary>
        /// Send the origin, path, and query string when performing a same-origin request to the same protocol level. Send origin (only) for cross origin requests and requests to less secure destinations.
        /// </summary>
        OriginWhenCrossOrigin,

        /// <summary>
        /// Send the origin, path, and query string for same-origin requests. Don't send the Referer header for cross-origin requests.
        /// </summary>
        SameOrigin,

        /// <summary>
        /// Send the origin (only) when the protocol security level stays the same (HTTPS→HTTPS). Don't send the Referer header to less secure destinations (HTTPS→HTTP).
        /// </summary>
        StrictOrigin,

        /// <summary>
        /// Send the origin, path, and querystring when performing a same-origin request. For cross-origin requests send the origin (only) when the protocol security level stays same (HTTPS→HTTPS). Don't send the Referer header to less secure destinations (HTTPS→HTTP). 
        /// </summary>
        StrictOriginWhenCrossOrigin

    }
}
