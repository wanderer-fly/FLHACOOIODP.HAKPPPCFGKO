using System.Net;
using FBEVJKGADQD.Common.OPLZFFRUAJP;
using FBEVJKGADQD.Gameserver.NMIJCSMNYNB.HWKZPLJYJSU;
using FBEVJKGADQD.Gameserver.NMIJCSMNYNB.VNUTIAPYCZC;
using FBEVJKGADQD.Protocol;
using Google.Protobuf;
using Microsoft.Extensions.Logging;

namespace FBEVJKGADQD.Gameserver.BZMFWWUFBSV.EQFCMTVSDKR;
internal abstract class DFBYQXKCXCF : IDisposable
{
    public IPEndPoint EndPoint => AFHJVYYDVYO!.RemoteEndPoint;

    public long DQORDPKGOUX { get; private set; }
    private SYAFWYEJLLL? AFHJVYYDVYO;

    private readonly ILogger FOZNIWJRKDF;
    private readonly ZFTEVPGFCKK CLFVXKSUABA;
    private readonly ONVXSSCFBAG DQNQGTKJZCO;

    protected byte[] UKGJKIBEPLP { get; private set; }

    public DFBYQXKCXCF(ILogger<DFBYQXKCXCF> GULXPFJHUAL, ZFTEVPGFCKK QKRIPYSAJAN, ONVXSSCFBAG OCSUZZQZJGQ)
    {
        FOZNIWJRKDF = GULXPFJHUAL;
        CLFVXKSUABA = QKRIPYSAJAN;
        DQNQGTKJZCO = OCSUZZQZJGQ;

        UKGJKIBEPLP = FHFWWIHCNVD.ZNYPCCYFNHY;
    }

    public abstract ValueTask BXXOFHWNVOJ();
    public abstract ValueTask XAEFRTNKUYB(LFZRLZCJSQD AVGBWXBJZYC);

    public void AVLNWSZMVYG(long sessionId, SYAFWYEJLLL WWXZZZWXZJA)
    {
        DQORDPKGOUX = sessionId;
        AFHJVYYDVYO = WWXZZZWXZJA;

        CLFVXKSUABA.Add(this);
    }

    public async Task SEBRUKUCPXQ<TNotify>(TVSUXQOGQCR YTUILIPGEVE, TNotify notify) where TNotify : IMessage<TNotify>
    {
        await XAEFRTNKUYB(new()
        {
            TVSUXQOGQCR = YTUILIPGEVE,
            WSXFVFFAURX = Memory<byte>.Empty,
            HUNFHOHOEHO = notify.ToByteArray()
        });
    }

    protected async ValueTask<int> PQUNUHHTZIA(Memory<byte> OCDSIELOZKK)
    {
        if (OCDSIELOZKK.Length < 12)
            return 0;

        int SOEOZKKRAQT = 0;
        do
        {
            (LFZRLZCJSQD? AVGBWXBJZYC, int FAYDAXMJWXK) = LFZRLZCJSQD.UKACLOYHYAF(OCDSIELOZKK[SOEOZKKRAQT..]);
            SOEOZKKRAQT += FAYDAXMJWXK;

            if (AVGBWXBJZYC == null)
                return SOEOZKKRAQT;

            PBWRXELQMPB? XHAVGFLHOMM = await DQNQGTKJZCO.AEFFEZQEPJC(AVGBWXBJZYC);
            if (XHAVGFLHOMM != null)
            {
                while (XHAVGFLHOMM.SGIKWJAVYCM(out LFZRLZCJSQD? VORLFJTIZBG))
                {
                    await XAEFRTNKUYB(VORLFJTIZBG);

                    if (VORLFJTIZBG.TVSUXQOGQCR == TVSUXQOGQCR.GetPlayerTokenRsp)
                    {
                        BKNNNTUGIFP(1337); // hardcoded MT seed with patch
                    }
                }

                FOZNIWJRKDF.LogInformation("Successfully handled command of type {cmdType}", AVGBWXBJZYC.TVSUXQOGQCR);
            }
        } while (OCDSIELOZKK.Length - SOEOZKKRAQT >= 12);

        return SOEOZKKRAQT;
    }

    private void BKNNNTUGIFP(ulong NZTLTGYFRFE)
    {
        UKGJKIBEPLP = FHFWWIHCNVD.HHMACIKPGVA(NZTLTGYFRFE);
    }

    protected async ValueTask<int> MFIFKNVBRWH(Memory<byte> OCDSIELOZKK, int QGHTMWJELCK)
    {
        using CancellationTokenSource BTTPATOEJQL = new(TimeSpan.FromSeconds(QGHTMWJELCK));
        return await AFHJVYYDVYO!.GQXRZIBMRJU(OCDSIELOZKK, BTTPATOEJQL.Token);
    }

    protected async ValueTask EXUBEJNCWDA(Memory<byte> OCDSIELOZKK, int QGHTMWJELCK)
    {
        using CancellationTokenSource BTTPATOEJQL = new(TimeSpan.FromSeconds(QGHTMWJELCK));
        await AFHJVYYDVYO!.XAEFRTNKUYB(OCDSIELOZKK, BTTPATOEJQL.Token);
    }

    public virtual void Dispose()
    {
        AFHJVYYDVYO?.Dispose();
        _ = CLFVXKSUABA.TryRemove(this);
    }
}
