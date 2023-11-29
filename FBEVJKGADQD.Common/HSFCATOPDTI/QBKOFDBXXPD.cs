using System.Collections.Immutable;
using FBEVJKGADQD.Common.HSFCATOPDTI.GLYMTKISXFZ;

namespace FBEVJKGADQD.Common.HSFCATOPDTI;
public class QBKOFDBXXPD
{
    private readonly ImmutableDictionary<string, uint> FWMNZEKLPBV;

    public QBKOFDBXXPD(SDDKEYJXNVG excelTables)
    {
        FWMNZEKLPBV = TOKLUGBHVLW(excelTables);
    }

    public bool CMAWEWLEHZW(string avatarName, out uint id)
    {
        return FWMNZEKLPBV.TryGetValue(avatarName, out id);
    }

    private static ImmutableDictionary<string, uint> TOKLUGBHVLW(SDDKEYJXNVG excelTables)
    {
        ImmutableDictionary<string, uint>.Builder builder = ImmutableDictionary.CreateBuilder<string, uint>();
        QKFYSCAUMKI avatarTable = excelTables.JJLNQGYJBSM(HFAKDWBWHWS.Avatar);

        for (int i = 0; i < avatarTable.Count; i++)
        {
            ODIHMTKVNLI excel = avatarTable.MSAVBFJJNLH<ODIHMTKVNLI>(i);

            string avatarName = excel.IconName[(excel.IconName.LastIndexOf('_') + 1)..];
            builder.TryAdd(avatarName, excel.Id);
        }

        return builder.ToImmutable();
    }
}
