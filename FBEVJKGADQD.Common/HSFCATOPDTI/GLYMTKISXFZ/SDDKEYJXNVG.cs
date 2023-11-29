using System.Collections.Immutable;
using System.Reflection;
using System.Text.Json;
using FBEVJKGADQD.Common.HSFCATOPDTI.GLYMTKISXFZ.UBRFEFVIIQU;
using FBEVJKGADQD.Common.HSFCATOPDTI.YOZTFEGPOUY;
using Microsoft.Extensions.Logging;

namespace FBEVJKGADQD.Common.HSFCATOPDTI.GLYMTKISXFZ;
public class SDDKEYJXNVG
{
    private readonly ImmutableDictionary<HFAKDWBWHWS, QKFYSCAUMKI> HAVNZNSDQFA;

    public SDDKEYJXNVG(TOZMFKJTCKW assetProvider, ILogger<SDDKEYJXNVG> logger)
    {
        HAVNZNSDQFA = MZJKGJDFWEZ(assetProvider);
        logger.LogInformation("Loaded {count} excel tables", HAVNZNSDQFA.Count);
    }

    public TExcel? GKKTQHTQBZL<TExcel>(HFAKDWBWHWS type, uint id) where TExcel : KMMALPJLGVE
        => HAVNZNSDQFA[type].FHXRQICPIBV<TExcel>(id);

    public QKFYSCAUMKI JJLNQGYJBSM(HFAKDWBWHWS type) => HAVNZNSDQFA[type];

    private static ImmutableDictionary<HFAKDWBWHWS, QKFYSCAUMKI> MZJKGJDFWEZ(TOZMFKJTCKW assetProvider)
    {
        ImmutableDictionary<HFAKDWBWHWS, QKFYSCAUMKI>.Builder tables = ImmutableDictionary.CreateBuilder<HFAKDWBWHWS, QKFYSCAUMKI>();

        IEnumerable<Type> types = Assembly.GetExecutingAssembly().GetTypes()
                                  .Where(type => type.GetCustomAttribute<ExcelAttribute>() != null);

        foreach (Type type in types)
        {
            ExcelAttribute attribute = type.GetCustomAttribute<ExcelAttribute>()!;

            JsonDocument tableJson = assetProvider.GetExcelTableJson(attribute.AssetName);
            tables.Add(attribute.Type, new QKFYSCAUMKI(tableJson, type));
        }

        return tables.ToImmutable();
    }
}
