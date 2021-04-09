# AspNetCore.Essentials
Adds extra http headers to response (COOP, COEP, CORP, X-Frame-Options, X-Content-Type-Options)

[![nuget](https://img.shields.io/nuget/v/AspNetCore.Essentials.svg)](https://www.nuget.org/packages/AspNetCore.Essentials)


## Example ##

```csharp
using AspNetCore.Essentials;

public void Configure(IApplicationBuilder app)
{
    app.AddReferrerPolicy(ReferrerPolicy.StrictOriginWhenCrossOrigin);

    app.AddXContentTypeOptions(XContentOptions.NoSniff);
    app.AddXFrameOptions(XFrameOptions.SameOrigin);
    
    app.AddCrossOriginEmbedderPolicy(CrossOriginEmbedderPolicy.RequireCorp);
    app.AddCrossOriginOpenerPolicy(CrossOriginOpenerPolicy.SameOrigin);
    app.AddCrossOriginResourcePolicy(CrossOriginResourcePolicy.SameOrigin);
}

```
