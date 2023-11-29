using System.Buffers.Binary;

namespace FBEVJKGADQD.Gameserver.BZMFWWUFBSV.GHYUVLFWTST;

internal struct SCKFFZDWWSM
{
    public const uint LXUECMNQVPM = 0xFF;
    public const uint SQTDLKXGXJD = 0xFFFFFFFF;

    public const uint RHFZJFTGHBA = 0x00000145;
    public const uint IHTNDUFMBXL = 0x14514545;

    public const uint OKPZUMFKZSO = 0x194;
    public const uint MXIBIPNIWOR = 0x19419494;

    public uint KRAKJGGTLFU { get; set; }
    public uint SXFFXZSNBKL { get; set; }
    public uint XHBIFPWTKPH { get; set; }
    public uint WAZMOQLNYZB { get; set; }
    public uint FKOJWRVZKBN { get; set; }

    public readonly void ZLZEQASFIFJ(Span<byte> OCDSIELOZKK)
    {
        BinaryPrimitives.WriteUInt32BigEndian(OCDSIELOZKK[0..4], KRAKJGGTLFU);
        BinaryPrimitives.WriteUInt32LittleEndian(OCDSIELOZKK[4..8], SXFFXZSNBKL);
        BinaryPrimitives.WriteUInt32LittleEndian(OCDSIELOZKK[8..12], XHBIFPWTKPH);
        BinaryPrimitives.WriteUInt32BigEndian(OCDSIELOZKK[12..16], WAZMOQLNYZB);
        BinaryPrimitives.WriteUInt32BigEndian(OCDSIELOZKK[16..20], FKOJWRVZKBN);
    }

    public static SCKFFZDWWSM XOTAHUXXWMW(ReadOnlySpan<byte> OCDSIELOZKK) => new()
    {
        KRAKJGGTLFU = BinaryPrimitives.ReadUInt32BigEndian(OCDSIELOZKK[0..4]),
        SXFFXZSNBKL = BinaryPrimitives.ReadUInt32LittleEndian(OCDSIELOZKK[4..8]),
        XHBIFPWTKPH = BinaryPrimitives.ReadUInt32LittleEndian(OCDSIELOZKK[8..12]),
        WAZMOQLNYZB = BinaryPrimitives.ReadUInt32BigEndian(OCDSIELOZKK[12..16]),
        FKOJWRVZKBN = BinaryPrimitives.ReadUInt32BigEndian(OCDSIELOZKK[16..20])
    };
}
