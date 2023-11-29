using System.Collections.Concurrent;
using FBEVJKGADQD.Gameserver.BZMFWWUFBSV.EQFCMTVSDKR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace FBEVJKGADQD.Gameserver.BZMFWWUFBSV;
internal class ZFTEVPGFCKK
{
    private readonly ConcurrentDictionary<long, DFBYQXKCXCF> CPHKIQDXQDO;
    private readonly ILogger FOZNIWJRKDF;
    private readonly IServiceScopeFactory AEZUGVZAONA;

    public ZFTEVPGFCKK(ILogger<ZFTEVPGFCKK> GULXPFJHUAL, IServiceScopeFactory serviceScopeFactory)
    {
        CPHKIQDXQDO = new();

        FOZNIWJRKDF = GULXPFJHUAL;
        AEZUGVZAONA = serviceScopeFactory;
    }

    public async Task TLMSCCUJXCQ(long sessionId, SYAFWYEJLLL WWXZZZWXZJA)
    {
        await using AsyncServiceScope serviceScope = AEZUGVZAONA.CreateAsyncScope();
        DFBYQXKCXCF GFVKYXOWYMX = serviceScope.ServiceProvider.GetRequiredService<DFBYQXKCXCF>();

        try
        {
            GFVKYXOWYMX.AVLNWSZMVYG(sessionId, WWXZZZWXZJA);
            await GFVKYXOWYMX.BXXOFHWNVOJ();
        }
        catch (OperationCanceledException)
        {
            // OperationCanceled
        }
        catch (Exception exception)
        {
            FOZNIWJRKDF.LogError("Exception occurred during handling a GFVKYXOWYMX, trace: {exception}", exception);
        }
    }

    public void Add(DFBYQXKCXCF GFVKYXOWYMX)
    {
        CPHKIQDXQDO[GFVKYXOWYMX.DQORDPKGOUX] = GFVKYXOWYMX;
        FOZNIWJRKDF.LogInformation("New connection from {endPoint}", GFVKYXOWYMX.EndPoint);
    }

    public bool TryRemove(DFBYQXKCXCF GFVKYXOWYMX)
    {
        bool removed = CPHKIQDXQDO.TryRemove(GFVKYXOWYMX.DQORDPKGOUX, out _);
        if (removed)
        {
            FOZNIWJRKDF.LogInformation("Client from {endPoint} disconnected", GFVKYXOWYMX.EndPoint);
        }

        return removed;
    }
}
