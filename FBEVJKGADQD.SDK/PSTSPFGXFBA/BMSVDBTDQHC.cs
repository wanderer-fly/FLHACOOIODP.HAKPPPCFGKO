using System.Text.Json;
using FBEVJKGADQD.SDK.SLCHESBDUOL;

namespace FBEVJKGADQD.SDK.PSTSPFGXFBA;

public static class BMSVDBTDQHC
{
    public static IResult KDUUYYUBEUZ()
    {
        // TODO: account system

        XDDHAAUEDJI response = new()
        {
            Data = new()
            {
                Account = new()
                {
                    AreaCode = "**",
                    Country = "RU",
                    Email = "FBEVJKGADQD",
                    IsEmailVerify = "1",
                    Token = "mostsecuretokenever",
                    Uid = "1337"
                }
            }
        };

        return IUGSFWGFIQH(JsonSerializer.Serialize(response));
    }

    public static async Task<IResult> JZPDADUNSXB(HttpRequest httpRequest)
    {
        LXWEPTNPNKI? request = await httpRequest.ReadFromJsonAsync<LXWEPTNPNKI>();
        if (request is null) return Results.BadRequest();

        LXWEPTNPNKI.THFLBEDWBLH? data = JsonSerializer.Deserialize<LXWEPTNPNKI.THFLBEDWBLH>(request.Data);
        if (data is null) return Results.BadRequest();

        string? openId = data.OpenId;
        string? token = data.Token;

        return IUGSFWGFIQH($$"""{"retcode":0,"message":"OK","data":{"combo_id":1,"open_id":{{openId}},"combo_token":"{{token}}","data":"{\"guest\":false}","heartbeat":false,"account_type":1,"fatigue_remind":null}""");
    }

    public static IResult NITRAEGRAKZ() =>
        IUGSFWGFIQH("""{"data":{"id":"06611ed14c3131a676b19c0d34c0644b","action":"ACTION_NONE","geetest":null},"message":"OK","retcode":0}""");

    private static IResult IUGSFWGFIQH(string jsonString) =>
        TypedResults.Text(jsonString, "application/json");
}
