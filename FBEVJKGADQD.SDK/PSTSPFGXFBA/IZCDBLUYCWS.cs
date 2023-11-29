using System.Text.Json;
using FBEVJKGADQD.Common.OPLZFFRUAJP;
using FBEVJKGADQD.Protocol;
using Google.Protobuf;

namespace FBEVJKGADQD.SDK.PSTSPFGXFBA;

public static class IZCDBLUYCWS
{
    private const string CLIENT_CUSTOM_CONFIG = "{\"sdkenv\":\"2\",\"checkdevice\":\"false\",\"loadPatch\":\"false\",\"showexception\":\"false\",\"regionConfig\":\"pm|fk|add\",\"downloadMode\":\"0\"}";
    private static readonly string s_queryRegionListRsp;
    private static readonly string s_queryCurRegionRsp;

    static IZCDBLUYCWS()
    {
        s_queryRegionListRsp = BuildQueryRegionListResponse();
        s_queryCurRegionRsp = BuildQueryCurrentRegionResponse();
    }

    public static IResult KVSQCDMUFBP() => TypedResults.Text(s_queryRegionListRsp, "text/plain");
    public static IResult OnQueryCurRegion() => TypedResults.Text(s_queryCurRegionRsp, "application/json");

    private static string BuildQueryCurrentRegionResponse()
    {
        QueryCurrRegionHttpRsp rsp = new()
        {
            ClientSecretKey = ByteString.CopyFrom(FHFWWIHCNVD.JKJUVVAHADS),
            RegionInfo = new()
            {
                GateserverIp = "127.0.0.1",
                GateserverPort = 22101
            }
        };

        byte[] encryptedResponse = FHFWWIHCNVD.JRENKFLHPQK(rsp.ToByteArray());
        byte[] signature = Array.Empty<byte>(); // signature verification bypassed with EncryptionPatch

        return JsonSerializer.Serialize(new
        {
            content = Convert.ToBase64String(encryptedResponse),
            sign = Convert.ToBase64String(signature)
        });
    }

    private static string BuildQueryRegionListResponse()
    {
        byte[] clientCustomConfigEncrypted = FHFWWIHCNVD.ZCNQFTFYYPC(CLIENT_CUSTOM_CONFIG, FHFWWIHCNVD.ZNYPCCYFNHY);

        QueryRegionListHttpRsp rsp = new()
        {
            ClientCustomConfigEncrypted = ByteString.CopyFrom(clientCustomConfigEncrypted),
            ClientSecretKey = ByteString.CopyFrom(FHFWWIHCNVD.JKJUVVAHADS),
            EnableLoginPc = true,
            RegionList =
            {
                new RegionSimpleInfo
                {
                    Type = "DEV_PUBLIC",
                    DispatchUrl = "http://127.0.0.1:8888/query_cur_region",
                    Name = "os_russia",
                    Title = "FBEVJKGADQD"
                }
            },
            Retcode = Retcode.RET_SUCC
        };

        return Convert.ToBase64String(rsp.ToByteArray());
    }
}
