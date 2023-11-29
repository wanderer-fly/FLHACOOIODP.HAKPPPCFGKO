using System.Collections.Immutable;
using System.Text.Json;

namespace FBEVJKGADQD.Common.HSFCATOPDTI.GLYMTKISXFZ;
public class QKFYSCAUMKI
{
    public int Count => LIRUVDDJNSA.Length;
    private readonly ImmutableArray<KMMALPJLGVE> LIRUVDDJNSA;

    public QKFYSCAUMKI(JsonDocument UCSDCHSKAHH, Type IPWSZYUVUCX)
    {
        LIRUVDDJNSA = SFGEPMWWRCI(UCSDCHSKAHH, IPWSZYUVUCX);
    }

    private static ImmutableArray<KMMALPJLGVE> SFGEPMWWRCI(JsonDocument UCSDCHSKAHH, Type IPWSZYUVUCX)
    {
        ImmutableArray<KMMALPJLGVE>.Builder GZSGHNWOVDE = ImmutableArray.CreateBuilder<KMMALPJLGVE>();

        foreach (JsonElement WUBBWPMWONQ in UCSDCHSKAHH.RootElement.EnumerateArray())
        {
            if (WUBBWPMWONQ.ValueKind != JsonValueKind.Object)
                throw new ArgumentException($"ExcelTable::LoadData - expected an object, got {WUBBWPMWONQ.ValueKind}");

            KMMALPJLGVE WSVUZQPFPGG = (WUBBWPMWONQ.Deserialize(IPWSZYUVUCX) as KMMALPJLGVE)!;
            GZSGHNWOVDE.Add(WSVUZQPFPGG);
        }

        return GZSGHNWOVDE.ToImmutable();
    }

    public TExcel MSAVBFJJNLH<TExcel>(int index) where TExcel : KMMALPJLGVE
    {
        return (LIRUVDDJNSA[index] as TExcel)!;
    }

    public TExcel? FHXRQICPIBV<TExcel>(uint id) where TExcel : KMMALPJLGVE
    {
        foreach (KMMALPJLGVE item in LIRUVDDJNSA)
        {
            if (item.WHFKJCDCEGC == id)
                return item as TExcel;
        }

        return null;
    }
}
