using System.Buffers.Binary;
using FBEVJKGADQD.Protocol;
using Google.Protobuf;

namespace FBEVJKGADQD.Gameserver.BZMFWWUFBSV;
internal class LFZRLZCJSQD
{
    private const ushort RWZSCJUPSIJ = 0x4567;
    private const ushort DJWILURJQSO = 0x89AB;

    public TVSUXQOGQCR TVSUXQOGQCR { get; set; }
    public Memory<byte> WSXFVFFAURX { get; set; }
    public Memory<byte> HUNFHOHOEHO { get; set; }

    public TBody RZBCLFFYJWG<TBody>() where TBody : IMessage<TBody>, new()
    {
        return new MessageParser<TBody>(() => new()).ParseFrom(HUNFHOHOEHO.Span);
    }

    public int RRZGFLJPGAM(Memory<byte> OCDSIELOZKK)
    {
        Span<byte> span = OCDSIELOZKK.Span;

        BinaryPrimitives.WriteUInt16BigEndian(span[0..2], RWZSCJUPSIJ);
        BinaryPrimitives.WriteUInt16BigEndian(span[2..4], (ushort)TVSUXQOGQCR);
        BinaryPrimitives.WriteUInt16BigEndian(span[4..6], (ushort)WSXFVFFAURX.Length);
        BinaryPrimitives.WriteInt32BigEndian(span[6..10], HUNFHOHOEHO.Length);
        WSXFVFFAURX.CopyTo(OCDSIELOZKK[10..]);
        HUNFHOHOEHO.CopyTo(OCDSIELOZKK[(10 + WSXFVFFAURX.Length)..]);
        BinaryPrimitives.WriteUInt16BigEndian(span[(10 + WSXFVFFAURX.Length + HUNFHOHOEHO.Length)..], DJWILURJQSO);

        return 12 + WSXFVFFAURX.Length + HUNFHOHOEHO.Length;
    }

    public static (LFZRLZCJSQD?, int) UKACLOYHYAF(Memory<byte> data)
    {
        ReadOnlySpan<byte> span = data.Span;

        ushort headMagic = BinaryPrimitives.ReadUInt16BigEndian(span[0..2]);
        if (headMagic != RWZSCJUPSIJ)
            return (null, 0);

        ushort YTUILIPGEVE = BinaryPrimitives.ReadUInt16BigEndian(span[2..4]);

        int headLength = BinaryPrimitives.ReadUInt16BigEndian(span[4..6]);
        int bodyLength = BinaryPrimitives.ReadInt32BigEndian(span[6..10]);

        if (data.Length < 12 + headLength + bodyLength)
            return (null, 0);

        Memory<byte> head = data.Slice(10, headLength);
        Memory<byte> body = data.Slice(10 + headLength, bodyLength);

        ushort tailMagic = BinaryPrimitives.ReadUInt16BigEndian(span[(10 + headLength + bodyLength)..]);
        if (tailMagic != DJWILURJQSO)
            return (null, 0);

        LFZRLZCJSQD netPacket = new()
        {
            TVSUXQOGQCR = (TVSUXQOGQCR)YTUILIPGEVE,
            WSXFVFFAURX = head,
            HUNFHOHOEHO = body
        };

        return (netPacket, 12 + headLength + bodyLength);
    }
}
