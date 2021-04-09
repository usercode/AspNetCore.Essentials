using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Essentials
{
    public enum CrossOriginEmbedderPolicy
    {
        /// <summary>
        /// This is the default value. Allows the document to fetch cross-origin resources without giving explicit permission through the CORS protocol or the Cross-Origin-Resource-Policy header.
        /// </summary>
        UnsafeNone,

        /// <summary>
        /// A document can only load resources from the same origin, or resources explicitly marked as loadable from another origin.
        /// If a cross origin resource supports CORS, the crossorigin attribute or the Cross-Origin-Resource-Policy header must be used to load it without being blocked by COEP.
        /// </summary>
        RequireCorp
    }
}
