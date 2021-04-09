# AspNetCore.Essentials
Adds extra http headers to response (COOP, COEP, CORP, X-Frame-Options, X-Content-Type-Options)

[![nuget](https://img.shields.io/nuget/v/AspNetCore.Essentials.svg)](https://www.nuget.org/packages/AspNetCore.Essentials)

- Referrer-Policy
- X-Content-Type-Options (NoSniff)
- X-Frame-Options
- Cross-Origin-Resource-Policy (CORP)
- Cross-Origin-Embedder-Policy (COEP)
- Cross-Origin-Opener-Policy (COOP)

## Example ##

### Use middleware ###

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

### Use HttpResponse extensions ###

```csharp
public void Prepare(HttpResponse response)
{
    response.SetReferrerPolicy(ReferrerPolicy.StrictOriginWhenCrossOrigin);
    
    response.SetXContentTypeOptions(XContentOptions.NoSniff);
    response.SetXFrameOptions(XFrameOptions.SameOrigin);
    
    response.SetCrossOriginEmbedderPolicy(CrossOriginEmbedderPolicy.RequireCorp);
    response.SetCrossOriginOpenerPolicy(CrossOriginOpenerPolicy.SameOrigin);
    response.SetCrossOriginResourcePolicy(CrossOriginResourcePolicy.SameOrigin);
}
```
