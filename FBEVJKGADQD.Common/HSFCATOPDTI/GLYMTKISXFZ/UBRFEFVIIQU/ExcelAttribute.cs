namespace FBEVJKGADQD.Common.HSFCATOPDTI.GLYMTKISXFZ.UBRFEFVIIQU;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
internal class ExcelAttribute : Attribute
{
    public HFAKDWBWHWS Type { get; }
    public string AssetName { get; }

    public ExcelAttribute(HFAKDWBWHWS type, string assetName)
    {
        Type = type;
        AssetName = assetName;
    }
}
