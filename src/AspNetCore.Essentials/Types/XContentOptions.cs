using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Essentials.Types
{
    public enum XContentOptions
    {
        /// <summary>
        /// Blocks a request if the request destination is of type:<br />
        /// "style" and the MIME type is not text/css, or<br />
        /// "script" and the MIME type is not a JavaScript MIME type<br />
        /// <br /><br />
        /// Enables Cross-Origin Read Blocking (CORB) protection for the MIME-types:<br />
        /// text/html<br />
        /// text/plain<br />
        /// text/json, application/json or any other type with a JSON extension: */*+json<br />
        /// text/xml, application/xml or any other type with an XML extension: */*+xml (excluding image/svg+xml)<br />
        /// </summary>
        NoSniff
    }
}
