namespace Lambda1.Domain.Helper
{
    public sealed class Product(int productId, string productName)
    {
        public int ProductId { get; } = productId;
        public string ProductName { get; } = productName;
    }
}
