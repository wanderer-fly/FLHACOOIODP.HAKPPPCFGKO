using FBEVJKGADQD.Gameserver.NMIJCSMNYNB.XVIQQDCPLZW;
using FBEVJKGADQD.Gameserver.CWREKSPCAGC.BCAKFGQBSST;
using FBEVJKGADQD.Protocol;
using FBEVJKGADQD.Gameserver.NMIJCSMNYNB.HWKZPLJYJSU;
using FBEVJKGADQD.Gameserver.BZMFWWUFBSV.EQFCMTVSDKR;

namespace FBEVJKGADQD.Gameserver.NMIJCSMNYNB;

[NetController]
internal class OGBZLNPWBQU : FURINATHIGH
{
    [NetCommand(TVSUXQOGQCR.SetUpAvatarTeamReq)]
    public async ValueTask<PBWRXELQMPB> OnSetUpAvatarTeamReq(DFBYQXKCXCF GFVKYXOWYMX, FKVGHBHFSFE sceneManager)
    {
        SetUpAvatarTeamReq request = Packet!.RZBCLFFYJWG<SetUpAvatarTeamReq>();

        AvatarTeam newTeam = new();
        newTeam.AvatarGuidList.AddRange(request.AvatarTeamGuidList);
        await GFVKYXOWYMX.SEBRUKUCPXQ(TVSUXQOGQCR.AvatarTeamUpdateNotify, new AvatarTeamUpdateNotify
        {
            AvatarTeamMap = { { request.TeamId, newTeam } }
        });

        await sceneManager.ChangeTeamAvatarsAsync(request.AvatarTeamGuidList.ToArray());

        SetUpAvatarTeamRsp response = new()
        {
            CurAvatarGuid = request.CurAvatarGuid,
            TeamId = request.TeamId,
        };
        response.AvatarTeamGuidList.AddRange(request.AvatarTeamGuidList);

        return LZEEXCHJVNT(TVSUXQOGQCR.SetUpAvatarTeamRsp, response);
    }
}
