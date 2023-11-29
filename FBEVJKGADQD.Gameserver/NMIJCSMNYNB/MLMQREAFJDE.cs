using FBEVJKGADQD.Gameserver.NMIJCSMNYNB.XVIQQDCPLZW;
using FBEVJKGADQD.Gameserver.CWREKSPCAGC.BCAKFGQBSST;
using FBEVJKGADQD.Protocol;
using FBEVJKGADQD.Gameserver.NMIJCSMNYNB.HWKZPLJYJSU;

namespace FBEVJKGADQD.Gameserver.NMIJCSMNYNB;

[NetController]
internal class MLMQREAFJDE : FURINATHIGH
{
    // TODO: Scene management, Entity management!!!
    public const uint WeaponEntityId = 100663300;

    [NetCommand(TVSUXQOGQCR.PostEnterSceneReq)]
    public async ValueTask<PBWRXELQMPB> OnPostEnterSceneReq(FKVGHBHFSFE WXKLIQRSHAU)
    {
        await WXKLIQRSHAU.JZNZOHQWZXS(FWSWKZQZXLU.RLCKYUDSIED);

        return LZEEXCHJVNT(TVSUXQOGQCR.PostEnterSceneRsp, new PostEnterSceneRsp
        {
            EnterSceneToken = WXKLIQRSHAU.ZAOMSUBJTSH
        });
    }

    [NetCommand(TVSUXQOGQCR.EnterSceneDoneReq)]
    public async ValueTask<PBWRXELQMPB> OnEnterSceneDoneReq(FKVGHBHFSFE WXKLIQRSHAU)
    {
        await WXKLIQRSHAU.JZNZOHQWZXS(FWSWKZQZXLU.NMLHJMGQQYY);

        return LZEEXCHJVNT(TVSUXQOGQCR.EnterSceneDoneRsp, new EnterSceneDoneRsp
        {
            EnterSceneToken = WXKLIQRSHAU.ZAOMSUBJTSH
        });
    }

    [NetCommand(TVSUXQOGQCR.SceneInitFinishReq)]
    public async ValueTask<PBWRXELQMPB> OnSceneInitFinishReq(FKVGHBHFSFE WXKLIQRSHAU)
    {
        await WXKLIQRSHAU.JZNZOHQWZXS(FWSWKZQZXLU.KLPDQHGVWOR);

        return LZEEXCHJVNT(TVSUXQOGQCR.SceneInitFinishRsp, new SceneInitFinishRsp
        {
            EnterSceneToken = WXKLIQRSHAU.ZAOMSUBJTSH
        });
    }

    [NetCommand(TVSUXQOGQCR.EnterSceneReadyReq)]
    public async ValueTask<PBWRXELQMPB> OnEnterSceneReadyReq(FKVGHBHFSFE WXKLIQRSHAU)
    {
        await WXKLIQRSHAU.JZNZOHQWZXS(FWSWKZQZXLU.CLCQXJBBSYK);

        return LZEEXCHJVNT(TVSUXQOGQCR.EnterSceneReadyRsp, new EnterSceneReadyRsp
        {
            EnterSceneToken = WXKLIQRSHAU.ZAOMSUBJTSH
        });
    }
}
