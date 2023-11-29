using System.Collections.Immutable;
using System.Text.Json;
using FBEVJKGADQD.Common.HSFCATOPDTI.YOZTFEGPOUY;
using Microsoft.Extensions.Logging;

namespace FBEVJKGADQD.Common.HSFCATOPDTI.GNECZXLXXHH;
public class QOAXVAVOKZE
{
    private readonly ImmutableDictionary<uint, WNWAXNOBQJX> _avatarConfigs;

    public QOAXVAVOKZE(TOZMFKJTCKW assetProvider, ILogger<QOAXVAVOKZE> logger, QBKOFDBXXPD dataHelper)
    {
        _avatarConfigs = LoadAvatarConfigs(assetProvider, dataHelper);

        logger.LogInformation("Loaded {count} avatar configs", _avatarConfigs.Count);
    }

    public WNWAXNOBQJX GetAvatarConfig(uint id)
    {
        return _avatarConfigs[id];
    }

    private static ImmutableDictionary<uint, WNWAXNOBQJX> LoadAvatarConfigs(TOZMFKJTCKW assetProvider, QBKOFDBXXPD dataHelper)
    {
        ImmutableDictionary<uint, WNWAXNOBQJX>.Builder builder = ImmutableDictionary.CreateBuilder<uint, WNWAXNOBQJX>();
        IEnumerable<string> avatarConfigFiles = assetProvider.EnumerateAvatarConfigFiles();

        foreach (string avatarConfigFile in avatarConfigFiles)
        {
            string avatarName = avatarConfigFile[(avatarConfigFile.LastIndexOf('_') + 1)..];
            avatarName = avatarName.Remove(avatarName.IndexOf('.'));

            if (dataHelper.CMAWEWLEHZW(avatarName, out uint id))
            {
                JsonDocument configJson = assetProvider.GetFileAsJsonDocument(avatarConfigFile);
                if (configJson.RootElement.ValueKind != JsonValueKind.Object)
                    throw new JsonException($"BinDataCollection::LoadAvatarConfigs - expected an object, got {configJson.RootElement.ValueKind}");

                WNWAXNOBQJX avatarConfig = configJson.RootElement.Deserialize<WNWAXNOBQJX>()!;
                builder.Add(id, avatarConfig);
            }
            else
            {
                throw new KeyNotFoundException($"BinDataCollection::LoadAvatarConfigs - failed to resolve avatar id for {avatarName}");
            }
        }

        return builder.ToImmutable();
    }
}
