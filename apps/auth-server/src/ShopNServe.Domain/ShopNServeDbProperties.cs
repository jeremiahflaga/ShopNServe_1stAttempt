namespace ShopNServe;

public static class ShopNServeDbProperties
{
    public static string DbTablePrefix { get; set; } = "ShopNServe";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "ShopNServe";
}
