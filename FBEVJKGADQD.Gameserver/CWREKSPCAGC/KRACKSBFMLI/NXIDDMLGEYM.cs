using FBEVJKGADQD.Common.HSFCATOPDTI.GNECZXLXXHH;
using FBEVJKGADQD.Common.HSFCATOPDTI.GNECZXLXXHH.FLUXUDBCHNF;
using FBEVJKGADQD.Common.YRXTRTDNVIL;
using FBEVJKGADQD.Common.YUXWZXWOYDB;
using FBEVJKGADQD.Gameserver.CWREKSPCAGC.MAFLNNQAYHC;
using FBEVJKGADQD.Gameserver.NMIJCSMNYNB;
using FBEVJKGADQD.Protocol;

namespace FBEVJKGADQD.Gameserver.CWREKSPCAGC.KRACKSBFMLI;
internal class NXIDDMLGEYM : STEHGLSHISK
{
    public override ProtEntityType JGWAPQTJGFY => ProtEntityType.Avatar;

    public uint Uid { get; }
    public NXBLJJGQFZU GameAvatar { get; }

    public NXIDDMLGEYM(NXBLJJGQFZU MLWDJIMREEA, uint uid, uint entityId) : base(entityId)
    {
        Uid = uid;
        GameAvatar = MLWDJIMREEA;
        RGMNCYUUMUM = MLWDJIMREEA.RGMNCYUUMUM;
        CPNXKHAIZOI = MLWDJIMREEA.CPNXKHAIZOI;
    }

    public AbilityControlBlock BuildAbilityControlBlock(QOAXVAVOKZE binData)
    {
        AbilityControlBlock abilityControlBlock = new();
        WNWAXNOBQJX avatarConfig = binData.GetAvatarConfig(GameAvatar.OEMENJXWSCW);

        uint defaultOverrideHash = "Default".WAVQWYNKDDC();
        foreach (string abilityName in YNGZJIZQIWH.GODCZYXCRRF)
        {
            abilityControlBlock.AbilityEmbryoList.Add(new AbilityEmbryo
            {
                AbilityId = (uint)(abilityControlBlock.AbilityEmbryoList.Count + 1),
                AbilityNameHash = abilityName.WAVQWYNKDDC(),
                AbilityOverrideNameHash = defaultOverrideHash
            });
        }

        foreach (DXHYBXNCVYI ability in avatarConfig.BWGELCZJHHS)
        {
            abilityControlBlock.AbilityEmbryoList.Add(new AbilityEmbryo
            {
                AbilityId = (uint)(abilityControlBlock.AbilityEmbryoList.Count + 1),
                AbilityNameHash = ability.RYIDCRIODTL.WAVQWYNKDDC(),
                AbilityOverrideNameHash = ability.QXYEFMYDHTH().WAVQWYNKDDC()
            });
        }

        return abilityControlBlock;
    }

    public override SceneEntityInfo LNENQKAQFVT()
    {
        SceneEntityInfo YJWEQUBQLOJ = base.LNENQKAQFVT();

        YJWEQUBQLOJ.Avatar = new()
        {
            Uid = Uid,
            AvatarId = GameAvatar.OEMENJXWSCW,
            Guid = GameAvatar.CRQCMKGRYKA,
            PeerId = 1,
            EquipIdList = { GameAvatar.OFBMZWSIPUC },
            SkillDepotId = GameAvatar.RVKFENDZJIS,
            Weapon = new SceneWeaponInfo
            {
                EntityId = MLMQREAFJDE.WeaponEntityId,
                GadgetId = 50000000 + GameAvatar.OFBMZWSIPUC,
                ItemId = GameAvatar.OFBMZWSIPUC,
                Guid = NXBLJJGQFZU.FVLALHGSKKL,
                Level = 1,
                PromoteLevel = 0,
                AbilityInfo = new()
            },
            CoreProudSkillLevel = 0,
            InherentProudSkillList = { 832301 },
            SkillLevelMap =
            {
                { 10832, 1 },
                { 10835, 1 },
                { 10831, 1 }
            },
            ProudSkillExtraLevelMap =
            {
                { 8331, 0 },
                { 8332, 0 },
                { 8339, 0 }
            },
            TeamResonanceList = { 10301 },
            WearingFlycloakId = GameAvatar.DETIOEPROBJ,
            BornTime = GameAvatar.QQSAIAPXFYX,
            CostumeId = 0,
            AnimHash = 0
        };

        return YJWEQUBQLOJ;
    }
}
