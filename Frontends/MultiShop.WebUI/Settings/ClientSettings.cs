namespace MultiShop.WebUI.Settings
{
    public class ClientSettings
    {
        public Client MultiShopVisitorClientId { get; set; }
        public Client MultiShopManagerClientId { get; set; }
        public Client MultiShopAdminClientId { get; set; }
    }

    public class Client
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
