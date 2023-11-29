using FBEVJKGADQD.SDK.PSTSPFGXFBA;

Console.Title = "FBEVJKGADQD | SDK Server";
Directory.SetCurrentDirectory(AppContext.BaseDirectory);

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://*:8888");

WebApplication app = builder.Build();

app.MapGet("/query_region_list", IZCDBLUYCWS.KVSQCDMUFBP);
app.MapGet("/query_cur_region", IZCDBLUYCWS.OnQueryCurRegion);

app.MapPost("/account/risky/api/check",                     BMSVDBTDQHC.NITRAEGRAKZ);
app.MapPost("/{product_name}/mdk/shield/api/login",         BMSVDBTDQHC.KDUUYYUBEUZ);
app.MapPost("/{product_name}/combo/granter/login/v2/login", BMSVDBTDQHC.JZPDADUNSXB);
    
await app.RunAsync();
