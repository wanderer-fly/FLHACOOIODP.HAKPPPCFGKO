using System.Numerics;
using FBEVJKGADQD.Common.HSFCATOPDTI.GNECZXLXXHH;
using FBEVJKGADQD.Gameserver.BZMFWWUFBSV.EQFCMTVSDKR;
using FBEVJKGADQD.Gameserver.CWREKSPCAGC.KRACKSBFMLI;
using FBEVJKGADQD.Gameserver.CWREKSPCAGC.KRACKSBFMLI.XSUUHMCVMKJ;
using FBEVJKGADQD.Gameserver.CWREKSPCAGC.MAFLNNQAYHC;
using FBEVJKGADQD.Gameserver.NMIJCSMNYNB;
using FBEVJKGADQD.Protocol;

namespace FBEVJKGADQD.Gameserver.CWREKSPCAGC.BCAKFGQBSST;
internal class FKVGHBHFSFE
{
    public uint ZAOMSUBJTSH { get; private set; }

    private readonly QOAXVAVOKZE _binData;

    private readonly DFBYQXKCXCF _session;
    private readonly WUVNKLLTRWM _player;
    private readonly DMMIOUNBHHF _entityManager;
    private readonly NJKLKSSIKNA _entityFactory;

    private readonly List<NXIDDMLGEYM> _teamAvatars;

    private uint _enterTokenSeed;
    private uint _sceneId;
    private ulong _beginTime;

    private FWSWKZQZXLU NIPPJTYBQDZ;

    public FKVGHBHFSFE(DFBYQXKCXCF GFVKYXOWYMX, WUVNKLLTRWM player, DMMIOUNBHHF entityManager, NJKLKSSIKNA entityFactory, QOAXVAVOKZE binData)
    {
        _session = GFVKYXOWYMX;
        _player = player;
        _entityManager = entityManager;
        _entityFactory = entityFactory;

        _binData = binData;
        _teamAvatars = new();
    }

    public async ValueTask JZNZOHQWZXS(FWSWKZQZXLU ALUYZAPMMLX)
    {
        if (NIPPJTYBQDZ is FWSWKZQZXLU.AZXHLFDMFVR or FWSWKZQZXLU.BSMYIXKHASA)
            throw new InvalidOperationException($"SceneManager::OnEnterStateChanged called when enter state is {NIPPJTYBQDZ}!");

        if (NIPPJTYBQDZ > ALUYZAPMMLX)
            throw new ArgumentException($"SceneManager::OnEnterStateChanged - requested state is less than current! (curr={NIPPJTYBQDZ}, req={ALUYZAPMMLX})");

        if (NIPPJTYBQDZ + 1 != ALUYZAPMMLX)
            throw new ArgumentException($"SceneManager::OnEnterStateChanged - trying to skip enter state! (curr={NIPPJTYBQDZ}, req={ALUYZAPMMLX})");

        NIPPJTYBQDZ = ALUYZAPMMLX;
        switch (NIPPJTYBQDZ)
        {
            case FWSWKZQZXLU.CLCQXJBBSYK:
                await BIGFBKXSZLQ();
                break;
            case FWSWKZQZXLU.KLPDQHGVWOR:
                await IEFJFPJHSQL();
                break;
            case FWSWKZQZXLU.NMLHJMGQQYY:
                await UEMKBUHHARA();
                break;
            case FWSWKZQZXLU.RLCKYUDSIED:
                await JCCVTCWEAOB();
                break;
        }

        if (NIPPJTYBQDZ == FWSWKZQZXLU.RLCKYUDSIED)
            NIPPJTYBQDZ = FWSWKZQZXLU.BSMYIXKHASA;
    }

    public async ValueTask ChangeTeamAvatarsAsync(ulong[] guidList)
    {
        _teamAvatars.Clear();

        foreach (ulong guid in guidList)
        {
            NXBLJJGQFZU MLWDJIMREEA = _player.FAJYTETSNJD.Find(avatar => avatar.CRQCMKGRYKA == guid)!; // currently only first one

            NXIDDMLGEYM avatarEntity = _entityFactory.OGYPYOJHSJZ(MLWDJIMREEA, _player.EZKCVCMNODH);
            avatarEntity.ZIMNCFKYUDR(2336.789f, 249.98896f, -751.3081f);

            _teamAvatars.Add(avatarEntity);
        }

        await SendSceneTeamUpdate();
        await _entityManager.DIYWDVHLPFT(_teamAvatars[0], VisionType.Born);
    }

    private async ValueTask UEMKBUHHARA()
    {
        await _entityManager.DIYWDVHLPFT(_teamAvatars[0], VisionType.Born);
    }

