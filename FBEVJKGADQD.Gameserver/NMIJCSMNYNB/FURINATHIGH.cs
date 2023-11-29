using FBEVJKGADQD.Gameserver.BZMFWWUFBSV;
using FBEVJKGADQD.Gameserver.NMIJCSMNYNB.HWKZPLJYJSU;
using FBEVJKGADQD.Protocol;
using Google.Protobuf;

namespace FBEVJKGADQD.Gameserver.NMIJCSMNYNB;
internal abstract class FURINATHIGH
{
    public LFZRLZCJSQD? Packet { get; set; }

    protected PBWRXELQMPB Ok()
    {
        return new PJBUHDULKHU(null);
    }

    protected PBWRXELQMPB LZEEXCHJVNT<TMessage>(TVSUXQOGQCR YTUILIPGEVE, TMessage message) where TMessage : IMessage
    {
        return new PJBUHDULKHU(new()
        {
            TVSUXQOGQCR = YTUILIPGEVE,
            WSXFVFFAURX = Memory<byte>.Empty,
            HUNFHOHOEHO = message.ToByteArray()
        });
    }
}
