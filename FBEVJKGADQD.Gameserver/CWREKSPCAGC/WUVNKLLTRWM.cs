using System.Diagnostics.CodeAnalysis;
using FBEVJKGADQD.Common.HSFCATOPDTI.GLYMTKISXFZ;
using FBEVJKGADQD.Gameserver.CWREKSPCAGC.MAFLNNQAYHC;

namespace FBEVJKGADQD.Gameserver.CWREKSPCAGC;
internal class WUVNKLLTRWM
{
    private static readonly uint[] AvatarBlackList = { 10000001, 10000005, 10000007 }; // kate and travelers

    public uint EZKCVCMNODH { get; set; }
    public uint TZLEJBBDKBJ { get; set; }
    public string QPUUYOLARFY { get; set; }

    public List<NXBLJJGQFZU> FAJYTETSNJD { get; set; }
    public List<DSWBMOUPPDF> ELQQTQEXCNB { get; set; }
    public uint GNPDJXJCSVI { get; set; }

    private readonly SDDKEYJXNVG CVFDWAALVNZ;

    public WUVNKLLTRWM(SDDKEYJXNVG QQNFYHOZYAM)
    {
        QPUUYOLARFY = "Traveler";
        FAJYTETSNJD = new();
        ELQQTQEXCNB = new();

        CVFDWAALVNZ = QQNFYHOZYAM;
    }

    public void NPVQRRZJCUQ()
    {
        // We don't have database atm, so let's init default player state for every GFVKYXOWYMX.

        EZKCVCMNODH = 1337;
        QPUUYOLARFY = "FBEVJKGADQD";

        GSSMSSJTASP();

        _ = TryGetAvatar(10000089, out NXBLJJGQFZU? avatar);
        ELQQTQEXCNB.Add(new()
        {
            AvatarGuidList = new() { avatar!.CRQCMKGRYKA },
            Index = 1
        });
        GNPDJXJCSVI = 1;
    }

    public DSWBMOUPPDF GetCurrentTeam()
        => ELQQTQEXCNB.Find(team => team.Index == GNPDJXJCSVI)!;

    public bool TryGetAvatar(uint avatarId, [MaybeNullWhen(false)] out NXBLJJGQFZU avatar)
        => (avatar = FAJYTETSNJD.Find(a => a.OEMENJXWSCW == avatarId)) != null;

    private void GSSMSSJTASP()
    {
        QKFYSCAUMKI avatarTable = CVFDWAALVNZ.JJLNQGYJBSM(HFAKDWBWHWS.Avatar);
        for (int YSWNSSRBFAR = 0; YSWNSSRBFAR < avatarTable.Count; YSWNSSRBFAR++)
        {
            ODIHMTKVNLI avatarExcel = avatarTable.MSAVBFJJNLH<ODIHMTKVNLI>(YSWNSSRBFAR);
            if (AvatarBlackList.Contains(avatarExcel.Id) || avatarExcel.Id >= 11000000) continue;

            uint currentTimestamp = (uint)DateTimeOffset.Now.ToUnixTimeSeconds();
            NXBLJJGQFZU avatar = new()
            {
                OEMENJXWSCW = avatarExcel.Id,
                RVKFENDZJIS = avatarExcel.SkillDepotId,
                OFBMZWSIPUC = avatarExcel.InitialWeapon,
                QQSAIAPXFYX = currentTimestamp,
                CRQCMKGRYKA = NextGuid(),
                DETIOEPROBJ = 140001
            };

            avatar.InitDefaultProps(avatarExcel);
            FAJYTETSNJD.Add(avatar);
        }
    }

    public ulong NextGuid()
    {
        return ((ulong)EZKCVCMNODH << 32) + (++TZLEJBBDKBJ);
    }
}