    private async ValueTask IEFJFPJHSQL()
    {
        DSWBMOUPPDF avatarTeam = _player.GetCurrentTeam();

        foreach (ulong guid in avatarTeam.AvatarGuidList)
        {
            NXBLJJGQFZU MLWDJIMREEA = _player.FAJYTETSNJD.Find(avatar => avatar.CRQCMKGRYKA == guid)!;

            NXIDDMLGEYM avatarEntity = _entityFactory.OGYPYOJHSJZ(MLWDJIMREEA, _player.EZKCVCMNODH);
            avatarEntity.ZIMNCFKYUDR(2336.789f, 249.98896f, -751.3081f);

            _teamAvatars.Add(avatarEntity);
        }

        await SendEnterSceneInfo();
        await SendSceneTeamUpdate();
    }

    private async ValueTask BIGFBKXSZLQ()
    {
        await _session.SEBRUKUCPXQ(TVSUXQOGQCR.EnterScenePeerNotify, new EnterScenePeerNotify
        {
            DestSceneId = _sceneId,
            EnterSceneToken = ZAOMSUBJTSH,
            HostPeerId = 1, // TODO: Scene peers
            PeerId = 1
        });
    }

    private ValueTask JCCVTCWEAOB()
    {
        return ValueTask.CompletedTask;
    }

    public async ValueTask EnterSceneAsync(uint sceneId)
    {
        if (_beginTime != 0) ResetState();

        _beginTime = (ulong)DateTimeOffset.Now.ToUnixTimeSeconds();
        _sceneId = sceneId;
        ZAOMSUBJTSH = ++_enterTokenSeed;

        NIPPJTYBQDZ = FWSWKZQZXLU.QAGNTENJYPG;
        await _session.SEBRUKUCPXQ(TVSUXQOGQCR.PlayerEnterSceneNotify, new PlayerEnterSceneNotify
        {
            SceneBeginTime = _beginTime,
            SceneId = _sceneId,
            SceneTransaction = CreateTransaction(_sceneId, _player.EZKCVCMNODH, _beginTime),
            Pos = new()
            {
                X = 2191.16357421875f,
                Y = 214.65115356445312f,
                Z = -1120.633056640625f
            },
            TargetUid = _player.EZKCVCMNODH,
            UnkUid1020 = _player.EZKCVCMNODH,
            EnterSceneToken = ZAOMSUBJTSH,
            PrevPos = new(),
            Unk13 = 1,
            Unk3 = 1,
            Unk449 = 1,
            Unk834 = 1
        });
    }

    private async ValueTask SendSceneTeamUpdate()
    {
        SceneTeamUpdateNotify sceneTeamUpdate = new();
        foreach (NXIDDMLGEYM avatar in _teamAvatars)
        {
            sceneTeamUpdate.SceneTeamAvatarList.Add(new SceneTeamAvatar
            {
                SceneEntityInfo = avatar.LNENQKAQFVT(),
                WeaponEntityId = MLMQREAFJDE.WeaponEntityId,
                PlayerUid = _player.EZKCVCMNODH,
                WeaponGuid = NXBLJJGQFZU.FVLALHGSKKL,
                EntityId = avatar.AEAYQZSYNKB,
                AvatarGuid = avatar.GameAvatar.CRQCMKGRYKA,
                AbilityControlBlock = avatar.BuildAbilityControlBlock(_binData),
                SceneId = _sceneId
            });
        }

        await _session.SEBRUKUCPXQ(TVSUXQOGQCR.SceneTeamUpdateNotify, sceneTeamUpdate);
    }

    private async ValueTask SendEnterSceneInfo()
    {
        PlayerEnterSceneInfoNotify enterSceneInfo = new()
        {
            CurAvatarEntityId = _teamAvatars[0].AEAYQZSYNKB,
            EnterSceneToken = ZAOMSUBJTSH,
            MpLevelEntityInfo = new MPLevelEntityInfo
            {
                EntityId = 184549377,
                AbilityInfo = new AbilitySyncStateInfo(),
                AuthorityPeerId = 1
            },
            TeamEnterInfo = new TeamEnterSceneInfo
            {
                TeamEntityId = 150994946,
                AbilityControlBlock = new AbilityControlBlock(),
                TeamAbilityInfo = new AbilitySyncStateInfo()
            }
        };

        foreach (NXIDDMLGEYM avatar in _teamAvatars)
        {
            enterSceneInfo.AvatarEnterInfo.Add(new AvatarEnterSceneInfo
            {
                AvatarGuid = avatar.GameAvatar.CRQCMKGRYKA,
                AvatarEntityId = avatar.AEAYQZSYNKB,
                WeaponEntityId = MLMQREAFJDE.WeaponEntityId,
                WeaponGuid = NXBLJJGQFZU.FVLALHGSKKL
            });
        }

        await _session.SEBRUKUCPXQ(TVSUXQOGQCR.PlayerEnterSceneInfoNotify, enterSceneInfo);
    }

    private void ResetState()
    {
        _teamAvatars.Clear();
        _entityManager.CUAMXWEBJIZ();
    }

    private static string CreateTransaction(uint sceneId, uint playerUid, ulong beginTime)
        => string.Format("{0}-{1}-{2}-13830", sceneId, playerUid, beginTime);
}
