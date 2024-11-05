namespace MultiShop.Catalog.Services.StatisticServices
{
    public interface IStatisticServices
    {
        int GetCategoryCount();
        int GetProductCount();
        int GetBrandCount();
        decimal GetProducAvgPrice();
    }
}
