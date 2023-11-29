using FBEVJKGADQD.Gameserver.NMIJCSMNYNB.XVIQQDCPLZW;
using FBEVJKGADQD.Gameserver.CWREKSPCAGC;
using FBEVJKGADQD.Gameserver.CWREKSPCAGC.BCAKFGQBSST;
using FBEVJKGADQD.Gameserver.CWREKSPCAGC.MAFLNNQAYHC;
using FBEVJKGADQD.Protocol;
using FBEVJKGADQD.Common.YUXWZXWOYDB;
using FBEVJKGADQD.Common.OPLZFFRUAJP;
using FBEVJKGADQD.Gameserver.NMIJCSMNYNB.HWKZPLJYJSU;
using FBEVJKGADQD.Gameserver.BZMFWWUFBSV.EQFCMTVSDKR;

namespace FBEVJKGADQD.Gameserver.NMIJCSMNYNB;

[NetController]
internal class PRLNPZWWZNQ : FURINATHIGH
{
    [NetCommand(TVSUXQOGQCR.GetPlayerTokenReq)]
    public ValueTask<PBWRXELQMPB> OnGetPlayerTokenReq()
    {
        return ValueTask.FromResult(LZEEXCHJVNT(TVSUXQOGQCR.GetPlayerTokenRsp, new GetPlayerTokenRsp
        {
            ServerRandKey = Convert.ToBase64String(FHFWWIHCNVD.JRENKFLHPQK(new byte[8])),
            Sign = string.Empty, // bypassed
            Uid = 1337,
            CountryCode = "RU",
            PlatformType = 3
        }));
    }

    [NetCommand(TVSUXQOGQCR.PingReq)]
    public ValueTask<PBWRXELQMPB> OnPingReq()
    {
        return ValueTask.FromResult(LZEEXCHJVNT(TVSUXQOGQCR.PingRsp, new PingRsp
        {
            ServerTime = (uint)DateTimeOffset.Now.ToUnixTimeSeconds()
        }));
    }

    [NetCommand(TVSUXQOGQCR.PlayerLoginReq)]
    public async ValueTask<PBWRXELQMPB> OnPlayerLoginReq(DFBYQXKCXCF GFVKYXOWYMX, WUVNKLLTRWM player, FKVGHBHFSFE sceneManager)
    {
        player.NPVQRRZJCUQ();

        await GFVKYXOWYMX.SEBRUKUCPXQ(TVSUXQOGQCR.PlayerDataNotify, new PlayerDataNotify
        {
            NickName = player.QPUUYOLARFY,
            PropMap =
            {
                {CDEURSQUOMB.PROP_PLAYER_LEVEL, new() { Type = CDEURSQUOMB.PROP_PLAYER_LEVEL, Ival = 5 } },
                {CDEURSQUOMB.PROP_IS_FLYABLE, new() { Type = CDEURSQUOMB.PROP_IS_FLYABLE, Ival = 1 } },
                {CDEURSQUOMB.PROP_MAX_STAMINA, new() { Type = CDEURSQUOMB.PROP_MAX_STAMINA, Ival = 10000 } },
                {CDEURSQUOMB.PROP_CUR_PERSIST_STAMINA, new() { Type = CDEURSQUOMB.PROP_CUR_PERSIST_STAMINA, Ival = 10000 } },
                {CDEURSQUOMB.PROP_IS_TRANSFERABLE, new() { Type = CDEURSQUOMB.PROP_IS_TRANSFERABLE, Ival = 1 } },
                {CDEURSQUOMB.PROP_IS_SPRING_AUTO_USE, new() { Type = CDEURSQUOMB.PROP_IS_SPRING_AUTO_USE, Ival = 1 } },
                {CDEURSQUOMB.PROP_SPRING_AUTO_USE_PERCENT, new() { Type = CDEURSQUOMB.PROP_SPRING_AUTO_USE_PERCENT, Ival = 50 } }
            }
        });

        AvatarDataNotify avatarDataNotify = new()
        {
            CurAvatarTeamId = player.GNPDJXJCSVI,
            ChooseAvatarGuid = 228
        };

        foreach (NXBLJJGQFZU MLWDJIMREEA in player.FAJYTETSNJD)
        {
            avatarDataNotify.AvatarList.Add(MLWDJIMREEA.UIQUQKLEGSS());
        }

        foreach (DSWBMOUPPDF team in player.ELQQTQEXCNB)
        {
            AvatarTeam avatarTeam = new();
            avatarTeam.AvatarGuidList.AddRange(team.AvatarGuidList);

            avatarDataNotify.AvatarTeamMap.Add(team.Index, avatarTeam);
        }

        await GFVKYXOWYMX.SEBRUKUCPXQ(TVSUXQOGQCR.AvatarDataNotify, avatarDataNotify);

        await GFVKYXOWYMX.SEBRUKUCPXQ(TVSUXQOGQCR.OpenStateUpdateNotify, new OpenStateUpdateNotify
        {
            OpenStateMap =
            {
                {1, 1},
                {2, 1},
                {3, 1},
                {4, 1},
                {5, 1},
                {6, 1},
                {7, 0},
                {8, 1},
                {10, 1},
                {11, 1},
                {12, 1},
                {13, 1},
                {14, 1},
                {15, 1},
                {27, 1},
                {28, 1},
                {29, 1},
                {30, 1},
                {31, 1},
                {32, 1},
                {33, 1},
                {37, 1},
                {38, 1},
                {45, 1},
                {47, 1},
                {53, 1},
                {54, 1},
                {55, 1},
                {59, 1},
                {62, 1},
                {65, 1},
                {900, 1},
                {901, 1},
                {902, 1},
                {903, 1},
                {1001, 1},
                {1002, 1},
                {1003, 1},
                {1004, 1},
                {1005, 1},
                {1007, 1},
                {1008, 1},
                {1009, 1},
                {1010, 1},
                {1100, 1},
                {1103, 1},
                {1300, 1},
                {1401, 1},
                {1403, 1},
                {1700, 1},
                {2100, 1},
                {2101, 1},
                {2103, 1},
                {2400, 1},
                {3701, 1},
                {3702, 1},
                {4100, 1 }
            }
        });

        await sceneManager.EnterSceneAsync(3);

        return LZEEXCHJVNT(TVSUXQOGQCR.PlayerLoginRsp, new PlayerLoginRsp
        {
            CountryCode = "RU",
            GameBiz = "hk4e_global",
            ResVersionConfig = new()
        });
    }
}
