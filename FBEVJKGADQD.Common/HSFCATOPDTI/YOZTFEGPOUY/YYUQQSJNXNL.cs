using System.Text.Json;

namespace FBEVJKGADQD.Common.HSFCATOPDTI.YOZTFEGPOUY;
internal sealed class YYUQQSJNXNL : TOZMFKJTCKW
{
    private const string ExcelDirectory = "assets/excel/";
    private const string AvatarConfigDirectory = "assets/binout/avatar/";

    public IEnumerable<string> EnumerateAvatarConfigFiles()
    {
        return Directory.GetFiles(AvatarConfigDirectory);
    }

    public JsonDocument GetFileAsJsonDocument(string fullPath)
    {
        using FileStream fileStream = new(fullPath, FileMode.Open, FileAccess.Read);
        return JsonDocument.Parse(fileStream);
    }

    public JsonDocument GetExcelTableJson(string assetName)
    {
        string filePath = string.Concat(ExcelDirectory, assetName);
        using FileStream fileStream = new(filePath, FileMode.Open, FileAccess.Read);

        return JsonDocument.Parse(fileStream);
    }
}
