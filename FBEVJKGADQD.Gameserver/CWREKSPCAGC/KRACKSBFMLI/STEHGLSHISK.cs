using FBEVJKGADQD.Protocol;

namespace FBEVJKGADQD.Gameserver.CWREKSPCAGC.KRACKSBFMLI;
internal abstract class STEHGLSHISK
{
    public abstract ProtEntityType JGWAPQTJGFY { get; }

    public uint AEAYQZSYNKB { get; }
    public MotionInfo MotionInfo { get; set; }
    public List<PropValue> RGMNCYUUMUM { get; set; }
    public List<FightPropPair> CPNXKHAIZOI { get; set; }

    public STEHGLSHISK(uint entityId)
    {
        AEAYQZSYNKB = ((uint)JGWAPQTJGFY << 24) + entityId;

        MotionInfo = new() { Pos = new(), Rot = new(), Speed = new() };
        RGMNCYUUMUM = new();
        CPNXKHAIZOI = new();
    }

    public void ZIMNCFKYUDR(float HKMSKCTCIJT, float EAPOLVRGDLH, float AJHMDDNOKNF)
    {
        MotionInfo.Pos.X = HKMSKCTCIJT;
        MotionInfo.Pos.Y = EAPOLVRGDLH;
        MotionInfo.Pos.Z = AJHMDDNOKNF;
    }

    public void SetRotation(float HKMSKCTCIJT, float EAPOLVRGDLH, float AJHMDDNOKNF)
    {
        MotionInfo.Rot.X = HKMSKCTCIJT;
        MotionInfo.Rot.Y = EAPOLVRGDLH;
        MotionInfo.Rot.Z = AJHMDDNOKNF;
    }

    public virtual SceneEntityInfo LNENQKAQFVT()
    {
        SceneEntityInfo YJWEQUBQLOJ = new()
        {
            EntityType = JGWAPQTJGFY,
            EntityId = AEAYQZSYNKB,
            MotionInfo = MotionInfo,
            LifeState = 1,
            EntityClientData = new(),
            EntityAuthorityInfo = new EntityAuthorityInfo
            {
                AbilityInfo = new(),
                AiInfo = new()
                {
                    IsAiOpen = true,
                    BornPos = new()
                },
                BornPos = new(),
                ClientExtraInfo = new(),
                RendererChangedInfo = new()
            },
            AnimatorParaList = { new AnimatorParameterValueInfoPair() }
        };

        foreach (PropValue prop in RGMNCYUUMUM)
        {
            YJWEQUBQLOJ.PropList.Add(new PropPair { Type = prop.Type, PropValue = prop });
        }

        YJWEQUBQLOJ.FightPropList.AddRange(CPNXKHAIZOI);

        return YJWEQUBQLOJ;
    }
}
