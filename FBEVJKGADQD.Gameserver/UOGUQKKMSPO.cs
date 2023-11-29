using FBEVJKGADQD.Common.HSFCATOPDTI;
using FBEVJKGADQD.Common.HSFCATOPDTI.GLYMTKISXFZ;
using FBEVJKGADQD.Common.HSFCATOPDTI.GNECZXLXXHH;
using FBEVJKGADQD.Common.HSFCATOPDTI.YOZTFEGPOUY;
using FBEVJKGADQD.Gameserver;
using FBEVJKGADQD.Gameserver.BZMFWWUFBSV;
using FBEVJKGADQD.Gameserver.BZMFWWUFBSV.EQFCMTVSDKR;
using FBEVJKGADQD.Gameserver.BZMFWWUFBSV.GHYUVLFWTST;
using FBEVJKGADQD.Gameserver.CWREKSPCAGC;
using FBEVJKGADQD.Gameserver.CWREKSPCAGC.BCAKFGQBSST;
using FBEVJKGADQD.Gameserver.CWREKSPCAGC.KRACKSBFMLI;
using FBEVJKGADQD.Gameserver.CWREKSPCAGC.KRACKSBFMLI.CJFUHOXIYCR;
using FBEVJKGADQD.Gameserver.CWREKSPCAGC.KRACKSBFMLI.XSUUHMCVMKJ;
using FBEVJKGADQD.Gameserver.NMIJCSMNYNB.VNUTIAPYCZC;
using FBEVJKGADQD.Gameserver.ZPDJISTARQW;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

Console.Title = "FBEVJKGADQD | Game Server [Experimental]";

HostApplicationBuilder builder = Host.CreateApplicationBuilder();
builder.Logging.AddSimpleConsole();

builder.Services.Configure<JTSTAVHBGKE>(builder.Configuration.GetSection(JTSTAVHBGKE.WFOCUMVPWIO));

// Resources
builder.Services.CKLFXFCHTZS();
builder.Services.AddSingleton<QBKOFDBXXPD>();
builder.Services.AddSingleton<SDDKEYJXNVG>();
builder.Services.AddSingleton<QOAXVAVOKZE>();

// Game Logic
builder.Services.AddScoped<WUVNKLLTRWM>();
builder.Services.AddScoped<FKVGHBHFSFE>();
builder.Services.AddScoped<DMMIOUNBHHF>();
builder.Services.AddScoped<NJKLKSSIKNA>();

// Logic Listeners
builder.Services.AddScoped<ZKTZSOLHWMF, IOGECNZYWRP>();

// Network
builder.Services.AddScoped<ONVXSSCFBAG>();
builder.Services.AddScoped<DFBYQXKCXCF, JKWPSSUZYRP>();
builder.Services.AddSingleton<MHJMMWVKPKE, PBDMDMSKLGP>();
builder.Services.AddSingleton<ZFTEVPGFCKK>();

builder.Services.AddHostedService<VNEBXAORSTQ>();

await builder.Build().RunAsync();