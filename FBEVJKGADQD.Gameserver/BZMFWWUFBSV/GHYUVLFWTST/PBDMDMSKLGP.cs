using System.Buffers;
using System.Net;
using System.Net.Sockets;
using FBEVJKGADQD.Gameserver.ZPDJISTARQW;
using FBEVJKGADQD.Kcp;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FBEVJKGADQD.Gameserver.BZMFWWUFBSV.GHYUVLFWTST;
internal sealed class PBDMDMSKLGP : MHJMMWVKPKE
{
    private readonly Random IOVKYVATESP;
    private readonly ILogger FOZNIWJRKDF;
    private readonly IOptions<JTSTAVHBGKE> BXCLMKLDSEQ;
    private readonly ZFTEVPGFCKK CLFVXKSUABA;

    private uint HNYTFCYIBLA;
    private IKcpTransport<IKcpMultiplexConnection>? JOQFJIRSXGF;

    public PBDMDMSKLGP(ILogger<PBDMDMSKLGP> GULXPFJHUAL, IOptions<JTSTAVHBGKE> options, ZFTEVPGFCKK QKRIPYSAJAN)
    {
        FOZNIWJRKDF = GULXPFJHUAL;
        BXCLMKLDSEQ = options;
        CLFVXKSUABA = QKRIPYSAJAN;

        IOVKYVATESP = new();
    }

    public Task KSTDGKIDJYV()
    {
        IPEndPoint bindEndPoint = BXCLMKLDSEQ.Value.EndPoint;

        JOQFJIRSXGF = KcpSocketTransport.CreateMultiplexConnection(new(bindEndPoint), 1400);
        JOQFJIRSXGF.SetCallbacks(20, QWHRWDDIEZW);
        JOQFJIRSXGF.Start();

        FOZNIWJRKDF.LogInformation("KCP Gateway is up at {endPoint}", bindEndPoint);
        return Task.CompletedTask;
    }

    private async ValueTask QWHRWDDIEZW(UdpReceiveResult receiveResult)
    {
        SCKFFZDWWSM handshake = SCKFFZDWWSM.XOTAHUXXWMW(receiveResult.Buffer);

        switch ((handshake.KRAKJGGTLFU, handshake.FKOJWRVZKBN))
        {
            case (SCKFFZDWWSM.LXUECMNQVPM, SCKFFZDWWSM.SQTDLKXGXJD):
                await TCAQOKLUODF(receiveResult.RemoteEndPoint);
                break;
        }
    }

    private async ValueTask TCAQOKLUODF(IPEndPoint clientEndPoint)
    {
        uint convId = Interlocked.Increment(ref HNYTFCYIBLA);
        uint token = (uint)IOVKYVATESP.Next();

        long convId64 = (long)convId << 32 | token;
        KcpConversation conversation = JOQFJIRSXGF!.Connection.CreateConversation(convId64, clientEndPoint);
        _ = CLFVXKSUABA.TLMSCCUJXCQ(convId64, new WZZWKVKIDXM(conversation, clientEndPoint));

        await LYAPCZIPCHL(clientEndPoint, convId, token);
    }

    private async ValueTask LYAPCZIPCHL(IPEndPoint clientEndPoint, uint convId, uint token)
    {
        SCKFFZDWWSM handshakeResponse = new()
        {
            KRAKJGGTLFU = SCKFFZDWWSM.RHFZJFTGHBA,
            SXFFXZSNBKL = convId,
            XHBIFPWTKPH = token,
            WAZMOQLNYZB = 1234567890,
            FKOJWRVZKBN = SCKFFZDWWSM.IHTNDUFMBXL
        };

        byte[] OCDSIELOZKK = ArrayPool<byte>.Shared.Rent(20);
        try
        {
            Memory<byte> bufferMemory = OCDSIELOZKK.AsMemory();

            handshakeResponse.ZLZEQASFIFJ(OCDSIELOZKK);
            await JOQFJIRSXGF!.SendPacketAsync(bufferMemory[..20], clientEndPoint, CancellationToken.None);
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(OCDSIELOZKK);
        }
    }

    public Task QVDMGAUKDWD()
    {
        return Task.CompletedTask;
    }
}
