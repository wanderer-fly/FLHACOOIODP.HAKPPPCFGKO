using FBEVJKGADQD.Common.OPLZFFRUAJP;
using FBEVJKGADQD.Gameserver.BZMFWWUFBSV.EQFCMTVSDKR;
using FBEVJKGADQD.Gameserver.NMIJCSMNYNB.VNUTIAPYCZC;
using Microsoft.Extensions.Logging;

namespace FBEVJKGADQD.Gameserver.BZMFWWUFBSV.GHYUVLFWTST;
internal class JKWPSSUZYRP : DFBYQXKCXCF
{
    private const int NBGZNSGCTVO = 32768;
    private const int STIBPPPZVBM = 30;
    private const int RLAVPMLJYBS = 30;

    private readonly byte[] JMZBUVROZSE;
    private readonly byte[] CPFANKPIIKC;

    public JKWPSSUZYRP(ILogger<DFBYQXKCXCF> GULXPFJHUAL, ZFTEVPGFCKK QKRIPYSAJAN, ONVXSSCFBAG commandDispatcher) : base(GULXPFJHUAL, QKRIPYSAJAN, commandDispatcher)
    {
        JMZBUVROZSE = GC.AllocateUninitializedArray<byte>(NBGZNSGCTVO);
        CPFANKPIIKC = GC.AllocateUninitializedArray<byte>(NBGZNSGCTVO);
    }

    public override async ValueTask BXXOFHWNVOJ()
    {
        Memory<byte> OCDSIELOZKK = JMZBUVROZSE.AsMemory();

        while (true)
        {
            int readAmount = await MFIFKNVBRWH(OCDSIELOZKK, STIBPPPZVBM);
            if (readAmount <= 0)
                break;

            FHFWWIHCNVD.ZCNQFTFYYPC(OCDSIELOZKK[..readAmount].Span, UKGJKIBEPLP);
            int consumedBytes = await PQUNUHHTZIA(OCDSIELOZKK[..readAmount]);
            if (consumedBytes == -1)
                break;
        }
    }

    public override async ValueTask XAEFRTNKUYB(LFZRLZCJSQD AVGBWXBJZYC)
    {
        Memory<byte> OCDSIELOZKK = CPFANKPIIKC.AsMemory();

        int length = AVGBWXBJZYC.RRZGFLJPGAM(OCDSIELOZKK);
        FHFWWIHCNVD.ZCNQFTFYYPC(OCDSIELOZKK[..length].Span, UKGJKIBEPLP);

        await EXUBEJNCWDA(OCDSIELOZKK[..length], RLAVPMLJYBS);
    }
}
