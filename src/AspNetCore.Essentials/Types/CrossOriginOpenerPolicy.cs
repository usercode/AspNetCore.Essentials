using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Essentials
{
    public enum CrossOriginOpenerPolicy
    {
        /// <summary>
        /// This is the default value. Allows the document to be added to its opener's browsing context group unless the opener itself has a COOP of same-origin or same-origin-allow-popups.
        /// </summary>
        UnsafeNone,

        /// <summary>
        /// Retains references to newly opened windows or tabs which either don't set COOP or which opt out of isolation by setting a COOP of unsafe-none.
        /// </summary>
        SameOriginAllowPopups,

        /// <summary>
        /// Isolates the browsing context exclusively to same-origin documents. Cross-origin documents are not loaded in the same browsing context.
        /// </summary>
        SameOrigin
    }
}
