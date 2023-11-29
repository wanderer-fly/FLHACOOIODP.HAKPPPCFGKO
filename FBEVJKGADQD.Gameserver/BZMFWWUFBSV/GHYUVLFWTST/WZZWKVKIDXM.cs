using System.Net;
using FBEVJKGADQD.Kcp;

namespace FBEVJKGADQD.Gameserver.BZMFWWUFBSV.GHYUVLFWTST;
internal class WZZWKVKIDXM : SYAFWYEJLLL
{
    public IPEndPoint RemoteEndPoint { get; }

    private readonly KcpConversation CIFLISMQRII;

    public WZZWKVKIDXM(KcpConversation HXCPDABTZZN, IPEndPoint remoteEndPoint)
    {
        CIFLISMQRII = HXCPDABTZZN;
        RemoteEndPoint = remoteEndPoint;
    }

    public async ValueTask<int> GQXRZIBMRJU(Memory<byte> OCDSIELOZKK, CancellationToken SDKCGJXNFBJ)
    {
        KcpConversationReceiveResult XHAVGFLHOMM = await CIFLISMQRII.ReceiveAsync(OCDSIELOZKK, SDKCGJXNFBJ);
        if (XHAVGFLHOMM.TransportClosed)
            return -1;

        return XHAVGFLHOMM.BytesReceived;
    }

    public async ValueTask XAEFRTNKUYB(Memory<byte> OCDSIELOZKK, CancellationToken SDKCGJXNFBJ)
    {
        await CIFLISMQRII.SendAsync(OCDSIELOZKK, SDKCGJXNFBJ);
    }

    public void Dispose()
    {
        CIFLISMQRII.Dispose();
    }
}
