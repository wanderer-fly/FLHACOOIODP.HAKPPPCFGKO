using FBEVJKGADQD.Common.HSFCATOPDTI.GLYMTKISXFZ;
using FBEVJKGADQD.Common.YUXWZXWOYDB;
using FBEVJKGADQD.Protocol;

namespace FBEVJKGADQD.Gameserver.CWREKSPCAGC.MAFLNNQAYHC;
internal class NXBLJJGQFZU
{
    public const ulong FVLALHGSKKL = 2281337;

    public ulong CRQCMKGRYKA { get; set; }

    public uint OEMENJXWSCW { get; set; }
    public uint RVKFENDZJIS { get; set; }
    public uint DETIOEPROBJ { get; set; }
    public uint QQSAIAPXFYX { get; set; }

    public uint OFBMZWSIPUC { get; set; } // TODO: Weapon class!

    // Properties
    public List<PropValue> RGMNCYUUMUM;
    public List<FightPropPair> CPNXKHAIZOI;

    public NXBLJJGQFZU()
    {
        RGMNCYUUMUM = new List<PropValue>();
        CPNXKHAIZOI = new List<FightPropPair>();
    }

    public void InitDefaultProps(ODIHMTKVNLI avatarExcel)
    {
        RGMNCYUUMUM.Clear();
        CPNXKHAIZOI.Clear();

        SetProp(CDEURSQUOMB.PROP_LEVEL, 1);
        SetProp(CDEURSQUOMB.PROP_EXP, 0);
        SetProp(CDEURSQUOMB.PROP_BREAK_LEVEL, 0);

        float baseHp = (float)avatarExcel.HpBase;
        float baseAttack = (float)avatarExcel.AttackBase;
        float baseDefense = (float)avatarExcel.DefenseBase;

        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_BASE_HP, baseHp);
        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_CUR_HP, baseHp);
        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_MAX_HP, baseHp);

        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_BASE_ATTACK, baseAttack);
        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_CUR_ATTACK, baseAttack);

        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_BASE_DEFENSE, baseDefense);
        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_CUR_DEFENSE, baseDefense);

        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_CHARGE_EFFICIENCY, (float)avatarExcel.ChargeEfficiency);
        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_CRITICAL_HURT, (float)avatarExcel.CriticalHurt);
        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_CRITICAL, (float)avatarExcel.Critical);

        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_CUR_FIRE_ENERGY, 100);
        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_CUR_ELEC_ENERGY, 100);
        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_CUR_WATER_ENERGY, 100);
        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_CUR_GRASS_ENERGY, 100);
        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_CUR_WIND_ENERGY, 100);
        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_CUR_ICE_ENERGY, 100);
        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_CUR_ROCK_ENERGY, 100);
        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_MAX_FIRE_ENERGY, 100);
        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_MAX_ELEC_ENERGY, 100);
        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_MAX_WATER_ENERGY, 100);
        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_MAX_GRASS_ENERGY, 100);
        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_MAX_WIND_ENERGY, 100);
        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_MAX_ICE_ENERGY, 100);
        SetFightProp(UXKKLBWCOUA.FIGHT_PROP_MAX_ROCK_ENERGY, 100);
    }

    public void SetProp(uint propType, uint value)
    {
        PropValue? prop = RGMNCYUUMUM.Find(p => p.Type == propType);
        if (prop != null)
        {
            prop.Ival = value;
            return;
        }

        RGMNCYUUMUM.Add(new PropValue { Type = propType, Ival = value });
    }

    public void SetProp(uint propType, float value)
    {
        PropValue? prop = RGMNCYUUMUM.Find(p => p.Type == propType);
        if (prop != null)
        {
            prop.Fval = value;
            return;
        }

        RGMNCYUUMUM.Add(new PropValue { Type = propType, Fval = value });
    }

    public void SetFightProp(uint propType, float value)
    {
        FightPropPair? fightPropPair = CPNXKHAIZOI.Find(pair => pair.PropType == propType);
        if (fightPropPair != null)
        {
            fightPropPair.PropValue = value;
            return;
        }

        CPNXKHAIZOI.Add(new FightPropPair { PropType = propType, PropValue = value });
    }

    public AvatarInfo UIQUQKLEGSS()
    {
        AvatarInfo YJWEQUBQLOJ = new()
        {
            Guid = CRQCMKGRYKA,
            AvatarId = OEMENJXWSCW,
            SkillDepotId = RVKFENDZJIS,
            LifeState = 1,
            AvatarType = 1,
            WearingFlycloakId = DETIOEPROBJ,
            BornTime = QQSAIAPXFYX,
            FetterInfo = new() { ExpLevel = 1 },
            EquipGuidList = { FVLALHGSKKL } // no weapon classes for now
        };

        foreach (PropValue prop in RGMNCYUUMUM)
        {
            YJWEQUBQLOJ.PropMap.Add(prop.Type, prop);
        }

        foreach (FightPropPair pair in CPNXKHAIZOI)
        {
            YJWEQUBQLOJ.FightPropMap.Add(pair.PropType, pair.PropValue);
        }

        return YJWEQUBQLOJ;
    }
}
